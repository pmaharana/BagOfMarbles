using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BagOfMarbles.Models;

namespace BagOfMarbles.Controllers
{
    public class MarblesController : ApiController
    {
        // GET: api/Marbles
        public IHttpActionResult Get()
        {
            return Ok(new { Hello = "world" });
        }

        [HttpPost]
        public IHttpActionResult Add(Marbles marble)
        {
            marble.Id = new Random().Next(0, 100);
            return Ok(marble);
        }
       


        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Marbles/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Marbles
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Marbles/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Marbles/5
        //public void Delete(int id)
        //{
        //}
    }
}
