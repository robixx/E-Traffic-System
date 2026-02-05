using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetlocationallResult
    {
        public int Locationid { get; set; }
        public string? Locationname { get; set; }
        public string? Callsign { get; set; }
        public int Divisionid { get; set; }
        public string? Division { get; set; }
        public int Isremoved { get; set; }
        public string? Status { get; set; }
    }
}