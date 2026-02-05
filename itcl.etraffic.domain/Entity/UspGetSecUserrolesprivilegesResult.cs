using System;

public class UspGetSecUserrolesprivilegesResult
{
    public Int32? Userid { get; set; }
    public String Username { get; set; }
    public Int32? Roleid { get; set; }
    public String Rolename { get; set; }
    public String Issysadmin { get; set; }
    public Int32? Privilegeid { get; set; }
    public String Privilegename { get; set; }
    public String Routename { get; set; }
    public Boolean? Isnav { get; set; }
    public Int32? Isparent { get; set; }
    public Boolean Cancreate { get; set; }
    public Boolean Canview { get; set; }
    public Boolean Candelete { get; set; }
    public Boolean Canedit { get; set; }
    public Boolean Canprint { get; set; }
}
