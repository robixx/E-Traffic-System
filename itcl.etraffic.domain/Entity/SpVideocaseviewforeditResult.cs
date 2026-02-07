using System;

namespace itcl.etraffic.domain.Entity
{
    public class SpVideocaseviewforeditResult
    {
        public long Iid { get; set; }
        public string? Videocasesarokno { get; set; }
        public int Vehicleregistrationid { get; set; }
        public int Seriesid { get; set; }
        public string? Vehicleno { get; set; }
        public string? Vehiclenumber { get; set; }
        public string? Ownername { get; set; }
        public string? Owneraddress { get; set; }
        public string? Contactnumber { get; set; }
        public string? Fathername { get; set; }
        public string? Caseid { get; set; }
        public string? Division { get; set; }
        public DateTime? Eventtime { get; set; }
        public string? Eventlocation { get; set; }
        public string? Prosecution { get; set; }
        public DateTime? Hearingdate { get; set; }
        public string? Prosecutorbpid { get; set; }
    }
}