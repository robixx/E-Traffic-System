using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetrolewisemenuResult
    {
        public int Userid { get; set; }
        public int Roleid { get; set; }
        public string? Rolename { get; set; }
        public int Menuid { get; set; }
        public int Parentid { get; set; }
        public string? Menuname { get; set; }
        public string? Routename { get; set; }
        public string? Areaname { get; set; }
        public string? Controllername { get; set; }
        public string? Actionname { get; set; }
        public int Vieworder { get; set; }
    }
}