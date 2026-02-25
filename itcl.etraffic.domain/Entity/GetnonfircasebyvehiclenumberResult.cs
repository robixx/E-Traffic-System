using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetnonfircasebyvehiclenumberResult
    {
        public long CaseId { get; set; }
        public string? Vehiclenumber { get; set; }
        public string? Nonfirno { get; set; }
        public string? Nonfirstatus { get; set; }
        public DateTime? Nonfirdate { get; set; }
        public string? Division { get; set; }
        public decimal? Totalamount { get; set; }
        public string? Prosecution { get; set; }
        public string? Documentseized { get; set; }
    }
}