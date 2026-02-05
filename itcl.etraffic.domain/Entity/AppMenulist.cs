using System;


namespace itcl.etraffic.domain.Entity
{


    public class AppMenulist
    {
        public int Menuid { get; set; }
        public string? Menuname { get; set; }
        public string? Routename { get; set; }
        public string? Areaname { get; set; }
        public string? Controllername { get; set; }
        public string? Actionname { get; set; }
        public int Ismainmenu { get; set; }
        public int Parentid { get; set; }
        public int Isactive { get; set; }
        public int Vieworder { get; set; }
    }
}
