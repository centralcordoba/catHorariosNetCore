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
        string _db="";
        /// <summary>
        /// Creción de Código para ejecutar el procedimiento almacenado spUpdateSectores
        /// </summary>
        /// <param @codigo, es el código del sector></param>
        /// <param @nombre, es el nombre del sector></param>
        /// <param @responsable, es el reponsable del sector></param>
        /// <returns></returns>
        public bool UpdateSector(Sectores sectores)
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
    }
}
