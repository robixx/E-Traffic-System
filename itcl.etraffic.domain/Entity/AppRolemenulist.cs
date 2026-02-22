using System;


namespace itcl.etraffic.domain.Entity
{
    public class AppRolemenulist
    {
        public long RoleMenuId { get; set; }
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public int Createdby { get; set; }
        public DateTime Createdate { get; set; }
        public int IsActive { get; set; }
    }
}