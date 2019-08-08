using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAOrgManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CAOrgManager.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    public class OrgPaController : Controller
    {
        OrgCaDataAccessLayer dl = new OrgCaDataAccessLayer();
        // GET: api/OrgPa
        [HttpGet("[action]")]
        public IEnumerable<OrgPaUser> FetchAll()
        {
            return dl.GetPAUsers().OrderBy( o => o.OrgCode);
        }

        [HttpPut("[action]")]
        public int Edit([FromBody]OrgPaUser orgca)
        {
            return dl.Update(orgca);
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return dl.DeleteOrgCa(id);
        }

        [HttpGet("[action]")]
        public IEnumerable<UserInfo> FetchAllEmployees()
        {
            return dl.FetchAll();
        }
    }
}
