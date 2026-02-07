using System;


namespace itcl.etraffic.domain.Entity
{
    public class SysErrorlogSp
    {
        public decimal Id { get; set; }
        public DateTime? Occurtime { get; set; }
        public string? Errorcode { get; set; }
        public string? Spname { get; set; }
        public string? Ddescription { get; set; }
    }
}