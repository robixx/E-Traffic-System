using System;

public class V2CardpaymentdetailsbycaseidResult
{
    public Int64 Caseid { get; set; }
    public String Unitname { get; set; }
    public String Cardno { get; set; }
    public DateTime? Paymentdate { get; set; }
    public Decimal? Fineamount { get; set; }
    public Decimal? Discountedamount { get; set; }
    public Decimal? Payableamount { get; set; }
    public Decimal Collectionamount { get; set; }
    public String Paymentmedium { get; set; }
}
