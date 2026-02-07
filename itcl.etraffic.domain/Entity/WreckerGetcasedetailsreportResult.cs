using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerGetcasedetailsreportResult
    {
        public long Caseid { get; set; }
        public string? Vehicleno { get; set; }
        public string? Typename { get; set; }
        public string? Accusedperson { get; set; }
        public string? Fathername { get; set; }
        public string? Ownername { get; set; }
        public string? Owneraddress { get; set; }
        public string? Contactnuber { get; set; }
        public string? Callsign { get; set; }
        public string? Division { get; set; }
        public string? Zone { get; set; }
        public string? Wreckeroperatorcode { get; set; }
        public string? Wreckernumber { get; set; }
        public string? Wreckerdivision { get; set; }
        public string? Sergeantname { get; set; }
        public string? Tiname { get; set; }
        public string? Spotpayment { get; set; }
        public string? Sentfordumpint { get; set; }
        public string? Stationname { get; set; }
        public DateTime Dateofoffence { get; set; }
        public decimal Totalfineamount { get; set; }
        public decimal? Waivedamount { get; set; }
        public DateTime? Discountdate { get; set; }
        public decimal Collectionamount { get; set; }
        public DateTime? Donedate { get; set; }
        public string? Paymentstatus { get; set; }
        public string? Gdno { get; set; }
    }
}