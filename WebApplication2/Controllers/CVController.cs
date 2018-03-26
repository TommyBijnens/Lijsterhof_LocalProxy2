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
    public class CVController : ApiController
    {
        // GET: api/CV
        public IEnumerable<ExportParameter> Get()//List<CVParameter>
        {
            return CV.GetList();
        }

        // GET: api/CV/5
        public ExportParameter Get(string id)
        {
            return CV.GetParameter(id);
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
