using System;
using System.Collections.Generic;

namespace CAOrgManager.Models
{
    public partial class PrjOrgCodes
    {
        public string OrgCode { get; set; }
        public string OrgDesc { get; set; }
        public DateTime OrgModDate { get; set; }
        public string OrgCodeShort { get; set; }
        public string OrgPrjBasenum { get; set; }
        public bool? OrgEnabled { get; set; }
        public string OrgType { get; set; }
        public int OrgTypeNum { get; set; }
        public string OrgLastPrjCode { get; set; }
        public string PrjFolderFormat { get; set; }
        public int CitiesId { get; set; }
        public string LegacyOrgCode { get; set; }
        public string MultiDiscOrgCode { get; set; }
        public string ServiceLine { get; set; }
        public string Division { get; set; }
        public string CityAlias { get; set; }
        public int? ServerId { get; set; }
        public string CoCode { get; set; }

        public virtual AdmCities Cities { get; set; }
        public virtual OrgCaList OrgCaList { get; set; }
    }
}
