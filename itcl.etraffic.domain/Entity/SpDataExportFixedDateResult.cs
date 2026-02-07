using System;

namespace itcl.etraffic.domain.Entity
{
    public class SpDataExportFixedDateResult
    {
        public long Iid { get; set; }
        public string? Vehicleno { get; set; }
        public decimal Total { get; set; }
        public decimal Collectionamount { get; set; }
        public DateTime? Donedate { get; set; }
    }
}