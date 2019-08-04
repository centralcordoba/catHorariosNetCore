using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using waEntitys;

namespace waRepositorys
{
	public class LoginRepository
	{
		static string _db = "Data Source=ARGSQL03;Initial Catalog=HorariosPrueba;User ID=sa;Password=bfg2007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

		/// <summary>
		/// Creacion de código para ejecutar sp UpdateCategoriaEmpleado
		/// </summary>
		/// <param @clave ></param>
		/// <param @usuario ></param>
		/// <param @centro></param>
		/// <returns></returns>
		public static bool Login(Login login)
		{
			try
			{
				using (IDbConnection db = new SqlConnection(_db))
				{
					DynamicParameters param = new DynamicParameters();
					db.Open();
					param.Add("@clave", login.clave);
					param.Add("@usuario", login.usuario);
					param.Add("@centro", login.centro);
					db.Execute("", param, commandType: CommandType.StoredProcedure);
					db.Close();
				}
			}
			catch (Exception ex)
			{
				return false;
				throw;
			}
			return true;

		}
		
		public static List<Login> GetAllLogin()
		{
			///
			try
			{
				using (IDbConnection db = new SqlConnection(_db))
				{
					DynamicParameters param = new DynamicParameters();
					db.Open();

					return db.Query<Login>("", commandType: CommandType.StoredProcedure).AsList();
					db.Close();
				}
			}
			catch (Exception ex)
			{

				throw;
			}


		}

	}
}
