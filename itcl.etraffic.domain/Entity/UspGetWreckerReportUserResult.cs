using System;


namespace itcl.etraffic.domain.Entity
{
    public class UspGetWreckerReportUserResult
    {
        public int Userid { get; set; }
        public string? Fullname { get; set; }
        public string? Loginname { get; set; }
        public int? Totalreport { get; set; }
    }
}