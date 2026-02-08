using System;


namespace itcl.etraffic.domain.Entity
{
    public class VehiclecasepaymentstatusgetbyidResult
    {
        public string? Formno { get; set; }
        public string? Serialno { get; set; }
        public string? Vehicleno { get; set; }
        public decimal Total { get; set; }
        public decimal Collectionamount { get; set; }
        public string? Paymentstatus { get; set; }
    }
}