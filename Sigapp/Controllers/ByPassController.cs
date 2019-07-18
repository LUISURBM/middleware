using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sigapp.Controllers
{
    [Route("api/ByPassController")]
    public class ByPassController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public object Get()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject("[{ACOUNT: 1, NAME_STAGE: 'Hydrogen', COD_STAGE: 1.0079, DESC_STAGE: 'H'},{ACOUNT: 2, NAME_STAGE: 'Helium', COD_STAGE: 4.0026, DESC_STAGE: 'He'}]");
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
