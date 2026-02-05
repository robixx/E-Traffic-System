using System;



namespace itcl.etraffic.domain.Entity
{
    public class GetApiCaseStatusResult
    {
        public long Caseid { get; set; }
        public string? Vehiclenumber { get; set; }
        public DateTime? Offencedate { get; set; }
        public decimal? Fineamount { get; set; }
        public decimal? Fees { get; set; }
        public string? Feecode { get; set; }
        public string? Subunit { get; set; }
        public string? Channel { get; set; }
        public string? Transactionnumber { get; set; }
        public string? Transactiondate { get; set; }
        public string? Transactiontime { get; set; }
        public string? Casestatus { get; set; }
    }
}
