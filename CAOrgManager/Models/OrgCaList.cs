using System;
using System.Collections.Generic;

namespace CAOrgManager.Models
{
    public partial class OrgCaList
    {
        public int Id { get; set; }
        public string OrgCode { get; set; }
        public Guid? CaUid { get; set; }
        public Guid? CaUid22 { get; set; }
        public string PiSheet { get; set; }

        public virtual PrjOrgCodes OrgCodeNavigation { get; set; }
    }
}
