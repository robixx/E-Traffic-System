using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerGetwreckercasebycaseidforprosecutionResult
    {
        public long Caseid { get; set; }
        public DateTime? Dateofoffence { get; set; }
        public string? Vehiclenumber { get; set; }
        public string? Wreckernumber { get; set; }
        public string? Wreckerdivision { get; set; }
        public decimal Totalfineamount { get; set; }
        public string? Paymentstatus { get; set; }
        public string? Casestatus { get; set; }
    }
}