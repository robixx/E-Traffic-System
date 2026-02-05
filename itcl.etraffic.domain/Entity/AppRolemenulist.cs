using System;


namespace itcl.etraffic.domain.Entity
{
    public class AppRolemenulist
    {
        public long Rolemenuid { get; set; }
        public int Roleid { get; set; }
        public int Menuid { get; set; }
        public int Createdby { get; set; }
        public DateTime Createdate { get; set; }
        public int Isactive { get; set; }
    }
}