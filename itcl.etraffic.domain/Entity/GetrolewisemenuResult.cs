using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetrolewisemenuResult
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string? Rolename { get; set; }
        public int MenuId { get; set; }
        public int ParentId { get; set; }
        public string? Menuname { get; set; }
        public string? Routename { get; set; }
        public string? Areaname { get; set; }
        public string? Controllername { get; set; }
        public string? Actionname { get; set; }
        public int Vieworder { get; set; }
    }
}