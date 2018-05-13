using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EXTTestController : ApiController
    {
        // GET: api/EXTTest
        public HttpResponseMessage Get()//List<CVParameter>
        {
            return HTMLInfo.CreateResponse("EXT", EXT.GetList());
        }

        // GET: api/EXTTest/5
        public HttpResponseMessage Get(string id)
        {
            return HTMLInfo.CreateResponse("EXT - " + id, EXT.GetParameter(id));
        }

        // POST: api/EXTTest
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EXTTest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EXTTest/5
        public void Delete(int id)
        {
        }
    }
}
