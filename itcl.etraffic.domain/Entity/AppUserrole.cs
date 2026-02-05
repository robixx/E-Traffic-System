using System;



namespace itcl.etraffic.domain.Entity
{
    public class AppUserrole
    {
        public long Userroleid { get; set; }
        public int Userid { get; set; }
        public int Roleid { get; set; }
        public int Createdby { get; set; }
        public DateTime Createddate { get; set; }
        public int Isactive { get; set; }
    }
}