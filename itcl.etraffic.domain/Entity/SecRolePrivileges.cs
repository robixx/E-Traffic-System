using System;

public class SecRolePrivileges
{
    public int Roleprivilegeid { get; set; }
    public int Privilegeid { get; set; }
    public int Roleid { get; set; }
    public bool Cancreate { get; set; }
    public bool Canview { get; set; }
    public bool Canedit { get; set; }
    public bool Candelete { get; set; }
    public bool Canprint { get; set; }
    public int? Insertby { get; set; }
    public DateTime? Insertdate { get; set; }
    public bool? Status { get; set; }
}
