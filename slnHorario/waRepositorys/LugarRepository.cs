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
        static string _db = "";

        public bool InsertLugar(Lugar empleado)
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
    }
}
