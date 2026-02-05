using System;

namespace itcl.etraffic.domain.Entity
{

    public class InquiryvehiclecaseforucashResult
    {
        public int? Status { get; set; }
        public int Paymentstatus { get; set; }
        public int Isremoved { get; set; }
        public long Iid { get; set; }
        public decimal? Total { get; set; }
        public string? Vehicleno { get; set; }
        public string? Formno { get; set; }
        public string? Serialno { get; set; }
        public string? Comments { get; set; }
    }
}