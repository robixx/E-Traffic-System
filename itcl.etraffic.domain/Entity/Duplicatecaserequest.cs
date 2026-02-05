using System;


namespace itcl.etraffic.domain.Entity
{
    public class Duplicatecaserequest
    {
        public decimal Id { get; set; }
        public long Caseid { get; set; }
        public int Divisionid { get; set; }
        public long Userid { get; set; }
        public string? Loacation { get; set; }
        public DateTime? Creationdate { get; set; }
    }
}