using System;

namespace itcl.etraffic.domain.Entity
{
    public class VehicleregistrationgetbyidResult
    {
        public int IId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Banglaname { get; set; }
        public int IsRemoved { get; set; }
    }
}