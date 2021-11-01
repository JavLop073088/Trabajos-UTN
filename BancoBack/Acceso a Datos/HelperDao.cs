using AppBanco.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Acceso_a_Datos
{
    class HelperDao
    {
        private static HelperDao instancia;
        private string cadenaConexion;

        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private DataTable tabla = null;
        private SqlTransaction trans = null;

        private HelperDao()
        {
            cadenaConexion = @"Data Source=LAPTOP-8EMNHC7Q;Initial Catalog=db_Banco;Integrated Security=True";
            //cadenaConexion = Properties.Resources.strConexion; 
        }

        public static HelperDao ObtenerInstancia() 
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        

        public DataTable ConsultaTabla(string storeName)
        {
            tabla = new DataTable();
            cnn = new SqlConnection();
            cmd = new SqlCommand();
            try
            {             
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                tabla.Load(cmd.ExecuteReader());              
            }
            catch (Exception)
            {
               tabla = null;
            }
            finally
            {                
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return tabla;           
        }

        public SqlParameter ConsultaNro(string storeName, string outputName)
        {          
            cnn = new SqlConnection();
            cmd = new SqlCommand();
            try
            {
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;

                SqlParameter param = new SqlParameter(outputName, SqlDbType.Int);
                param.IsNullable = true;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();

                return param;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }          
        }

        public bool Insert(string spMaestro, string spDetalle, Cliente oCliente)
        {
            cnn = new SqlConnection();
           
            bool resultado = true;
            try
            {
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();
                trans = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand(spMaestro, cnn, trans);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@nomClte", oCliente.NomCliente);
                cmdMaestro.Parameters.AddWithValue("@apeClte", oCliente.ApeCliente);
                cmdMaestro.Parameters.AddWithValue("@dniClte", oCliente.dni);

                SqlParameter param = new SqlParameter("@nroClte", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(param);
                cmdMaestro.ExecuteNonQuery();

                int nroClte = (int)param.Value;


                foreach (Cuenta cta in oCliente.Cartera)
                {
                    SqlCommand cmdDetalle = new SqlCommand(spDetalle, cnn, trans);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@cbuCta", cta.Cbu);
                    cmdDetalle.Parameters.AddWithValue("@nroClte", nroClte);
                    cmdDetalle.Parameters.AddWithValue("@saldoCta", cta.Saldo);
                    cmdDetalle.Parameters.AddWithValue("@idTipoCta", cta.TipoCta.IdTipo);
                    cmdDetalle.Parameters.AddWithValue("@ultMov", cta.UltimoMov);
                    cmdDetalle.ExecuteNonQuery();
                }

                trans.Commit();

            }
            catch (Exception)
            {
                trans.Rollback();
                resultado = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return resultado;

        }
    }
}
