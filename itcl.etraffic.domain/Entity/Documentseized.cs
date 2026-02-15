using System;
using System.ComponentModel.DataAnnotations;

namespace itcl.etraffic.domain.Entity
{
    public class DocumentSeized
    {

        [Key]
        public int IId { get; set; }
        public string? ShortName { get; set; }
        public string? Name { get; set; }
        public string? BanglaShortName { get; set; }
        public string? BanglaName { get; set; }
        public int IsRemoved { get; set; }
    }
}