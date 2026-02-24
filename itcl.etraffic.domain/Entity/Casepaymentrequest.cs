using System;


namespace itcl.etraffic.domain.Entity
{
    public class Casepaymentrequest
    {
        public long CaseId { get; set; }
        public double Fineamount { get; set; }
        public DateTime Paymentdate { get; set; }
        public string? Reversalnumber { get; set; }
        public string? Trnnumber { get; set; }
        public DateTime? Revvalidtill { get; set; }
    }

}