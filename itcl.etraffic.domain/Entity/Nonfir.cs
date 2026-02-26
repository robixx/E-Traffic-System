using System;

namespace itcl.etraffic.domain.Entity
{
    public class Nonfir
    {
        public long Id { get; set; }
        public long CaseId { get; set; }
        public long? Nonfirno { get; set; }
        public string? Nonfirtype { get; set; }
        public int DivisionId { get; set; }
        public DateTime? Createdate { get; set; }
        public long? Createdby { get; set; }
    }
}