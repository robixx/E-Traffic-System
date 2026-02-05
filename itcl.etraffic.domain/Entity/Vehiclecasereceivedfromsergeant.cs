using System;

public class Vehiclecasereceivedfromsergeant
{
    public decimal Id { get; set; }
    public long Vehiclecaseid { get; set; }
    public long Casereceivedby { get; set; }
    public DateTime Casereceiveddate { get; set; }
    public int? Isremoved { get; set; }
    public long? Updateby { get; set; }
    public DateTime? Updatedate { get; set; }
}
