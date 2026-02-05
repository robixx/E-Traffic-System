using System;


namespace itcl.etraffic.domain.Entity
{
    public class Dl
    {
        public int FormId { get; set; }
        public string? Name { get; set; }
        public string? FatherName { get; set; }
        public string? HusbandName { get; set; }
        public string? PermAddressOne { get; set; }
        public string? DateOfBirth { get; set; }
        public string? BloodGroup { get; set; }
        public string? Gender { get; set; }
        public string? RenewIssueDate { get; set; }
        public string? RenewExpiryDate { get; set; }
        public string? LicType { get; set; }
        public string? LicClassHeavyP { get; set; }
        public string? LicClassMediumP { get; set; }
        public string? LicClassLightP { get; set; }
        public string? LicClassMcycleP { get; set; }
        public string? LicClassThreeP { get; set; }
        public string? LicClassPsvP { get; set; }
        public string? LicClassOtherP { get; set; }
        public string? OfficeReference { get; set; }
        public string? OfficeDate { get; set; }
        public string? NewLicenceNo { get; set; }
        public string? NewLicenceClass { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? Old { get; set; }
    }
}