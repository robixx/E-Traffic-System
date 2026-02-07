using System;


namespace itcl.etraffic.domain.Entity
{

    public class UspMonthlyReportRemovedResult
    {
        public string? Division { get; set; }
        public int? TotalCase { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? UcblCount { get; set; }
        public decimal? PaymentReceivedByUcbl { get; set; }
    }
}