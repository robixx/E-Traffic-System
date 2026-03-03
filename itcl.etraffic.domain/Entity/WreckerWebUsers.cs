using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerWebUsers
    {
        public int UserId { get; set; }
        public string? Loginname { get; set; }
        public string? Fullname { get; set; }
        public string? Password { get; set; }
        public string? Passwordsalt { get; set; }
        public DateTime? Passwordchanged { get; set; }
        public DateTime? Lastlogin { get; set; }
        public int Usertype { get; set; }
        public int IsRemove { get; set; }
    }
}
