using System;

public class UspGetPrivilegesResult
{
    public String Privilegeparentname { get; set; }
    public Int32 Privilegeid { get; set; }
    public String Description { get; set; }
    public String Privilegename { get; set; }
    public String Routename { get; set; }
    public Int32? Isparent { get; set; }
    public Int32? Privilegeparent { get; set; }
    public Boolean Isnav { get; set; }
    public Boolean Status { get; set; }
    public String Faicon { get; set; }
    public DateTime? Insertdate { get; set; }
    public DateTime? Updatedate { get; set; }
    public Int32? Rolecount { get; set; }
}
