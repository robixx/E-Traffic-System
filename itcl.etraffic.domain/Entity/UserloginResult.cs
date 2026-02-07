using System;


namespace itcl.etraffic.domain.Entity
{
    public class UserloginResult
    {
        public long Userid { get; set; }
        public string? Fullname { get; set; }
        public int Divisionid { get; set; }
        public string? Divisionname { get; set; }
        public int Roleid { get; set; }
        public string? Rolename { get; set; }
    }
}