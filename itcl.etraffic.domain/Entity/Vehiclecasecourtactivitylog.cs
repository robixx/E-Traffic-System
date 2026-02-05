using System;

public class Vehiclecasecourtactivitylog
{
    public long Vehiclecaseid { get; set; }
    public int Sendtocourtby { get; set; }
    public int? Sendtocourtapprovedby { get; set; }
    public DateTime Sendtocourtdate { get; set; }
    public int Ordercreatedby { get; set; }
    public DateTime? Ordercreateddate { get; set; }
    public int Arrestwarrantcreatedby { get; set; }
    public DateTime? Arrestwarrantcreateddate { get; set; }
    public int Status { get; set; }
    public long Challanno { get; set; }
    public int Divisionid { get; set; }
    public DateTime? Updatedate { get; set; }
    public int? Challanreceiver { get; set; }
    public DateTime? Challanreceiveddate { get; set; }
    public int? Isremoved { get; set; }
}
