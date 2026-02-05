using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetvehiclecaseforupdatebycaseidResult
    {
        public long Caseid { get; set; }
        public int Vehicleregistrationid { get; set; }
        public int Seriesid { get; set; }
        public string? Vehicleno { get; set; }
        public string? Chasisno { get; set; }
        public long Sergeantid { get; set; }
        public string? Location { get; set; }
        public string? Phonenumber { get; set; }
        public string? Accusedperson { get; set; }
        public string? Caseslipno { get; set; }
        public string? Ownername { get; set; }
        public string? Owneraddress { get; set; }
        public DateTime? Dateofoffence { get; set; }
        public DateTime? Dateofhearing { get; set; }
        public int Isspecial { get; set; }
        public int Specialtypeid { get; set; }
        public int Status { get; set; }
        public string? Comments { get; set; }
        public string? Drivinglicence { get; set; }
        public string? Nonfirno { get; set; }
        public int? Entrymediumid { get; set; }
        public decimal Total { get; set; }
    }
}