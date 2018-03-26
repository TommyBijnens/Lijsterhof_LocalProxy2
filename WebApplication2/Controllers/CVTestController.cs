using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CVTestController : ApiController
    {
        // GET: api/CV
        public HttpResponseMessage Get()//List<CVParameter>
        {
            return HTMLInfo.CreateResponse("CV", CV.GetList());
        }

        // GET: api/CV/5
        public HttpResponseMessage Get(string id)
        {
            return HTMLInfo.CreateResponse("CV - "+id, CV.GetParameter(id));
        }

        // POST: api/CV
        public void Post([FromBody]ExportParameter value)
        {
            //Not used for now.
        }

        // PUT: api/CV/5
        public void Put(string id, [FromBody]float value)
        {
            CV.SetParameter(id, value);
        }

        // DELETE: api/CV/5
        public void Delete(int id)
        {
        }
    }
}
