using System;


namespace itcl.etraffic.domain.Entity
{
    public class Cardtransactionlog
    {
        public long IId { get; set; }
        public long CaseId { get; set; }
        public double? Amount { get; set; }
        public DateTime? Paymentdate { get; set; }
        public DateTime? Reversaldate { get; set; }
        public int Paymentstatus { get; set; }
    }
}