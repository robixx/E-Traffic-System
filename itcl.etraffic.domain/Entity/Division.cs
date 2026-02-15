using System;
using System.ComponentModel.DataAnnotations;


namespace itcl.etraffic.domain.Entity
{
    public class Division
    {
        [Key]
        public int IId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int IsRemoved { get; set; }
    }
}
