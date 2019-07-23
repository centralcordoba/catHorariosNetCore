using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
    public class EmpleadoServices
    {
        public static bool UpdateEmpleado(Empleados empleado)
        {
            if (waRepositorys.EmpleadoRepository.UpdateEmpleado(empleado))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static bool AltaEmpleado(Empleados empleado)
        {
            if (waRepositorys.EmpleadoRepository.AltaEmpleado(empleado))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static List<Empleados> GetAllEmpleado(int Legajo)
        {
            return (waRepositorys.EmpleadoRepository.GetAllEmpleado(Legajo));



        }
    }
}

