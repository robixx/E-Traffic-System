using System;


namespace itcl.etraffic.domain.Entity
{
    public class UspGetSecUserrolesprivilegesResult
    {
        public int? Userid { get; set; }
        public string? Username { get; set; }
        public int? Roleid { get; set; }
        public string? Rolename { get; set; }
        public string? Issysadmin { get; set; }
        public int? Privilegeid { get; set; }
        public string? Privilegename { get; set; }
        public string? Routename { get; set; }
        public Boolean? Isnav { get; set; }
        public int? Isparent { get; set; }
        public bool Cancreate { get; set; }
        public bool Canview { get; set; }
        public bool Candelete { get; set; }
        public bool Canedit { get; set; }
        public bool Canprint { get; set; }
    }
}