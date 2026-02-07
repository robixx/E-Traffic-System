using System;

namespace itcl.etraffic.domain.Entity
{
    public class SecModules
    {
        public int Moduleid { get; set; }
        public int? Applicationid { get; set; }
        public int? Moduletypeid { get; set; }
        public string? Modulename { get; set; }
        public int? Parentmoduleid { get; set; }
        public string? Moduledisplayname { get; set; }
        public string? Moduleroute { get; set; }
        public bool? Showinpermissiontree { get; set; }
        public bool Showinmenutree { get; set; }
        public string? Moduleimage { get; set; }
        public string? Moduleicon { get; set; }
        public int? Displayorder { get; set; }
        public int? Insertby { get; set; }
        public DateTime? Insertdate { get; set; }
        public bool Status { get; set; }
    }
}