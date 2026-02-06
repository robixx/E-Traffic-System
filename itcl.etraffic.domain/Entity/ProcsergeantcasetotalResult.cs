using System;


namespace itcl.etraffic.domain.Entity
{
    public class ProcsergeantcasetotalResult
    {
        public long IId { get; set; }
        public string? Sergentname { get; set; }
        public string? Sergentcode { get; set; }
        public int? Totalcasecount { get; set; }
        public decimal? Totalamount { get; set; }
    }
}