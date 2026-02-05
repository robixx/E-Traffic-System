using System;


namespace itcl.etraffic.domain.Entity
{
    public class GetserieswisesummaryResult
    {
        public string? Series { get; set; }
        public string? Description { get; set; }
        public string? Division { get; set; }
        public string? Prosecution { get; set; }
        public int Total { get; set; }
    }
}