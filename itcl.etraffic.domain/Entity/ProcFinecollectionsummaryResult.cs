using System;



namespace itcl.etraffic.domain.Entity
{
    public class ProcFinecollectionsummaryResult
    {
        public string? Workingdate { get; set; }
        public decimal Totalamount { get; set; }
        public decimal Robiamount { get; set; }
        public decimal Bankamount { get; set; }
        public decimal Dcofficeamount { get; set; }
        public decimal Ucblbankamount { get; set; }
        public decimal Ucashbankamount { get; set; }
    }
}