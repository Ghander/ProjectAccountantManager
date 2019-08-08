using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAOrgManager.Models
{
    public class OrgCaDataAccessLayer
    {
        OrgPaContext db = new OrgPaContext();
        public IEnumerable<UserInfo> FetchAll()
        {
            try
            {
                return db.UserInfo.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int AddOrgCA(OrgCaList orgca)
        {
            try
            {
                db.OrgCaList.Add(orgca);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public OrgCaList FetchOrgCa(int id)
        {
            try
            {
                var orgca = db.OrgCaList.Find(id);
                return orgca;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int DeleteOrgCa(int id)
        {
            try
            {
                var orgca = db.OrgCaList.Find(id);
                db.OrgCaList.Remove(orgca);
                return db.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<OrgPaUser> GetPAUsers()
        {
            try
            {
                List<OrgPaUser> users = new List<OrgPaUser>();
                users = (from oc in db.OrgCaList
                         join usr in db.UserInfo on oc.CaUid equals usr.Uid
                         join poc in db.PrjOrgCodes on oc.OrgCode equals poc.OrgCode
                         join ac in db.AdmCities on poc.CitiesId equals ac.CitiesId
                         select new OrgPaUser {
                             OrgPaUid = usr.Uid,
                             Id = oc.Id,
                             Name = $"{usr.UsrFname} {usr.UsrLname}",
                             OrgCode = oc.OrgCode,
                             PracticeArea = poc.ServiceLine,
                             Office = ac.City
                         }).ToList();

                return users;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int Update(OrgPaUser ocuser)
        {
            try
            {
                var orgca = db.OrgCaList.FirstOrDefault(u => u.OrgCode == ocuser.OrgCode);

                db.OrgCaList.Attach(orgca);
                orgca.CaUid = ocuser.OrgPaUid;

                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
