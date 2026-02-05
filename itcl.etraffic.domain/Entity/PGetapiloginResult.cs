using System;


namespace itcl.etraffic.domain.Entity
{
    public class PGetapiloginResult
    {
        public int? Channelid { get; set; }
        public string? Channelname { get; set; }
        public string? Username { get; set; }
        public DateTime? Lastpasswordchanged { get; set; }
        public int? Userstatus { get; set; }
    }
}