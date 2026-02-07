using System;


namespace itcl.etraffic.domain.Entity
{
    public class SpRptSftpResult
    {
        public long Caseid { get; set; }
        public string? Vehicleno { get; set; }
        public DateTime? Offencedate { get; set; }
        public DateTime? Paymentdate { get; set; }
        public decimal Collectionamount { get; set; }
        public string? Paymentmedium { get; set; }
        public string? Subunitname { get; set; }
        public string? Transection { get; set; }
    }
}