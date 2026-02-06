using System;


namespace itcl.etraffic.domain.Entity
{
    public class ProcProsecutionwisedetailcaseResult
    {
        public long Iid { get; set; }
        public DateTime Createdate { get; set; }
        public string? Vehileno { get; set; }
        public decimal Total { get; set; }
        public int Paymentstatus { get; set; }
    }
}