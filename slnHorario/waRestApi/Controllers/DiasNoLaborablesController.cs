using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using waEntitys;

namespace waRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiasNoLaborablesController : ControllerBase
    {






        // GET: api/DiasNoLaborables
        [HttpGet]
		public string UpdatediasNoLaborables(DiasNoLaborables diasNoLaborables)
		{
			bool respuesta;
			try			
			{
				 respuesta = waServices.CargaDiasNoLaborables.UpdateCargaDiasNoLaborables(diasNoLaborables);
				
				

			}
			catch (Exception ex)
			{

				throw;
			}
			return "OK";
		}

			   		 	  	  	 
		


        // GET: api/DiasNoLaborables/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DiasNoLaborables
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/DiasNoLaborables/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
