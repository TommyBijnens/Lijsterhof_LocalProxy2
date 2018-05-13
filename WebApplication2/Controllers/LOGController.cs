using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LOGController : ApiController
    {
        // GET: api/LOG
        public IEnumerable<ExportParameter> Get()
        {
            return DB.GetLogs();
        }

        // GET: api/LOG/5
        public LOGParameter Get(string id)
        {
            return DB.GetLog(id);
        }

        // POST: api/LOG
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LOG/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LOG/5
        public void Delete(int id)
        {
        }
    }
}
