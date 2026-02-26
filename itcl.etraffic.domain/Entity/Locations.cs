using System;

namespace itcl.etraffic.domain.Entity
{

    public class Locations
    {
        public int IId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int DivisionId { get; set; }
        public int IsRemoved { get; set; }
    }
}