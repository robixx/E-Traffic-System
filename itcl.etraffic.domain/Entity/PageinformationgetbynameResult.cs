using System;


namespace itcl.etraffic.domain.Entity
{
    public class PageinformationgetbynameResult
    {
        public long IId { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Updatedate { get; set; }
        public long Createby { get; set; }
        public long Updateby { get; set; }
        public int IsRemoved { get; set; }
        public long PagecategoryId { get; set; }
    }
}