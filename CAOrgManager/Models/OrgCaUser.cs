using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAOrgManager.Models
{
    public class OrgPaUser
    {
        public int Id { get; set; }
        public string OrgCode { get; set; }
        public Guid OrgPaUid { get; set; }
        public string Name { get; set; }
        public string PracticeArea { get; set; }
        public string Office { get; set; }
    }
}
