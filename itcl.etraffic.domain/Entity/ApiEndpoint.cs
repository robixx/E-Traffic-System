using System;

namespace itcl.etraffic.domain.Entity
{
    public class ApiEndpoint
    {
        public int Iid { get; set; }
        public string? Httppath { get; set; }
        public string? Httpmethod { get; set; }
        public int Isactive { get; set; }
    }


}
