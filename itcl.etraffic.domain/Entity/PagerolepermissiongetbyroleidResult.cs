using System;


namespace itcl.etraffic.domain.Entity
{
    public class PagerolepermissiongetbyroleidResult
    {
        public long Iid { get; set; }
        public long Roleid { get; set; }
        public long Pageid { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Updatedate { get; set; }
        public long Createby { get; set; }
        public long Updateby { get; set; }
        public int Isremoved { get; set; }
    }
}