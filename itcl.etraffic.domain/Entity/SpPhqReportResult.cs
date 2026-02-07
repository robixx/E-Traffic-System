using System;


namespace itcl.etraffic.domain.Entity
{
    public class SpPhqReportResult
    {
        public DateTime? Dateofoffence { get; set; }
        public int? Totalcase { get; set; }
        public decimal? Total { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Collected { get; set; }
    }
}