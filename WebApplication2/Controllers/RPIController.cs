using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RPIController : ApiController
    {
        // GET: api/RPI
        public IEnumerable<ExportParameter> Get()
        {
            return RPI.GetList();
        }

        // GET: api/RPI/5
        public ExportParameter Get(string id)
        {
            return RPI.GetParameter(id);
        }


        // POST: api/RPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RPI/5
        public void Delete(int id)
        {
        }
    }
}
