using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace rrr_catalogo.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ByPassController : ApiController
    {
        // GET: api/ByPass
        public object Get()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject("[{ACOUNT: 1, NAME_STAGE: 'Hydrogen', COD_STAGE: 1.0079, DESC_STAGE: 'H'},{ACOUNT: 2, NAME_STAGE: 'Helium', COD_STAGE: 4.0026, DESC_STAGE: 'He'}]");
        }

        // GET: api/ByPass/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ByPass
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ByPass/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ByPass/5
        public void Delete(int id)
        {
        }
    }
}
