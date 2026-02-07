using System;

namespace itcl.etraffic.domain.Entity
{

    public class WreckerGetdatewisecasesummarybyvehicletypeResult
    {
        public DateTime? Offencedate { get; set; }
        public string? Division { get; set; }
        public string? Typename { get; set; }
        public int? Totalcase { get; set; }
        public decimal? Totalfineamount { get; set; }
    }
}
