using System;
using System.ComponentModel.DataAnnotations;
namespace itcl.etraffic.domain.Entity
{
    public class ProsecutionComments
    {
        [Key]
        public int CID{ get; set; }
        public string? Comments { get; set; }
        public int ProsecutionId { get; set; }
        public int IsRemoved { get; set; }
    }
}