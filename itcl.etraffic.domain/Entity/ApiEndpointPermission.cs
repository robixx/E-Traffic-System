using System;


namespace itcl.etraffic.domain.Entity
{
    public class ApiEndpointPermission
    {
        public long Userid { get; set; }
        public int Endpointid { get; set; }
        public int Isactive { get; set; }
    }

}
