using System;


namespace itcl.etraffic.domain.Entity
{
    public class LocationaddnewResult
    {
        public long IId { get; set; }
        public string? Stationname { get; set; }
        public string? Stationaddress { get; set; }
        public int Divisionid { get; set; }
        public int IsRemoved { get; set; }
    }
}