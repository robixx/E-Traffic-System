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
    public class DropdownService : IDropDown
    {

        private readonly DMPDBContext _dmpdbcontext;

        public DropdownService(DMPDBContext dmpdbcontext)
        {
            _dmpdbcontext = dmpdbcontext;
        }
        public async Task<(string Message, bool Status, List<DropDown> datalist)> getBrtaDataAsync()
        {
            try
            {
                var Brtadata = await _dmpdbcontext.Vehicleregistration
                    .Where(i => i.Isremoved == 0)
                    .Select(i => new DropDown
                    {
                        Id = i.IId,
                        Name = i.Code,

                    }).ToListAsync();

                return ("Data Retrieved Successfully.", true, Brtadata);

            }catch(Exception ex)
            {
                string actionName = $"{nameof(DropdownService)}.{nameof(getBrtaDataAsync)}";
                return ($"{actionName} : {ex.Message}", false, new List<DropDown>());
            }
        }
    }
}
