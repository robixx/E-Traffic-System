using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetApiFineAmountResult
    {
        public long CaseId { get; set; }
        public string? Vehiclenumber { get; set; }
        public DateTime? Offencedate { get; set; }
        public decimal? Fineamount { get; set; }
        public decimal? Fees { get; set; }
        public string? Feecode { get; set; }
        public string? Paymentmedium { get; set; }
        public string? Source { get; set; }
        public string? Subunit { get; set; }
        public string? Casestatus { get; set; }
    }
}