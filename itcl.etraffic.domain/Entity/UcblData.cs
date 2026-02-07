using System;


namespace itcl.etraffic.domain.Entity
{
    public class UcblData
    {
        public long Caseid { get; set; }
        public DateTime? Offencedate { get; set; }
        public string? Vehiclenumber { get; set; }
        public string? Mobilenumber { get; set; }
        public int? Caseamount { get; set; }
        public DateTime? Paymentdate { get; set; }
    }
}