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


		}

	}


