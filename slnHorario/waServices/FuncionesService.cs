using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
    public class FuncionesService
    {
        public static bool UpdateFunciones(Funciones funcion)
        {
            if (waRepositorys.FuncionesRepository.UpdateFunciones(funcion))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static bool AltaFunciones(Funciones funcion)
        {
            if (waRepositorys.FuncionesRepository.AltaFuncion(funcion))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static List<Funciones> GetAllfuncion()
        {
            return (waRepositorys.FuncionesRepository.GetAllfuncion());



        }
    }

}
