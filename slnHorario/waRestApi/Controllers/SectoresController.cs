using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using waEntitys;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace waRestApi.Controllers
{
    [Route("api/[controller]")]
    public class SectoresController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Sectores> Get()
        {
            try
            {
                List<Sectores> lstSectores = new List<Sectores>();
                 lstSectores = waServices.SectoresService.GetAllSectores();
                return lstSectores;
            }
            catch (Exception ex)
            {

                throw;
            }
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
