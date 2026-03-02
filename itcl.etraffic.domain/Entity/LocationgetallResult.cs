using System;



namespace itcl.etraffic.domain.Entity
{
    public class LocationgetallResult
    {
        public int IId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int Divisionid { get; set; }
        public int IsRemoved { get; set; }
    }
}