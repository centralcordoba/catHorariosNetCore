using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
	public class CargaDiasNoLaborables
	{


		public static bool UpdateCargaDiasNoLaborables(CargaDiasNoLaborables cargadiasnolaborables)
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
		public static bool AltaCargaDiasNoLaborables(CargaDiasNoLaborables cargadiasnolaborables)
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
		public static List<CargaDiasNoLaborables> GetAllCargaDiasNoLaborables()
		{
			return (waRepositorys.CargaDiasNoLaborablesRepository.GetAllCargadiasNoLaborables());



		}

		public static CargaDiasNoLaborables GetCargaDiasNoLaborables(int idcatemp)
		{
			return (waRepositorys.CargaDiasNoLaborablesRepository.GetCargaDiasNoLaborables(idcatemp));



		}

	}
}

