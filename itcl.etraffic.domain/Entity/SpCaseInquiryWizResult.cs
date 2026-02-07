using System;

namespace itcl.etraffic.domain.Entity
{
    public class SpCaseInquiryWizResult
    {
        public long Caseid { get; set; }
        public string? Vehiclenumber { get; set; }
        public string? Divisionname { get; set; }
        public string? Accusedpersion { get; set; }
        public string? Comments { get; set; }
        public string? Dateofoffence { get; set; }
        public string? Paymentdate { get; set; }
        public string? Casestatus { get; set; }
        public decimal Total { get; set; }
        public string? Prosecution { get; set; }
        public string? Seizeddocument { get; set; }
    }

}