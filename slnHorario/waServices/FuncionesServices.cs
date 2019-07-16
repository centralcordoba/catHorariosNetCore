using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
	public class FuncionesServices
	{
		public static bool UpdateFunciones(Funciones funciones)
		{
			if (waRepositorys.FuncionesRepository.UpdateFunciones(funciones))
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		public static bool AltaFunciones(Funciones funciones)
		{
			if (waRepositorys.FuncionesRepository.AltaFunciones(funciones))
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		public static List<Funciones> GetAllFunciones()
		{
			return (waRepositorys.FuncionesRepository.GetAllFunciones());



		}
	}
}