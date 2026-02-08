using System;
namespace itcl.etraffic.domain.Entity
{
    public class Videocase
    {
        public long Iid { get; set; }
        public string? Videocasesarokno { get; set; }
        public int Vehicleregistrationid { get; set; }
        public int Seriesid { get; set; }
        public string? Vehicleno { get; set; }
        public string? Ownername { get; set; }
        public string? Fathername { get; set; }
        public string? Owneraddress { get; set; }
        public string? Contactnumber { get; set; }
        public string? Vehiclenumber { get; set; }
        public DateTime? Eventtime { get; set; }
        public string? Eventlocation { get; set; }
        public string? Prosecution { get; set; }
        public DateTime? Hearingdate { get; set; }
        public int Divisionid { get; set; }
        public string? Prosecutorbpid { get; set; }
        public string? Prosecutionincharge { get; set; }
        public string? Inchargebpnumber { get; set; }
        public string? Inchargephonenumber { get; set; }
        public string? Inchargefaxnumber { get; set; }
        public string? Inchargeemail { get; set; }
        public long? Caseid { get; set; }
        public long Createdby { get; set; }
        public DateTime Createddate { get; set; }
        public long? Updateby { get; set; }
        public DateTime? Updatedate { get; set; }
        public int Status { get; set; }
    }
}