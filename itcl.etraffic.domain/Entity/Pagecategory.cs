using System;


namespace itcl.etraffic.domain.Entity
{
    public class Pagecategory
    {
        public long IId { get; set; }
        public string? Name { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Updatedate { get; set; }
        public long Createby { get; set; }
        public long Updateby { get; set; }
        public int IsRemoved { get; set; }
    }
}