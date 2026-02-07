using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerGetwreckercasebycaseidforupdateResult
    {
        public long Caseid { get; set; }
        public DateTime? Dateofoffence { get; set; }
        public string? Vehiclenumber { get; set; }
        public string? Wreckernumber { get; set; }
        public int? Wreckerdivisionid { get; set; }
        public string? Wreckerdivision { get; set; }
        public int? Vehicletypeid { get; set; }
        public string? Vehicletype { get; set; }
        public string? Accusedperson { get; set; }
        public string? Fathername { get; set; }
        public string? Contactnuber { get; set; }
        public string? Owneraddress { get; set; }
        public string? Sentfordumpint { get; set; }
        public long Dumpinglocid { get; set; }
        public string? Dumpinglocname { get; set; }
        public decimal Totalfineamount { get; set; }
        public decimal? Payableamount { get; set; }
        public string? Paymentstatus { get; set; }
        public string? Gdno { get; set; }
    }
}