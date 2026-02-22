using System;


namespace itcl.etraffic.domain.Entity
{
    public class ApiEndpointPermission
    {
        public long UserId { get; set; }
        public int EndpointId { get; set; }
        public int IsActive { get; set; }
    }

}
