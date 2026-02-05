using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetApiCaseByRegnoResult
    {
        public long Caseid { get; set; }
        public string? Vehiclenumber { get; set; }
        public decimal? Fineamount { get; set; }
        public string? Subunit { get; set; }
        public string? Casestatus { get; set; }
    }
}