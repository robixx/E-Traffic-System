using System;

namespace itcl.etraffic.domain.Entity
{
    public class CardpaymentReversal
    {
        public long IId { get; set; }
        public long CaseId { get; set; }
        public double Amount { get; set; }
        public string? Rrn { get; set; }
        public DateTime? Revreqtime { get; set; }
        public DateTime? Revtime { get; set; }
        public string? TerminalId { get; set; }
        public int? Revackby { get; set; }
        public DateTime? Revacdate { get; set; }
        public int RevStatus { get; set; }
    }
}