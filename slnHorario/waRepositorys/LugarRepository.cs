using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using waEntitys;

namespace waRepositorys
{
    public class LugarRepository
    {
        static string _db = "Data Source=ARGSQL03;Initial Catalog=HorariosPrueba;Integrated Security=True";

        public static bool InsertLugar(Lugar empleado)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@Descripcion", empleado.Descripcion);
                    db.Execute("sp_AltaLugar", param, commandType: CommandType.StoredProcedure);
                    db.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }

        public static List<Lugar> GetAllLugar()
        {
            ///lstLugar List<Lugar> new= List<Lugar>();
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();

                    return db.Query<Lugar>("sp_cnlugares", commandType: CommandType.StoredProcedure).AsList();
                    db.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public static bool UpdateLugar(Lugar lugar)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@Descripcion", lugar.Descripcion);
                    param.Add("@CodLugar", lugar.CodLugar);
                    db.Execute("sp_UpdateLugar", param, commandType: CommandType.StoredProcedure);
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
    }
}
