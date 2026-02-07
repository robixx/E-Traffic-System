using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerVehiclecase
    {
        public long Iid { get; set; }
        public int Vehicleregistrationid { get; set; }
        public int Seriesid { get; set; }
        public string? Vehicleno { get; set; }
        public int? Vehicletype { get; set; }
        public string? Accusedperson { get; set; }
        public string? Fathername { get; set; }
        public string? Accusedpersonaddress { get; set; }
        public string? Ownername { get; set; }
        public string? Ownerfathername { get; set; }
        public string? Owneraddress { get; set; }
        public string? Ownercontactnumber { get; set; }
        public string? Contactnuber { get; set; }
        public string? Callsign { get; set; }
        public int? Divisionid { get; set; }
        public int? Zoneid { get; set; }
        public string? Wreckeroperatorcode { get; set; }
        public string? Wreckernumber { get; set; }
        public int? Wreckerdivisionid { get; set; }
        public long Sergentid { get; set; }
        public string? Tibpid { get; set; }
        public int? Spotfinepaid { get; set; }
        public int? Sentfordumping { get; set; }
        public int? Dumpinglocid { get; set; }
        public string? Dumpinglocname { get; set; }
        public string? Isspecial { get; set; }
        public DateTime Dateofoffence { get; set; }
        public decimal Totalfineamount { get; set; }
        public int? Entrymedium { get; set; }
        public decimal? Discountamount { get; set; }
        public long? Discountby { get; set; }
        public DateTime? Discountdate { get; set; }
        public decimal Collectionamount { get; set; }
        public DateTime? Donedate { get; set; }
        public int Paymentmedium { get; set; }
        public int Paymentstatus { get; set; }
        public long? Paymentreceiveby { get; set; }
        public string? Gdno { get; set; }
        public string? Comments { get; set; }
        public string? Location { get; set; }
        public int Casestatus { get; set; }
        public long? Createby { get; set; }
        public DateTime? Createdate { get; set; }
        public long? Updateby { get; set; }
        public DateTime? Updatedate { get; set; }
        public int? Isremoved { get; set; }
    }
}
