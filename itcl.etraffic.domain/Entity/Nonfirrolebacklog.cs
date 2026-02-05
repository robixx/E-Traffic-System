using System;


namespace itcl.etraffic.domain.Entity
{
    public class Nonfirrolebacklog
    {
        public long Rolebackid { get; set; }
        public long Caseid { get; set; }
        public long Userid { get; set; }
        public string? Nonfirno { get; set; }
        public DateTime Rolebackdate { get; set; }
        public int Status { get; set; }
    }
}