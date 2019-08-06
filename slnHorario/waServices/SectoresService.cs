using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
    public class SectoresService
    {
        


        public static bool UpdateSector(Sectores sectores)
        {
            if (waRepositorys.SectoresRepository.UpdateSector(sectores))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AltaSector(Sectores sectores)
        {
            if (waRepositorys.SectoresRepository.AltaSector(sectores))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static List<Sectores> GetAllSectores()
        {
            return (waRepositorys.SectoresRepository.GetAllSectores());



        }

    }
}
