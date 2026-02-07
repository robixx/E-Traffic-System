using System;

namespace itcl.etraffic.domain.Entity
{
    public class WreckerTrafficinspector
    {
        public int Iid { get; set; }
        public string? Callsign { get; set; }
        public int Zoneid { get; set; }
        public int Divisionid { get; set; }
        public string? Trafficinspectorname { get; set; }
        public string? Trafficinspectorbpid { get; set; }
        public string? Contactnumber { get; set; }
        public int Isremoved { get; set; }
    }

}