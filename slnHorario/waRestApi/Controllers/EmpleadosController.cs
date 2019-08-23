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
    public class EmpleadosController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Empleados> Get()
        {
            try
            {
                List<Empleados> lstEmpleados = new List<Empleados>();
                return lstEmpleados = waServices.EmpleadoServices.GetAllEmpleado();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Empleados GetEmpleadoAutorizado(int legajo)
        {
            try
            {
                Empleados empleado = new Empleados();
                empleado = waServices.EmpleadoServices.GetEmpleadoAutorizado(legajo);
                if (empleado != null)
                {
                    if (empleado.Estado != "B")
                    {
                        CategoriaEmpleado categoriaempleado = new CategoriaEmpleado();
                        categoriaempleado = waServices.CategoriaEmpleadoService.GetCategoriaEmpleado(empleado.Categoria);
                        if (categoriaempleado != null)
                        {
                            decimal canthsxturno = categoriaempleado.Canthoraxturno;
                            if ( categoriaempleado.Canthsfinde != 0)
                            {
                                decimal canthsxturnofinde = categoriaempleado.Canthsfinde;
                            }
                        

                        }
                    }
                }
                return empleado = waServices.EmpleadoServices.GetEmpleadoAutorizado(legajo);
               
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
