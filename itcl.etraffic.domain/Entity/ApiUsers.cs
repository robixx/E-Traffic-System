using System;


namespace itcl.etraffic.domain.Entity
{


    public class Apiusers
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? SessionKey { get; set; }
        public int? Channelid { get; set; }
        public int Isactive { get; set; }
    }
}