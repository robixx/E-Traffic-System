using System;

namespace itcl.etraffic.domain.Entity
{
    public class SecRoleModules
    {
        public int Rolemoduleid { get; set; }
        public int Roleid { get; set; }
        public int Moduleid { get; set; }
        public int Insertby { get; set; }
        public DateTime Insertdate { get; set; }
        public int Status { get; set; }
    }
}