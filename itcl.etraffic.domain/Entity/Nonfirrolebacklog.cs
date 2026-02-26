using System;


namespace itcl.etraffic.domain.Entity
{
    public class Nonfirrolebacklog
    {
        public long RolebackId { get; set; }
        public long CaseId { get; set; }
        public long UserId { get; set; }
        public string? Nonfirno { get; set; }
        public DateTime Rolebackdate { get; set; }
        public int Status { get; set; }
    }
}