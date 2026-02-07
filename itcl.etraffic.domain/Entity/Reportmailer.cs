using System;


namespace itcl.etraffic.domain.Entity
{
    public class Reportmailer
    {
        public string? Mailname { get; set; }
        public string? Reportheader { get; set; }
        public string? Tolist { get; set; }
        public string? Cclist { get; set; }
    }
}