using itcl.etraffic.application.Interface;
using itcl.etraffic.application.ViewDto;
using itcl.etraffic.persistance.DataConnection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.infrastructure.Service
{
    public class ProsecutorService : IProsecution
    {
        private readonly DMPDBContext _dmpdbcontext;

        public ProsecutorService(DMPDBContext dmpdbcontext)
        {
            _dmpdbcontext = dmpdbcontext;
        }
        public async Task<(string Message, bool Status, List<ProsecutionCommentDto> Comment)> getProsecutionCommentAsync()
        {
            try
            {
                var result = await _dmpdbcontext.ProsecutionComments
                            .AsNoTracking() // improves performance (read-only)
                            .Where(x => x.IsRemoved == 0)
                            .GroupBy(x => x.ProsecutionId)
                            .Select(g => new ProsecutionCommentDto
                            {
                                ProsecutionId = g.Key,
                                Comments = g
                                    .OrderByDescending(c => c.CID) // optional: latest first
                                    .Select(c => new ProsecutionCommentDetailsDto
                                    {
                                        CID = c.CID,
                                        Comments = c.Comments,
                                        IsRemoved = c.IsRemoved
                                    })
                                    .ToList()
                            })
                            .ToListAsync();

                return ("Data Retrieved Successfully.", true, result);

            }
            catch (Exception ex)
            {
                string actionName = $"{nameof(ProsecutorService)}.{nameof(getProsecutionCommentAsync)}";
                return ($"{actionName} : {ex.Message}", false, new List<ProsecutionCommentDto>());
            }
        }
    }
}
