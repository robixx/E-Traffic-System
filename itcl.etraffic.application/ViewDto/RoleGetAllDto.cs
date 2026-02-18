using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.application.ViewDto
{
    public class RoleGetAllDto
    {
        public long IID { get; set; }
        public string? Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public long CreateBy { get; set; }
        public long UpdateBy { get; set; }
        public int IsRemoved { get; set; }
    }
}
