using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class NHCController : ApiController
    {
        // GET: api/NHC
        public IEnumerable<ExportParameter> Get()
        {
           return CV.GetList();
        }

        // GET: api/NHC/5
        public ExportParameter Get(string id)
        {
            return NHC_Proxy.GetParameter(id);
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
