using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
    public class CategoriaEmpleadoService
    {
        public static bool UpdateCategoriaEmpleado(CategoriaEmpleado empleado)
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
        public static bool AltaCategoriaEmpleado(CategoriaEmpleado empleado)
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
        public static List<CategoriaEmpleado> GetAllCategoriaEmpleado()
        {
            return (waRepositorys.CategoriaEmpleadoRepository.GetAllCategoriaEmpleado());
            


        }

        public static CategoriaEmpleado GetCategoriaEmpleado(int idcatemp)
        {
            return (waRepositorys.CategoriaEmpleadoRepository.GetCategoriaEmpleado(idcatemp));



        }

    }
}
