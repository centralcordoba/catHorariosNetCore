using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
    public class LugarService
    { 
        public static bool UpdateLugar(Lugar lugar)
        {
            if (waRepositorys.LugarRepository.UpdateLugar(lugar))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static bool InsertLugar(Lugar lugar)
        {
            if (waRepositorys.LugarRepository.InsertLugar(lugar))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static List<Lugar> GetAllLugar()
        {
            return (waRepositorys.LugarRepository.GetAllLugar());



        }
    }
}
