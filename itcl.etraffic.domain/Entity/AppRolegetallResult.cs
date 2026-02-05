using System;


namespace itcl.etraffic.domain.Entity
{
    public class AppRolegetallResult
    {
        public int Roleid { get; set; }
        public String? Rolename { get; set; }
        public DateTime Createddate { get; set; }
        public int Createdby { get; set; }
        public int Isactive { get; set; }
    }
}