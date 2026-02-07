using System;



namespace itcl.etraffic.domain.Entity
{
    public class WreckerGetwreckerwisecasedetailsResult
    {
        public DateTime? Dateofoffence { get; set; }
        public string? Vehiclenumber { get; set; }
        public string? Wreckernumber { get; set; }
        public string? Vehicletype { get; set; }
        public string? Wreckerdivision { get; set; }
        public string? Accusedperson { get; set; }
        public string? Fathername { get; set; }
        public string? Owneraddress { get; set; }
        public string? Contactnuber { get; set; }
        public string? Sergentname { get; set; }
        public string? Paymentstatus { get; set; }
        public decimal Totalfineamount { get; set; }
        public decimal Collectionamount { get; set; }
        public string? Sentfordumping { get; set; }
        public string? Spotfinepaid { get; set; }
    }
}