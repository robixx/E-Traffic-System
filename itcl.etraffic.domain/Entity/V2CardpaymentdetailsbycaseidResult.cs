using System;



namespace itcl.etraffic.domain.Entity
{
    public class V2CardpaymentdetailsbycaseidResult
    {
        public long Caseid { get; set; }
        public string? Unitname { get; set; }
        public string? Cardno { get; set; }
        public DateTime? Paymentdate { get; set; }
        public decimal? Fineamount { get; set; }
        public decimal? Discountedamount { get; set; }
        public decimal? Payableamount { get; set; }
        public decimal Collectionamount { get; set; }
        public string? Paymentmedium { get; set; }
    }
}