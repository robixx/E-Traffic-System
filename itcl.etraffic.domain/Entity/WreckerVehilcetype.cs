using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerVehilcetype
    {
        public long IId { get; set; }
        public string? Typecode { get; set; }
        public string? Typename { get; set; }
        public decimal? Fineamount { get; set; }
        public decimal? Specialamount { get; set; }
        public int? IsRemoved { get; set; }
    }
}