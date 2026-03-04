using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerGetdumpingstationlistallResult
    {
        public long StationId { get; set; }
        public string? Stationname { get; set; }
        public string? Stationaddress { get; set; }
        public int Divisionid { get; set; }
        public string? Division { get; set; }
        public int IsRemoved { get; set; }
        public string? Status { get; set; }
    }

}