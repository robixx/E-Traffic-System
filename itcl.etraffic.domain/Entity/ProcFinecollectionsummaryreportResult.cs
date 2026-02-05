using System;


namespace itcl.etraffic.domain.Entity
{
    public class ProcFinecollectionsummaryreportResult
    {
        public int? Sl { get; set; }
        public string? Year { get; set; }
        public string? Month { get; set; }
        public string? Division { get; set; }
        public decimal? CollectionAmount { get; set; }
        public int? TotalCase { get; set; }
    }
}