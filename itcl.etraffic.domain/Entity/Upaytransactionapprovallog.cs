using System;


namespace itcl.etraffic.domain.Entity
{
    public class Upaytransactionapprovallog
    {
        public long Id { get; set; }
        public long Caseid { get; set; }
        public int Amount { get; set; }
        public string? Transactionapprovalcode { get; set; }
        public DateTime Transactiontime { get; set; }
        public string? Cardno { get; set; }
        public string? Rrn { get; set; }
        public string? Transactionresponsecode { get; set; }
    }
}