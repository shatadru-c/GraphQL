using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrameworkConsoleApp
{

    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get() 
        { 
            return new string[] { "value1", "value2" }; 
        }

        // GET api/values/5 
        [HttpGet("{id}")]
        public string Get(int id) 
        { 
            return "value"; 
        } 

        // POST api/values 
        public void Post([FromBody]string value) 
        { 
        } 

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value) 
        { 
        } 

        // DELETE api/values/5 
        public void Delete(int id) 
        { 
        } 
    }
}
