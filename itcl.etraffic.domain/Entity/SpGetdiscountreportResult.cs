using System;


namespace itcl.etraffic.domain.Entity
{
    public class SpGetdiscountreportResult
    {
        public long Caseid { get; set; }
        public String? Vehicleno { get; set; }
        public Decimal? Totalamount { get; set; }
        public Decimal Collectedamount { get; set; }
        public Decimal? Discountedration { get; set; }
        public Decimal? Discountedamount { get; set; }
        public String? Discountedby { get; set; }
        public String? Division { get; set; }
        public DateTime? Discountdate { get; set; }
        public String? Status { get; set; }
    }
}