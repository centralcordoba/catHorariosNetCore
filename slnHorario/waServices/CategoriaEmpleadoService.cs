using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
    public class CategoriaEmpleadoService
    {
        public bool UpdateCategoriaEmpleado(CategoriaEmpleado empleado)
        {
            if (waRepositorys.CategoriaEmpleadoRepository.UpdateCategoriaEmpleado(empleado))
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
        public bool AltaCategoriaEmpleado(CategoriaEmpleado empleado)
        {
            if (waRepositorys.CategoriaEmpleadoRepository.AltaCategoriaEmpleado(empleado))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
