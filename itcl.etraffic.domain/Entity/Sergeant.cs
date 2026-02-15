using System;
using System.ComponentModel.DataAnnotations;

namespace itcl.etraffic.domain.Entity
{
    public class Sergeant
    {
        [Key]
        public long IId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Cell { get; set; }
        public int? Zoneid { get; set; }
        public int? Divisionid { get; set; }
        public int? IsRemoved { get; set; }
        public long? Designationid { get; set; }
    }
}