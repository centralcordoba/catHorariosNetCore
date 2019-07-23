using System;
using System.Collections.Generic;
using System.Text;
using waEntitys;

namespace waServices
{
	public class LoginService
	{
	
		public static bool Login(Login login)
		{
			if (waRepositorys.LoginRepository.Login(login))
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		public static List<Login> GetAllLogin()
		{
			return (waRepositorys.LoginRepository.GetAllLogin());



		}
	}
}
