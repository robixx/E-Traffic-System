using System;

namespace itcl.etraffic.domain.Entity
{
    public class ProcCasetotalreportResult
    {
        public string? Workingdate { get; set; }
        public int Totalpending { get; set; }
        public int Totalresolved { get; set; }
        public int Totalheld { get; set; }
        public int Totalnonfir { get; set; }
    }
}