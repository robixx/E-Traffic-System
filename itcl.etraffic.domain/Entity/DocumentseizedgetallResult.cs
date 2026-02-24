using System;


namespace itcl.etraffic.domain.Entity
{
    public class DocumentseizedgetallResult
    {
        public int IId { get; set; }
        public string? Shortname { get; set; }
        public string? Name { get; set; }
        public string? Banglashortname { get; set; }
        public string? Banglaname { get; set; }
        public int IsRemoved { get; set; }
    }
}