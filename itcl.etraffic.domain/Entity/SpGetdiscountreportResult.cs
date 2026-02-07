using System;


namespace itcl.etraffic.domain.Entity
{
    public class SpGetdiscountreportResult
    {
        public long Caseid { get; set; }
        public string? Vehicleno { get; set; }
        public decimal? Totalamount { get; set; }
        public decimal Collectedamount { get; set; }
        public decimal? Discountedration { get; set; }
        public decimal? Discountedamount { get; set; }
        public string? Discountedby { get; set; }
        public string? Division { get; set; }
        public DateTime? Discountdate { get; set; }
        public string? Status { get; set; }
    }
}