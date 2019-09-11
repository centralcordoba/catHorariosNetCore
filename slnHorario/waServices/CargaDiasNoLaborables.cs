using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
	public class CargaDiasNoLaborables
	{


		public static bool UpdateCargaDiasNoLaborables(DiasNoLaborables cargadiasnolaborables)
		{
			if (waRepositorys.CargaDiasNoLaborablesRepository.UpdateCargaDiasNoLaborables(cargadiasnolaborables))
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		public static bool AltaCargaDiasNoLaborables(DiasNoLaborables cargadiasnolaborables)
		{
			if (waRepositorys.CargaDiasNoLaborablesRepository.AltaCargaDiasNoLaborables(cargadiasnolaborables))
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		public static List<DiasNoLaborables> GetAllCargaDiasNoLaborables()
		{
			return (waRepositorys.CargaDiasNoLaborablesRepository.GetAllCargaDiasNoLaborables());



		}	
			   	

	//public static DiasNoLaborables GetEmpleadoTurno(int legajo, DateTime dd)
	//{
	//	return (waRepositorys.CargaDiasNoLaborablesRepository.GetCargaDiasNoLaborables( dd));



	//}


		
	//	public static Turnos GetTurnoEmpleado(int idturno)
	//{
	//	return (waRepositorys.CargaDiasNoLaborablesRepository.GetTurnoEmpleado(idturno));



	//}

	public static RegistroEntrada GetEmpleadoSalida(int legajo, DateTime dd)
	{
		return (waRepositorys.EmpleadoRepository.GetEmpleadoSalida(legajo, dd));



	}
}
}


	


