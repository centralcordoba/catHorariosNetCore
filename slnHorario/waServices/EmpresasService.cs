using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
	public class EmpresasService
	{
		public static bool UpdateEmpresas(Empresas empresa)
		{
			if (waRepositorys.EmpresaRepository.UpdateEmpresa(empresa))
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		public static bool AltaEmpresas(Empresas empresa)
		{
			if (waRepositorys.EmpresaRepository.AltaEmpresa(empresa))
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		public static List<Empresas> GetAllempresa()
		{
			return (waRepositorys.EmpresaRepository.GetAllempresa());



		}
	}
}


		


		






