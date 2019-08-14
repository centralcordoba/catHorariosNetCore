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
    public class FuncionesController : ControllerBase
    {
        [HttpGet]

        public List<Funciones> Get()
        {
            try
            {
                List<Funciones> lstFunciones = new List<Funciones>();
                return lstFunciones = waServices.FuncionesService.GetAllfuncion();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}