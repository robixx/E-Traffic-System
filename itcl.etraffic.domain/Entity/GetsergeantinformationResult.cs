using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetsergeantinformationResult
    {
        public long IId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Cell { get; set; }
        public int ZoneId { get; set; }
        public string? Zonename { get; set; }
        public int? Divisionid { get; set; }
        public string? Divisionname { get; set; }
        public string? Status { get; set; }
        public long Designationid { get; set; }
        public string? Designationname { get; set; }
    }
}