using System;

public class SecPrivileges
{
    public int Privilegeid { get; set; }
    public string Description { get; set; }
    public string Privilegename { get; set; }
    public string Routename { get; set; }
    public int? Isparent { get; set; }
    public int? Privilegeparent { get; set; }
    public bool Isnav { get; set; }
    public bool Status { get; set; }
    public string Faicon { get; set; }
    public DateTime? Insertdate { get; set; }
    public DateTime? Updatedate { get; set; }
}
