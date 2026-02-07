using System;

namespace itcl.etraffic.domain.Entity
{
    public class SergeantgetbycodeResult
    {
        public long Iid { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Cell { get; set; }
        public int? Zoneid { get; set; }
        public int? Divisionid { get; set; }
        public int? Isremoved { get; set; }
        public long? Designationid { get; set; }
    }
}