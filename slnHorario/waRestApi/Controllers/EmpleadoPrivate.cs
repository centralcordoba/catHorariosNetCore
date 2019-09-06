using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using waEntitys;
using waServices;

namespace waRestApi.Controllers
{
    public static class EmpleadoPrivate
    {
        public static RegistroEntrada BuscarRegistro()
        {
            int legajo=4;
            DateTime dd;
            RegistroEntrada registroentrada = new RegistroEntrada();
            registroentrada=waServices.EmpleadoServices.GetEmpleadoSalida(legajo,DateTime.Now);
            if (registroentrada != null)
            {
                int dia = registroentrada.dia;
                string he = registroentrada.horaen;
                int diafecha;
                diafecha = Convert.ToInt32(DateTime.Now.DayOfWeek.ToString());
                if (dia < diafecha )
                {
                    int horaregistro = Convert.ToInt32( DateTime.Now.ToString("HH:mm"));
                    if (registroentrada.observ == "T")
                    {
                        int horaentrada = Convert.ToInt32(he);
                    }

                }                
            }
            return registroentrada;

        }
        //int legajo;
        //DateTime dd;
        //waServices.EmpleadoServices.(legajo,dd);
    }
}
