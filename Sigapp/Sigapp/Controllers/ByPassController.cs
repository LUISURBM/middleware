using Microsoft.AspNetCore.Mvc;
using EnableCorsAttribute = System.Web.Http.Cors.EnableCorsAttribute;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sigapp.Controllers
{
    [Route("api/ByPassController")]
    [EnableCors(origins: "https://localhost:4200", headers: "*", methods: "*")]
    public class ByPassController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public object Get()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject("[{ACOUNT: 1, NAME_STAGE: 'Hydrogen-i7', COD_STAGE: 1.0079, DESC_STAGE: 'H'},{ACOUNT: 2, NAME_STAGE: 'Helium', COD_STAGE: 4.0026, DESC_STAGE: 'He'}]");
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
