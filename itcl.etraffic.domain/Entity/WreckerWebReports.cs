using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerWebReports
    {
        public int Rid { get; set; }
        public string? Reportname { get; set; }
        public string? Reporturl { get; set; }
        public string? Reporttitle { get; set; }
        public int Isremove { get; set; }
    }
}