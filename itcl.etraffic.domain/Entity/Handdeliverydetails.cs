using System;


namespace itcl.etraffic.domain.Entity
{
    public class Handdeliverydetails
    {
        public long Id { get; set; }
        public string? Caseid { get; set; }
        public string? Deliverystatus { get; set; }
        public DateTime? Deliverydate { get; set; }
        public string? Deliveryby { get; set; }
        public int? Isremoved { get; set; }
    }
}