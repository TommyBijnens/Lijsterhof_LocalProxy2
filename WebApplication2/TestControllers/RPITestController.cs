using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RPITestController : ApiController
    {
        // GET: api/RPITest
        public HttpResponseMessage Get()
        {
            return HTMLInfo.CreateResponse("RPI", RPI.GetList());
        }

        // GET: api/RPITest/5
        public HttpResponseMessage Get(string id)
        {
            return HTMLInfo.CreateResponse("RPI - " + id, RPI.GetParameter(id));
        }

        // POST: api/RPITest
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RPITest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RPITest/5
        public void Delete(int id)
        {
        }
    }
}
