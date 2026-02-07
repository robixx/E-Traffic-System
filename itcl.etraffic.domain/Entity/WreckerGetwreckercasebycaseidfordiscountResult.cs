using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerGetwreckercasebycaseidfordiscountResult
    {
        public long Caseid { get; set; }
        public DateTime? Dateofoffence { get; set; }
        public string? Vehiclenumber { get; set; }
        public string? Wreckernumber { get; set; }
        public string? Wreckerdivision { get; set; }
        public string? Accusedperson { get; set; }
        public string? Fathername { get; set; }
        public string? Contactnuber { get; set; }
        public decimal Totalfineamount { get; set; }
        public decimal? Payableamount { get; set; }
        public string? Paymentstatus { get; set; }
    }
}