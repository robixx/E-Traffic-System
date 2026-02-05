using System;

public class VehiclegetbyidResult
{
    public Int64 Iid { get; set; }
    public Int32 Vehicleregistrationid { get; set; }
    public Int32 Vehicleseriesid { get; set; }
    public String Vehicleno { get; set; }
    public String Ownername { get; set; }
    public String Owneraddress { get; set; }
    public DateTime Dateofregistration { get; set; }
    public DateTime Renewofregistration { get; set; }
    public String Engineno { get; set; }
    public String Chassisno { get; set; }
    public DateTime Createdate { get; set; }
    public DateTime Updatedate { get; set; }
    public Int64 Createby { get; set; }
    public Int64 Updateby { get; set; }
    public Int32 Isremoved { get; set; }
}
