using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class NHCTestController : ApiController
    {
        // GET: api/NHC
        public HttpResponseMessage Get()
        {
            return HTMLInfo.CreateResponse("NHC", NHC_Proxy.GetList());
        }

        // GET: api/NHC/5
        public HttpResponseMessage Get(string id)
        {
            return HTMLInfo.CreateResponse("NHC - " + id, NHC_Proxy.GetParameter(id));
        }

        // POST: api/NHC
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/NHC/5
        public void Put(string id, [FromBody]float value)
        {
            NHC.SetParameter(id, value);
        }

        // DELETE: api/NHC/5
        public void Delete(string id)
        {
        }
    }
}
