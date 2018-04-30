﻿using APS.Models.Repositories;
using APS.Models.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APS.Controllers.API
{
    public class ProductGroupController : ApiController
    {
        ProductRepository productRepo = new ProductRepository();

        // GET: api/ProductGroup
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProductGroup/5
        public IEnumerable<ProductGroup> Get(int id)
        {
            var result = productRepo.GetAllProductGroup(id);

            return result;
        }

        // POST: api/ProductGroup
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductGroup/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductGroup/5
        public void Delete(int id)
        {
        }
    }
}
