using System;

namespace itcl.etraffic.domain.Entity
{
    public class SpMonthlyreportV2Result
    {
        public string? Divisionname { get; set; }
        public int? Totalcase { get; set; }
        public decimal? Totalamount { get; set; }
        public int? Totalcasepaidbyucash { get; set; }
        public decimal? Totalfinecollectedbyucash { get; set; }
        public int? Totalcasepaidbyupay { get; set; }
        public decimal? Totalfinecollectedbyupay { get; set; }
        public decimal? Totalcollection { get; set; }
    }
}
