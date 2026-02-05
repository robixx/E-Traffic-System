using System;

namespace itcl.etraffic.domain.Entity
{

    public class Locations
    {
        public int Iid { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int Divisionid { get; set; }
        public int Isremoved { get; set; }
    }
}