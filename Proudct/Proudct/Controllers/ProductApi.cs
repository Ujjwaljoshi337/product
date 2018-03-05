using Proudct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proudct.Controllers
{
    public class ProductApi : ApiController
    {
        private IMSEntities db = new IMSEntities();
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            return db.Products.ToList();
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}