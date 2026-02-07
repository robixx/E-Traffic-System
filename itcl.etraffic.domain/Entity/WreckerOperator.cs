using System;


namespace itcl.etraffic.domain.Entity
{
    public class WreckerOperator
    {
        public long Iid { get; set; }
        public string? Shortcode { get; set; }
        public int? Designation { get; set; }
        public int Operatordivisionid { get; set; }
        public string? Operatorwreckerno { get; set; }
        public string? Mobileno { get; set; }
        public string? Address { get; set; }
        public int? Isremoved { get; set; }
        public long? Sergeantid { get; set; }
    }
}