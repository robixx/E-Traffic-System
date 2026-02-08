using System;


namespace itcl.etraffic.domain.Entity
{
    public class VehiclecaseinquerybyvehiclenoResult
    {
        public long Iid { get; set; }
        public string? Formno { get; set; }
        public string? Serialno { get; set; }
        public int Vehicleregistrationid { get; set; }
        public int Seriesid { get; set; }
        public string? Vehicleno { get; set; }
        public int? Isspecial { get; set; }
        public string? Accusedperson { get; set; }
        public string? Owneraddress { get; set; }
        public DateTime? Dateofoffence { get; set; }
        public DateTime? Dateofhearing { get; set; }
        public Int64? Sergeantid { get; set; }
        public int? Status { get; set; }
        public int Paymentstatus { get; set; }
        public decimal Total { get; set; }
        public string? Drivinglicence { get; set; }
        public DateTime Createdate { get; set; }
        public string? MobileNo { get; set; }
        public string? Comments { get; set; }
        public string? Prosecutioncode { get; set; }
        public string? Seizeddocument { get; set; }
    }
}