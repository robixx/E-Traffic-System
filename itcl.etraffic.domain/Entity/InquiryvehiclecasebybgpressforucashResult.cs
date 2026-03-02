using System;

namespace itcl.etraffic.domain.Entity
{

    public class InquiryvehiclecasebybgpressforucashResult
    {
        public int? Status { get; set; }
        public int? Paymentstatus { get; set; }
        public int IsRemoved { get; set; }
        public long IId { get; set; }
        public decimal Total { get; set; }
        public string? VehicleNo { get; set; }
        public string? Formno { get; set; }
        public string? Serialno { get; set; }
        public string? Comments { get; set; }
    }
}