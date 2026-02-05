using System;

namespace itcl.etraffic.domain.Entity
{

    public class HanddelivereddatasearchbycaseidResult
    {
        public long  Rownumber { get; set; }
        public long Caseid { get; set; }
        public string? Vehiclenumber { get; set; }
        public decimal Collectionamount { get; set; }
        public DateTime? Offencedate { get; set; }
        public DateTime? Collectiondate { get; set; }
        public string? Paymentmedium { get; set; }
        public string? Status { get; set; }
    }
}