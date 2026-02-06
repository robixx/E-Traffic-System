using System;


namespace itcl.etraffic.domain.Entity
{
    public class ProcGetcaseallinformationV1Result
    {
        public long Iid { get; set; }
        public string? Serialno { get; set; }
        public string? Vehicleregistrationno { get; set; }
        public string? Accusedperson { get; set; }
        public string? Owner { get; set; }
        public string? Owneraddress { get; set; }
        public DateTime? Dateofoffence { get; set; }
        public DateTime? Dateofhearing { get; set; }
        public long? Sergeantid { get; set; }
        public string? Fathername { get; set; }
        public string? Witness { get; set; }
        public string? Casestaus { get; set; }
        public DateTime? Donedate { get; set; }
        public DateTime? Helddate { get; set; }
        public int? Nonfirstatus { get; set; }
        public DateTime? Nonfirdate { get; set; }
        public DateTime? Courtwarrantdate { get; set; }
        public DateTime? Caseresolvedate { get; set; }
        public int Paymentstatus { get; set; }
        public string? Paymentmedium { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? Discountdate { get; set; }
        public decimal Total { get; set; }
        public decimal Collectionamount { get; set; }
        public string? Comments { get; set; }
        public DateTime Updatedate { get; set; }
        public string? Nonfirno { get; set; }
        public string? Divisionname { get; set; }
        public string? Acussedpersonphoneno { get; set; }
        public string? Location { get; set; }
        public string? Sergeantname { get; set; }
        public string? Sergeantphone { get; set; }
        public string? Sergeantbpid { get; set; }
        public string? Prosecutionlist { get; set; }
        public string? Documentsizedlist { get; set; }
    }
}