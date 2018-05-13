using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EXTController : ApiController
    {
        // GET: api/EXT
        public IEnumerable<ExportParameter> Get()//List<CVParameter>
        {
            return EXT.GetList();
        }

        // GET: api/EXT/5
        public ExportParameter Get(string id)
        {
            return EXT.GetParameter(id);
        }

        // POST: api/EXT
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EXT/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EXT/5
        public void Delete(int id)
        {
        }
    }
}
