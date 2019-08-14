using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using waEntitys;

namespace waRepositorys
{
    public class FuncionesRepository
    {
        static string _db = "Data Source=ARGSQL03;Initial Catalog=HorariosPrueba;User ID=sa;Password=bfg2007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /// <summary>
        /// Creacion de código para ejecutar sp UpdateEmpresa
        /// </summary>
        /// <param @Descripcion es la descripción de la Categoría></param>
        /// <param @CantHsxTurtno es la cantidad de horas de permanencia que debe tener el empleado en la Empresa asociado a la Categoría></param>
        /// <param @CantHsFinde es la cantidad de horas de permanencia el fin de semana que debe tener el empleado en la Empresa asociado a la Categoría></param>
        /// <returns></returns>
        public static bool UpdateFunciones(Funciones funcion)
        {
            try
            {
                using (System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@codfuncion", funcion.codfuncion);
                    param.Add("@descripcion", funcion.descripcion);
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
        public static bool AltaFuncion(Funciones funcion)
        {
            try
            {
                using (System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@codfuncion", funcion.codfuncion);
                    param.Add("@descripcion", funcion.descripcion);
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
        public static List<Funciones> GetAllfuncion()
        {
            ///lstCategoriaEmpleado List<CategoriaEmpleado> new= List<CategoriaEmpleado>();
            try
            {
                using (System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();

                    return db.Query<Funciones>("sp_ListarFunciones", commandType: CommandType.StoredProcedure).AsList();
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
