using System;


namespace itcl.etraffic.domain.Entity
{
    public class PGetalluserinformationResult
    {
        public long Userid { get; set; }
        public string? Fullname { get; set; }
        public string? Loginname { get; set; }
        public string? Phone { get; set; }
        public string? Cell { get; set; }
        public string? Email { get; set; }
        public DateTime? Usercreated { get; set; }
        public int? Divisionid { get; set; }
        public string? Divisionname { get; set; }
        public string? Userstatus { get; set; }
    }
}