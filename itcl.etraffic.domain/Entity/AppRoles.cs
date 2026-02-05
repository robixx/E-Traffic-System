using System;

namespace itcl.etraffic.domain.Entity
{
    public class AppRoles
    {
        public int Roleid { get; set; }
        public string? Rolename { get; set; }
        public int Createdby { get; set; }
        public DateTime Createddate { get; set; }
        public int Isactive { get; set; }
    }
}