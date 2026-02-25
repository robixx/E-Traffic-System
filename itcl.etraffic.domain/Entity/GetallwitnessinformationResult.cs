using System;

namespace itcl.etraffic.domain.Entity
{
    public class GetallwitnessinformationResult
    {
        public string? BpId { get; set; }
        public string? Witname { get; set; }
        public string? Nameinbangla { get; set; }
        public string? Fathersname { get; set; }
        public string? Address { get; set; }
        public string? Contactnumber { get; set; }
        public string? Email { get; set; }
        public int Divisionid { get; set; }
        public string? Divisionname { get; set; }
        public int Zoneid { get; set; }
        public string? Zonename { get; set; }
        public int IsRemoved { get; set; }
        public string? Status { get; set; }
    }

}