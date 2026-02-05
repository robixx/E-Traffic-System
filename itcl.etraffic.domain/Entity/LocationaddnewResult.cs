using System;


namespace itcl.etraffic.domain.Entity
{
    public class LocationaddnewResult
    {
        public long Iid { get; set; }
        public string? Stationname { get; set; }
        public string? Stationaddress { get; set; }
        public int Divisionid { get; set; }
        public int Isremoved { get; set; }
    }
}