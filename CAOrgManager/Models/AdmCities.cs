using System;
using System.Collections.Generic;

namespace CAOrgManager.Models
{
    public partial class AdmCities
    {
        public AdmCities()
        {
            PrjOrgCodes = new HashSet<PrjOrgCodes>();
            UserInfo = new HashSet<UserInfo>();
        }

        public string CityCode { get; set; }
        public int CitiesId { get; set; }
        public string FullName { get; set; }
        public string Network { get; set; }
        public string NetMask { get; set; }
        public string Phone { get; set; }
        public string SpeedDial { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public short? TimeZoneOffset { get; set; }
        public float? UptBegin { get; set; }
        public float? UptEnd { get; set; }
        public int? DcomServer { get; set; }
        public int? WebServer { get; set; }
        public Guid? OcmContact1 { get; set; }
        public Guid? OcmContact2 { get; set; }
        public string Dialin1 { get; set; }
        public string Dialin2 { get; set; }
        public string SpDialPrefix { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? CompanyId { get; set; }

        public virtual UserInfo OcmContact1Navigation { get; set; }
        public virtual UserInfo OcmContact2Navigation { get; set; }
        public virtual ICollection<PrjOrgCodes> PrjOrgCodes { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
