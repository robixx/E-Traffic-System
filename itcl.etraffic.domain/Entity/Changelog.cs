using System;


namespace itcl.etraffic.domain.Entity
{

    public class Changelog
    {
        public DateTime Logdate { get; set; }
        public long CaseId { get; set; }
        public string? Changetype { get; set; }
        public string? Remarks { get; set; }
    }

}