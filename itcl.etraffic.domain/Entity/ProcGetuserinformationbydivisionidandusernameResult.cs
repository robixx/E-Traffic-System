using System;


namespace itcl.etraffic.domain.Entity
{
    public class ProcGetuserinformationbydivisionidandusernameResult
    {
        public long IId { get; set; }
        public string? Name { get; set; }
        public string? Loginname { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string? Cell { get; set; }
        public string? Email { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Updatedate { get; set; }
        public long Createby { get; set; }
        public long Updateby { get; set; }
        public int IsRemoved { get; set; }
        public int Divisionid { get; set; }
        public string? Externaluser { get; set; }
    }
}