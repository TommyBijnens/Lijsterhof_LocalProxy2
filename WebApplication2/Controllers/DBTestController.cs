﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DBTestController : ApiController
    {

        // GET: api/DB
        public HttpResponseMessage Get()//List<CVParameter>
        {
            return HTMLInfo.CreateResponse("DB", DB.GetList());
        }

        // GET: api/DB/5
        public HttpResponseMessage Get(string id)
        {
            return HTMLInfo.CreateResponse("DB - " + id, DB.GetParameter(id));
        }



        // POST: api/DB
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DB/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DB/5
        public void Delete(int id)
        {
        }



    }


   
}