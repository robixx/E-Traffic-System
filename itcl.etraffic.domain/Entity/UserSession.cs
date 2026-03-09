using System;


namespace itcl.etraffic.domain.Entity
{
    public class UserSession
    {
        public long IId { get; set; }
        public long UserId { get; set; }
        public string? Sessionid { get; set; }
        public DateTime Createdad { get; set; }
        public int Isactive { get; set; }
    }
}