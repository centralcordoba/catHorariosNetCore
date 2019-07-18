using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using waEntitys;

namespace waRepositorys
{
    public class TurnosRepository
    {
        static string _db = "Data Source=ARGSQL03;Initial Catalog=HorariosPrueba;User ID=sa;Password=bfg2007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /// <summary>
        /// Creacion de código para ejecutar sp UpdateEmpresa
        /// </summary>
        /// <param @Descripcion es la descripción de la Categoría></param>
        /// <param @CantHsxTurtno es la cantidad de horas de permanencia que debe tener el empleado en la Empresa asociado a la Categoría></param>
        /// <param @CantHsFinde es la cantidad de horas de permanencia el fin de semana que debe tener el empleado en la Empresa asociado a la Categoría></param>
        /// <returns></returns>
        public static bool UpdateTurnos(Turnos turnos)
        {
            try
            {
                using (System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@Nombre", turnos.Nombre);
                    param.Add("@Inicio", turnos.Inicio);
                    param.Add("@Fin", turnos.Fin);
                    param.Add("@Categoria", turnos.Categoria);
                    param.Add("@Tolerancia", turnos.Tolerancia);
                    param.Add("@InicioF", turnos.InicioF);
                    param.Add("@FinF", turnos.FinF);
                    param.Add("@Idturno", turnos.idturno);
                    db.Execute("sp_UpdateTurnos", param, commandType: CommandType.StoredProcedure);
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
        public static bool Altaturnos(Turnos turnos)
        {
            try
            {
                using (System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@nombre", turnos.Nombre);
                    param.Add("@Inicio", turnos.Inicio);
                    param.Add("@Fin", turnos.Fin);
                    param.Add("@Categoria", turnos.Categoria);
                    param.Add("@Tolerancia", turnos.Tolerancia);
                    param.Add("@InicioF", turnos.InicioF);
                    param.Add("@Finf", turnos.FinF);
                    db.Execute("sp_Altaturnos", param, commandType: CommandType.StoredProcedure);
                    db.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }
        public static List<Turnos> GetAllturnos()
        {
            ///lstCategoriaEmpleado List<CategoriaEmpleado> new= List<CategoriaEmpleado>();
            try
            {
                using (System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();

                    return db.Query<Turnos>("sp_ListarTurnos", commandType: CommandType.StoredProcedure).AsList();
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

