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
        public static List<Marbles> marbleBox = new List<Marbles>();
        

        // GET: api/Marbles
        public IHttpActionResult Get()
        {
            return Ok(marbleBox);
        }

        [HttpPut]
        public IHttpActionResult Random()
        {
            var randomNum = new Random().Next(0, marbleBox.ToArray().Length - 1);
            var randomizedMarble = marbleBox[randomNum];
            
            return Ok(randomizedMarble);
        }

        [HttpPost]
        public IHttpActionResult Add(Marbles marble)
        {
            
            marble.Id = new Random().Next(0, 100);
            marbleBox.Add(marble);
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
