using System;
using System.ComponentModel.DataAnnotations;

namespace itcl.etraffic.domain.Entity
{
    public class SerialNoType
    {
        [Key]
        public int IId { get; set; }
        public string? Name { get; set; }
        public int Isremoved { get; set; }
    }
}