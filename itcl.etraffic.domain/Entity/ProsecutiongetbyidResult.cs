using System;


namespace itcl.etraffic.domain.Entity
{
    public class ProsecutiongetbyidResult
    {
        public int Iid { get; set; }
        public string? Code { get; set; }
        public string? Banglacode { get; set; }
        public string? Name { get; set; }
        public decimal Amount { get; set; }
        public string? Banglaamount { get; set; }
        public decimal Specialamount { get; set; }
        public string? Specialbanglaamount { get; set; }
        public int Isremoved { get; set; }
    }
}
