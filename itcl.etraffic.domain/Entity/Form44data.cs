using System;


namespace itcl.etraffic.domain.Entity
{
    public class Form44data
    {
        public long CaseId { get; set; }
        public string? Witness1bpId { get; set; }
        public string? Witness1name { get; set; }
        public string? Witness1father { get; set; }
        public string? Witness1contact { get; set; }
        public string? Witness1address { get; set; }
        public string? Witness2bpId { get; set; }
        public string? Witness2name { get; set; }
        public string? Witness2father { get; set; }
        public string? Witness2contact { get; set; }
        public string? Witness2address { get; set; }
        public long Insertby { get; set; }
        public DateTime Insertdate { get; set; }
        public long? Orderby { get; set; }
        public DateTime? Orderdate { get; set; }
        public string? Crnumber { get; set; }
        public int Status { get; set; }
    }
}
