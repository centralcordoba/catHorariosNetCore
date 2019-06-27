using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using waEntitys;

namespace waRepositorys
{
    public class CategoriaEmpleadoRepository
    {
        static string _db = "";

        /// <summary>
        /// Creacion de código para ejecutar sp UpdateCategoriaEmpleado
        /// </summary>
        /// <param @Descripcion es la descripción de la Categoría></param>
        /// <param @CantHsxTurtno es la cantidad de horas de permanencia que debe tener el empleado en la Empresa asociado a la Categoría></param>
        /// <param @CantHsFinde es la cantidad de horas de permanencia el fin de semana que debe tener el empleado en la Empresa asociado a la Categoría></param>
        /// <returns></returns>
        public static bool UpdateCategoriaEmpleado(CategoriaEmpleado empleado)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@Descripcion", empleado.Descripcion);
                    param.Add("@CantHsxTurtno", empleado.Canthoraxturno);
                    param.Add("@CantHsFinde", empleado.Canthsfinde);
                    db.Execute("sp_UpdateCategoriaEmpleado", param, commandType: CommandType.StoredProcedure);
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
        public static bool AltaCategoriaEmpleado(CategoriaEmpleado empleado)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@Descripcion", empleado.Descripcion);
                    param.Add("@CantHsxTurtno", empleado.Canthoraxturno);
                    param.Add("@CantHsFinde", empleado.Canthsfinde);
                    db.Execute("sp_AltaCategoriaEmpleado", param, commandType: CommandType.StoredProcedure);
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
