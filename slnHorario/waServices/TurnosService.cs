using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
    public class TurnosService
    {

		public static bool UpdateTurnos(Turnos turnos)
		{
			if (waRepositorys.TurnosRepository.UpdateTurnos(turnos))
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		public static bool AltaTurnos(Turnos turnos)
		{
			if (waRepositorys.TurnosRepository.Altaturnos(turnos))
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		public static List<Turnos> GetAllTurnos()
		{
			return (waRepositorys.TurnosRepository.GetAllturnos());



		}
	}
}

