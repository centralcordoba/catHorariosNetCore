using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using waEntitys;

namespace waRepositorys
{
	public class FuncionesRepository
	{
		static string _db = "Data Source=ARGSQL03;Initial Catalog=HorariosPrueba;User ID=sa;Password=bfg2007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

		/// <summary>
		/// Creacion de código para ejecutar sp UpdateFunciones
		/// </summary>
		/// <param @Descripcion es la descripción de la Funcion></param>
		/// <param @CodFuncion es la cantidad de horas de permanencia que debe tener el empleado en la Empresa asociado a la Categoría></param>
		
		/// <returns></returns>
		public static bool UpdateFunciones(Funciones funciones)
		{
			try
			{
				using (IDbConnection db = new SqlConnection(_db))
				{
					DynamicParameters param = new DynamicParameters();
					db.Open();
					param.Add("@Descripcion", funciones.Descripcion);
					
					db.Execute("sp_UpdateFunciones", param, commandType: CommandType.StoredProcedure);
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
		public static bool AltaFunciones(Funciones funciones)
		{
			try
			{
				using (IDbConnection db = new SqlConnection(_db))
				{
					DynamicParameters param = new DynamicParameters();
					db.Open();
					param.Add("@Descripcion", funciones.Descripcion);
					db.Execute("sp_AltaFunciones", param, commandType: CommandType.StoredProcedure);
					db.Close();
				}
			}
			catch (Exception ex)
			{

				throw;
			}
			return true;
		}
		public static List<Funciones> GetAllFunciones()
		{
			///lstCategoriaEmpleado List<CategoriaEmpleado> new= List<CategoriaEmpleado>();
			try
			{
				using (IDbConnection db = new SqlConnection(_db))
				{
					DynamicParameters param = new DynamicParameters();
					db.Open();

					return db.Query<Funciones>("sp_AltaFunciones", commandType: CommandType.StoredProcedure).AsList();
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
