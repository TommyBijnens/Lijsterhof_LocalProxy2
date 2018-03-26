using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DBController : ApiController
    {
        // GET: api/DB
        public IEnumerable<ExportParameter> Get()
        {
            return DB.GetList();
        }

        // GET: api/DB/5
        public ExportParameter Get(string id)
        {
            return DB.GetParameter(id);
        }

        // POST: api/DB
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DB/5
        public void Put(string id, [FromBody]float value)
        {
            DB.SetParameter(id, value);
        }

        // DELETE: api/DB/5
        public void Delete(int id)
        {
        }


        
    }
   
}
