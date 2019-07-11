using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using waEntitys;

namespace waRepositorys
{
    public class CentrosRepository
    {
        static string _db = "Data Source=ARGSQL03;Initial Catalog=HorariosPrueba;User ID=sa;Password=bfg2007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /// <summary>
        /// Creacion de código para ejecutar sp UpdateCentros
        /// </summary>
        /// <param @Nombre es la descripción de la Categoría></param>
        /// <param @Codigo es la cantidad de horas de permanencia que debe tener el empleado en la Empresa asociado a la Categoría></param>
        
        public static bool UpdateCentros(Centros centro)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@Nombre", centro.Nombre);
                   
                    db.Execute("sp_UpdateCentros", param, commandType: CommandType.StoredProcedure);
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
        public static bool AltaCentros(Centros centro)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@Nombre", centro.Nombre);
                   
                    db.Execute("sp_AltaCentros", param, commandType: CommandType.StoredProcedure);
                    db.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }
        public static List<Centros> GetAllCentros()
        {
            ///lstCentros List<Centros> new= List<Centros>();
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();

                    return db.Query<Centros>("sp_UpdateCentros", commandType: CommandType.StoredProcedure).AsList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }
    }
}
