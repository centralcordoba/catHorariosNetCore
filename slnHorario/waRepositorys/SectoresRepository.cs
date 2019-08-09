using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using waEntitys;

namespace waRepositorys
{
    public class SectoresRepository
    {
        static string _db= "Data Source=DESKTOP-S1UKRBH\\SQLEXPRESS;Initial Catalog=HorariosPrueba;Integrated Security=True";
        /// <summary>
        /// Creción de Código para ejecutar el procedimiento almacenado spUpdateSectores
        /// </summary>
        /// <param @codigo, es el código del sector></param>
        /// <param @nombre, es el nombre del sector></param>
        /// <param @responsable, es el reponsable del sector></param>
        /// <returns></returns>
        public static bool UpdateSector(Sectores sectores)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@Nombre", sectores.nombre);
                    param.Add("@Responsable", sectores.responsable);
                    param.Add("@Codigo", sectores.codigo);                    
                    //db.Execute("sp_UpdateSectores", param, commandType = CommandType.StoredProcedure);
                    db.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }
        public static bool AltaSector(Sectores sectores)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@Nombre", sectores.nombre);
                    param.Add("@Responsable", sectores.responsable);
                    ///db.Execute("sp_Altasectores", param, commandType = CommandType.StoredProcedure);
                    db.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }
        public static List<Sectores> GetAllSectores()
        {
            ///lstCategoriaEmpleado List<CategoriaEmpleado> new= List<CategoriaEmpleado>();
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();

                    return db.Query<Sectores>("sp_cnsectores", commandType: CommandType.StoredProcedure).AsList();
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
