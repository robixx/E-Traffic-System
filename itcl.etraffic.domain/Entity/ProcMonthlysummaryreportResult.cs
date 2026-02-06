using System;


namespace itcl.etraffic.domain.Entity
{
    public class ProcMonthlysummaryreportResult
    {
        public string? Month { get; set; }
        public int? Totalcase { get; set; }
        public decimal? Totaamount { get; set; }
        public decimal? Collectionamount { get; set; }
    }
}