using System;

namespace itcl.etraffic.domain.Entity
{
    public class CardpaymentReversal
    {
        public long Iid { get; set; }
        public long Caseid { get; set; }
        public double Amount { get; set; }
        public string? Rrn { get; set; }
        public DateTime? Revreqtime { get; set; }
        public DateTime? Revtime { get; set; }
        public string? Terminalid { get; set; }
        public int? Revackby { get; set; }
        public DateTime? Revacdate { get; set; }
        public int Revstatus { get; set; }
    }
}