using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("values/get/v1")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("values/get/v2")]
        public IEnumerable<string> Getv2()
        {
            return new string[] { "value3", "value4" };
        }
    }
}
