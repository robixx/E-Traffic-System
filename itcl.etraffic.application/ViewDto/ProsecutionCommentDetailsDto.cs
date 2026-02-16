using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.application.ViewDto
{
    public class ProsecutionCommentDetailsDto
    {
        public int CID { get; set; }
        public string? Comments { get; set; }        
        public int IsRemoved { get; set; }
    }
}
