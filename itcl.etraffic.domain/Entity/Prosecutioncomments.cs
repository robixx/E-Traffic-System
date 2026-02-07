using System;

namespace itcl.etraffic.domain.Entity
{
    public class Prosecutioncomments
    {
        public int Cid { get; set; }
        public string? Comments { get; set; }
        public int Prosecutionid { get; set; }
        public int Isremoved { get; set; }
    }
}