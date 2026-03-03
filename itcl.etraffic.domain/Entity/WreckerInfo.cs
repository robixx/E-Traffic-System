using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerInfo
    {
        public int IId { get; set; }
        public string? Wrecker { get; set; }
        public int Divisionid { get; set; }
        public int IsRemoved { get; set; }
    }
}