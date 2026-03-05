using System;


namespace itcl.etraffic.domain.Entity
{
    public class Vehiclecaseprosecutioncomments
    {
        public long IId { get; set; }
        public long Caseid { get; set; }
        public int Prosecutionid { get; set; }
        public int Cid { get; set; }
        public int IsRemoved { get; set; }
    }
}