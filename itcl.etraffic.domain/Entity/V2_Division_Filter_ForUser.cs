using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.domain.Entity
{
    public  class V2_Division_Filter_ForUser
    {
        [Key]
        public int ID { get; set; }

        public int? UserId { get; set; }

        public int? DivisionId { get; set; }

        public int? IsActive { get; set; }
    }
}
