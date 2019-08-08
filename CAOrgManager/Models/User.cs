using System;
using System.Collections.Generic;

namespace CAOrgManager.Models
{
    public partial class User
    {
        public Guid Uid { get; set; }
        public string UserName { get; set; }
        public string UlgName { get; set; }
        public string UsrFname { get; set; }
        public string UsrLname { get; set; }
        public bool? UsrEnabled { get; set; }
        public string UsrEmail { get; set; }
        public string UsrPhone { get; set; }
        public string UsrCell { get; set; }
        public string UsrFax { get; set; }
        public int? UsrLocation { get; set; }
        public string UsrTimeIn { get; set; }
        public string UsrTimeOut { get; set; }
        public string UsrDesc { get; set; }
        public bool? UsrStatus { get; set; }
        public string UsrReturn { get; set; }
        public string UsrSpecialty { get; set; }
        public string UsrInterest { get; set; }
        public bool? UsrPic { get; set; }
        public DateTime? UsrStartDate { get; set; }
        public int? UsrCompanyId { get; set; }
        public bool? UsrContract { get; set; }
        public DateTime? UsrCdate { get; set; }
        public DateTime? UsrModdate { get; set; }
        public Guid? UsrModusr { get; set; }
        public Guid? UsrCusr { get; set; }
        public string BstEmpCode { get; set; }
        public string UsrMname { get; set; }
        public string UsrFuncTitle { get; set; }
        public string UsrCorpTitle { get; set; }
        public bool? UsrMoorenetIsVisible { get; set; }
        public string UsrSigName { get; set; }
        public string UsrSigTitle { get; set; }
        public string UsrSigSuffix { get; set; }
        public string UsrSigFax { get; set; }
        public string UsrSigPhone { get; set; }
        public string SpDialSuffix { get; set; }
        public bool Telecommuter { get; set; }
        public string UsrLongDistCode { get; set; }
        public bool? UsrAutoCheckIn { get; set; }
        public string UsrOrg { get; set; }
    }
}
