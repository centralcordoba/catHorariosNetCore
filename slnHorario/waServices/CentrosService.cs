using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
    public class CentrosService
    {

        public class CentroService
        {
            public static bool UpdateCentros(Centros centro)
            {
                if (waRepositorys.CentrosRepository.UpdateCentros(centro))
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            public static bool AltaCentros(Centros centro)
            {
                if (waRepositorys.CentrosRepository.AltaCentros(centro))
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            public static List<Centros> GetAllCategoriaEmpleado()
            {
                return (waRepositorys.CentrosRepository.GetAllCentros());



            }
        }

    }
}