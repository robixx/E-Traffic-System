using System;


namespace itcl.etraffic.domain.Entity
{
    public class Role
    {
        public long Iid { get; set; }
        public string? Name { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Updatedate { get; set; }
        public long Createby { get; set; }
        public long Updateby { get; set; }
        public int Isremoved { get; set; }
    }
}