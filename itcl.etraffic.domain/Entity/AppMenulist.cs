using System;


namespace itcl.etraffic.domain.Entity
{


    public class AppMenulist
    {
        public int MenuId { get; set; }
        public string? Menuname { get; set; }
        public string? Routename { get; set; }
        public string? Areaname { get; set; }
        public string? Controllername { get; set; }
        public string? Actionname { get; set; }
        public int IsMainMenu { get; set; }
        public int ParentId { get; set; }
        public int IsActive { get; set; }
        public int Vieworder { get; set; }
    }
}
