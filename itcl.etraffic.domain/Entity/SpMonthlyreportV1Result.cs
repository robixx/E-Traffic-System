using System;


namespace itcl.etraffic.domain.Entity
{
    public class SpMonthlyreportV1Result
    {
        public string? Divisionname { get; set; }
        public int? Totalcase { get; set; }
        public decimal? Totalamount { get; set; }
        public int? Ucblcasecount { get; set; }
        public decimal? Paymentreceivedbyucbl { get; set; }
    }
}