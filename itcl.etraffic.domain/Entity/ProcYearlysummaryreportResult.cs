using System;


namespace itcl.etraffic.domain.Entity
{
    public class ProcYearlysummaryreportResult
    {
        public string? Year { get; set; }
        public string? Division { get; set; }
        public int? Totalcase { get; set; }
        public decimal? Totaamount { get; set; }
        public decimal? Collectionamount { get; set; }
    }
}