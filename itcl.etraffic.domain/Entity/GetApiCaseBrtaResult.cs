using System;


namespace itcl.etraffic.domain.Entity
{


    public class GetApiCaseBrtaResult
    {
        public long Caseid { get; set; }
        public string? Vehiclenumber { get; set; }
        public DateTime? Offencedate { get; set; }
        public string? Unit { get; set; }
        public string? Subunit { get; set; }
        public string? Accusedperson { get; set; }
        public string? Prosecution { get; set; }
        public string? Documentseized { get; set; }
        public string? Casestatus { get; set; }
    }
}
