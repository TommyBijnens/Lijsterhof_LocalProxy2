using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Controllers;
using WebApplication2.Models;

namespace WebApplication2.TestControllers
{
    public class LOGTestController : ApiController
    {
        // GET: api/LOGTest
        public HttpResponseMessage Get()//List<CVParameter>
        {
            return HTMLInfo.CreateResponse("DB", DB.GetLogs());
        }

        // GET: api/LOGTest/5
        public HttpResponseMessage Get(string id)
        {
            // return HTMLInfo.CreateResponse("DB - " + id, DB.GetLog(id));
            return null;
        }

        // POST: api/LOGTest
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LOGTest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LOGTest/5
        public void Delete(int id)
        {
        }
    }
}
