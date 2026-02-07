using System;


namespace itcl.etraffic.domain.Entity
{
    public class SecUserRoles
    {
        public long Userroleid { get; set; }
        public long Userid { get; set; }
        public int Roleid { get; set; }
        public int Insertby { get; set; }
        public DateTime Insertdate { get; set; }
        public int Status { get; set; }
    }
}