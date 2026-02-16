using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.application.ViewDto
{
    public class ProsecutionCommentDto
    {
        public int ProsecutionId { get; set; }
        public List<ProsecutionCommentDetailsDto>?Comments { get; set; }
    }
}
