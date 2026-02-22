using System;


namespace itcl.etraffic.domain.Entity
{


    public class Apiusers
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? SessionKey { get; set; }
        public int? ChannelId { get; set; }
        public int IsActive { get; set; }
    }
}