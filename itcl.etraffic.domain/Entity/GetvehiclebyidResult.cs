using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetvehiclebyidResult
    {
        public long IId { get; set; }
        public int Vehicleregistrationid { get; set; }
        public string? Vehicleno { get; set; }
        public string? Ownername { get; set; }
        public string? Owneraddress { get; set; }
        public DateTime Dateofregistration { get; set; }
        public DateTime Renewofregistration { get; set; }
        public string? Engineno { get; set; }
        public string? Chassisno { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Updatedate { get; set; }
        public string? Vehicleregistration { get; set; }
        public string? Vehicleseries { get; set; }
        public long Createby { get; set; }
        public long Updateby { get; set; }
        public int IsRemoved { get; set; }
    }
}
