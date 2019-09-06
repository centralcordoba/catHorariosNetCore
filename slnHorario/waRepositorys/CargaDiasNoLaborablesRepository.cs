using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using waEntitys;
using System.Linq;

namespace waRepositorys
{
	public class CargaDiasNoLaborablesRepository

	{
		static string _db = "Data Source=ARGSQL03;Initial Catalog=HorariosPrueba;Integrated Security=True";

		public static bool UpdateCargaDiasNoLaborables()
		{
			throw new NotImplementedException();
		}

		public static bool AltaCargaDiasNoLaborables()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creacion de código para ejecutar sp UpdateCategoriaEmpleado
		/// </summary>
		/// <param @fecha ></param>
		/// <param @descrip></param>

		/// <returns></returns>
		public static bool UpdateCargaDiasNoLaborables(DiasNoLaborables cargadiasnolaborables)
		{
			try
			{
				using (IDbConnection db = new SqlConnection(_db))
				{
					DynamicParameters param = new DynamicParameters();
					db.Open();
					param.Add("@fecha", cargadiasnolaborables.fecha);
					param.Add("@descrip", cargadiasnolaborables.descrip);
				
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
		public static bool AltaCargaDiasNoLaborables(DiasNoLaborables cargadiasnolaborables)
		{
			try
			{
				using (IDbConnection db = new SqlConnection(_db))
				{
					DynamicParameters param = new DynamicParameters();
					db.Open();
					param.Add("@fecha", cargadiasnolaborables.fecha);
					param.Add("@descrip", cargadiasnolaborables.descrip);
					
					db.Execute("", param, commandType: CommandType.StoredProcedure);
					db.Close();
				}
			}
			catch (Exception ex)
			{

				throw;
			}
			return true;
		}
		public static List<DiasNoLaborables> GetAllCargaDiasNoLaborables()
		{
			///lstCargaDiasNoLaborables List<CargaDiasNoLaborables> new= List<CCargaDiasNoLaborables>();
			try
			{
				using (IDbConnection db = new SqlConnection(_db))
				{
					DynamicParameters param = new DynamicParameters();
					db.Open();

					return db.Query<DiasNoLaborables>("", commandType: CommandType.StoredProcedure).AsList();
					db.Close();
				}
			}
			catch (Exception ex)
			{

				throw;
			}


		}
		public static DiasNoLaborables GetCargaDiasNoLaborables(int idcatemp)
		{
			///lstEmpleados List<Empleados> new= List<Empleados>();
			try
			{
				using (IDbConnection db = new SqlConnection(_db))
				{

					DynamicParameters param = new DynamicParameters();
					db.Open();
					param.Add("@idcatemp", idcatemp);

					return db.Query<DiasNoLaborables>("", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
