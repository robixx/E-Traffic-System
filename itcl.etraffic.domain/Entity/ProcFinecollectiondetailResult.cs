using System;


namespace itcl.etraffic.domain.Entity
{
    public class ProcFinecollectiondetailResult
    {
        public long? Serialno { get; set; }
        public long CaseId { get; set; }
        public string? Vehiclenumber { get; set; }
        public string? Division { get; set; }
        public DateTime? Offencedate { get; set; }
        public DateTime? Collectiondate { get; set; }
        public double? Collectionamount { get; set; }
        public string? Collectedby { get; set; }
    }
}
