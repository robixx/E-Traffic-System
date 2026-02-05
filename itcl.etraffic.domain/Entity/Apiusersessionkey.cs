using System;


namespace itcl.etraffic.domain.Entity
{
    public class Apiusersessionkey
    {
        public string? Username { get; set; }
        public string? Sessionkey { get; set; }
        public DateTime Sessiondate { get; set; }
        public int Isactive { get; set; }
    }
}