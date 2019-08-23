using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using waEntitys;
using System.Linq;

namespace waRepositorys
{
    public class EmpleadoRepository
    {
        static string _db = "Data Source=ARGSQL03;Initial Catalog=HorariosPrueba;User ID=sa;Password=bfg2007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static bool UpdateEmpleado(Empleados empleado)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@legajo", empleado.Legajo);
                    param.Add("@nombre", empleado.Nombre);
                    param.Add("@sector", empleado.Sector);
                    param.Add("@centro", empleado.Centro);
                    param.Add("@dni", empleado.DNI);
                    param.Add("@empresa", empleado.Empresa);
                    param.Add("@control", empleado.Control);
                    param.Add("@horaentrada", empleado.Horaentrada);
                    param.Add("@turno", empleado.Turno);
                    param.Add("@direccion", empleado.Direccion);
                    param.Add("@telefono", empleado.Telefono);
                    param.Add("@celular", empleado.Celular);
                    param.Add("@email", empleado.Email);
                    param.Add("@foto", empleado.Foto);
                    param.Add("@estado", empleado.Estado);
                    param.Add("@usuario", empleado.Usuario);
                    param.Add("@clave", empleado.Clave);
                    param.Add("@BajoConvenio", empleado.Bajoconvenio);
                    param.Add("@FechaIng", empleado.FechaIng);
                    param.Add("@FechaBaja", empleado.FechaBaja);
                    param.Add("@FechaNac", empleado.FechaNac);
                    param.Add("@CtrlReg", empleado.CtrlReg);
                    param.Add("@Municipio", empleado.Muicipio);
                    param.Add("@NroReg", empleado.NroReg);
                    param.Add("@FecEmis", empleado.FecEmis);
                    param.Add("@FecVto", empleado.FecVto);
                    param.Add("@Informado", empleado.Informado);
                    param.Add("@FechaInformado", empleado.FechaInformado);
                    param.Add("@Funcion", empleado.Funcion);
                    param.Add("@Lugar", empleado.Lugar);
                    param.Add("@Ctarj", empleado.Ctarj);
                    param.Add("@Verif", empleado.Verif);
                    param.Add("@InfRasa", empleado.InfRasa);
                    param.Add("@emisautoelev", empleado.Emisorautoelev);
                    param.Add("@nroregautoelev", empleado.Nroregautoelev);
                    param.Add("@fecemisregautoelev", empleado.Fecemisregautoelev);
                    param.Add("@fecvenregautoelev", empleado.Fecvenregautoelev);
                    param.Add("@CtrlRegAutoelev", empleado.CtrlRegAutoelev);
                    param.Add("@InformAutoelev", empleado.InformAutoelev);
                    param.Add("@InformaAusentismo", empleado.InformaAusentismo);
                    param.Add("@categoria", empleado.Categoria);
                    db.Execute("sp_UpdateEmpleado", param, commandType: CommandType.StoredProcedure);
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
        public static bool AltaEmpleado(Empleados empleado)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@legajo", empleado.Legajo);
                    param.Add("@nombre", empleado.Nombre);
                    param.Add("@sector", empleado.Sector);
                    param.Add("@centro", empleado.Centro);
                    param.Add("@dni", empleado.DNI);
                    param.Add("@empresa", empleado.Empresa);
                    param.Add("@control", empleado.Control);
                    param.Add("@horaentrada", empleado.Horaentrada);
                    param.Add("@turno", empleado.Turno);
                    param.Add("@direccion", empleado.Direccion);
                    param.Add("@telefono", empleado.Telefono);
                    param.Add("@celular", empleado.Celular);
                    param.Add("@email", empleado.Email);
                    param.Add("@foto", empleado.Foto);
                    param.Add("@estado", empleado.Estado);
                    param.Add("@usuario", empleado.Usuario);
                    param.Add("@clave", empleado.Clave);
                    param.Add("@BajoConvenio", empleado.Bajoconvenio);
                    param.Add("@FechaIng", empleado.FechaIng);
                    param.Add("@FechaBaja", empleado.FechaBaja);
                    param.Add("@FechaNac", empleado.FechaNac);
                    param.Add("@CtrlReg", empleado.CtrlReg);
                    param.Add("@Municipio", empleado.Muicipio);
                    param.Add("@NroReg", empleado.NroReg);
                    param.Add("@FecEmis", empleado.FecEmis);
                    param.Add("@FecVto", empleado.FecVto);
                    param.Add("@Informado", empleado.Informado);
                    param.Add("@FechaInformado", empleado.FechaInformado);
                    param.Add("@Funcion", empleado.Funcion);
                    param.Add("@Lugar", empleado.Lugar);
                    param.Add("@Ctarj", empleado.Ctarj);
                    param.Add("@Verif", empleado.Verif);
                    param.Add("@InfRasa", empleado.InfRasa);
                    param.Add("@emisautoelev", empleado.Emisorautoelev);
                    param.Add("@nroregautoelev", empleado.Nroregautoelev);
                    param.Add("@fecemisregautoelev", empleado.Fecemisregautoelev);
                    param.Add("@fecvenregautoelev", empleado.Fecvenregautoelev);
                    param.Add("@CtrlRegAutoelev", empleado.CtrlRegAutoelev);
                    param.Add("@InformAutoelev", empleado.InformAutoelev);
                    param.Add("@InformaAusentismo", empleado.InformaAusentismo);
                    param.Add("@categoria", empleado.Categoria);
                    db.Execute("sp_AltaEmpleado", param, commandType: CommandType.StoredProcedure);
                    db.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }
        public static List<Empleados> GetAllEmpleado()
        {
            ///lstEmpleados List<Empleados> new= List<Empleados>();
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {
                   
                    db.Open();
                    
                    return db.Query<Empleados>("sp_cnEmpleados", commandType: CommandType.StoredProcedure).AsList();
                    db.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public static Empleados GetEmpleadoAutorizado(int legajo)
        {
            ///lstEmpleados List<Empleados> new= List<Empleados>();
            try
            {
                using (IDbConnection db = new SqlConnection(_db))
                {

                    DynamicParameters param = new DynamicParameters();
                    db.Open();
                    param.Add("@legajo", legajo);

                    return db.Query<Empleados>("sp_cnEmpleados", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

