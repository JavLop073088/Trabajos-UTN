﻿using BancoBack.Dominio;
using BancoBack.Servicios;
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
        private SqlDataReader reader = null;

        private HelperDao()
        {
            cadenaConexion = @"Data Source=LAPTOP-JAVI\SQLEXPRESS;Initial Catalog=db_Banco;Integrated Security=True";           
        }

        public static HelperDao ObtenerInstancia() 
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        //Métodos de Acceso a Datos
        //-------------------------------------------------------------------------------------------
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
        //-------------------------------------------------------------------------------------------
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
        //-------------------------------------------------------------------------------------------
        public DataTable ConsultaTablaParam(string storeName, List<Parametro> criterios)
        {
            tabla = new DataTable();
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();

            try
            {               
                cnn.Open();
                cmd = new SqlCommand(storeName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Parametro param in criterios)
                {
                    if(param.Valor == null)
                        cmd.Parameters.AddWithValue(param.Nombre, DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue(param.Nombre, param.Valor.ToString());             
                }

                tabla.Load(cmd.ExecuteReader());               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return tabla;

        }
        //-------------------------------------------------------------------------------------------
        public Cliente SelectByNro(string storeName, int nro)
        {           
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
            Cliente oCliente = new Cliente();
            try
            {
                cnn.Open();
                cmd = new SqlCommand(storeName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nro", nro);
                reader = cmd.ExecuteReader();

                bool firstReg = true;

                while (reader.Read())
                {
                    if (firstReg)
                    {
                        oCliente.NroCliente = Convert.ToInt32(reader["nro_cliente"].ToString());
                        oCliente.NomCliente = reader["nom_cliente"].ToString();
                        oCliente.ApeCliente = reader["ape_cliente"].ToString();
                        oCliente.dni = Convert.ToInt32(reader["dni_cliente"].ToString());
                        if (!reader["fecha_baja"].Equals(DBNull.Value))
                            oCliente.FechaBaja = Convert.ToDateTime(reader["fecha_baja"].ToString());
                        firstReg = false;
                    }

                    Cuenta oCuenta = new Cuenta();
                    TipoCuenta oTipo = new TipoCuenta();
                    oTipo.IdTipo = Convert.ToInt32(reader["id_tipo_cuenta"].ToString());
                    oTipo.NombreTipo = reader["nom_tipo"].ToString();
                    oCuenta.TipoCta = oTipo;
                    oCuenta.Cbu = reader["cbu"].ToString();
                    oCuenta.Saldo = Convert.ToDouble(reader["saldo"].ToString());
                    oCuenta.UltimoMov = Convert.ToDateTime(reader["ultimo_mov"].ToString());
                    firstReg = false;
                    oCliente.AgregarCuenta(oCuenta);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return oCliente;
        }
        //-------------------------------------------------------------------------------------------
        public bool DeleteById(string storeName, int numeroClte, string param)
        {
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
            bool rta = true;
            try
            {
                cnn.Open();
                cmd = new SqlCommand(storeName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, numeroClte);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return rta;
        }
        //-------------------------------------------------------------------------------------------
        public bool UpdateTipoCuentas(string storeName, TipoCuenta oTipo)
        {
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
            bool rta = true;
            try
            {
                cnn.Open();
                cmd = new SqlCommand(storeName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo", oTipo.IdTipo);
                cmd.Parameters.AddWithValue("@nom_tipo", oTipo.NombreTipo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return rta;
        }
        //-------------------------------------------------------------------------------------------
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
        //-------------------------------------------------------------------------------------------
        public SqlParameter ConsultarAdministrador(string storeName, string outputName, Administrador oAdmin)
        {
            cnn = new SqlConnection();
            cmd = new SqlCommand();
            try
            {
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();

                SqlCommand cmdMaestro = new SqlCommand(storeName, cnn);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@username", oAdmin.NomAdmin);
                cmdMaestro.Parameters.AddWithValue("@password", oAdmin.PassAdmin);

                SqlParameter param = new SqlParameter(outputName, SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(param);
                cmdMaestro.ExecuteNonQuery();

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
        //-------------------------------------------------------------------------------------------
        public Administrador SelectByNroAdmin(string storeName, List<Parametro> filtros)
        {
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
            Administrador oAdministrador = new Administrador();
            try
            {
                cnn.Open();
                cmd = new SqlCommand(storeName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAdmin", filtros);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    oAdministrador.IdAdmin = Convert.ToInt32(reader["id_admin"].ToString());
                    oAdministrador.NomAdmin = reader["nom_admin"].ToString();
                    oAdministrador.PassAdmin = reader["pass_admin"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return oAdministrador;
        }
        //-------------------------------------------------------------------------------------------
        public bool InsertTipo(string storeName, TipoCuenta oTipo)
        {
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
            bool rta = true;
            try
            {
                cnn.Open();
                cmd = new SqlCommand(storeName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreTipo", oTipo.NombreTipo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return rta;
        }
        //-------------------------------------------------------------------------------------------
        public bool Update(string spMaestro, string spDetalle, Cliente oCliente)
        {
            cnn = new SqlConnection(cadenaConexion);

            bool resultado = true;
            try
            {               
                cnn.Open();
                trans = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand(spMaestro, cnn, trans);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@nroClte", oCliente.NroCliente);
                cmdMaestro.Parameters.AddWithValue("@nomClte", oCliente.NomCliente);
                cmdMaestro.Parameters.AddWithValue("@apeClte", oCliente.ApeCliente);
                cmdMaestro.Parameters.AddWithValue("@dniClte", oCliente.dni);
                //cmdMaestro.Parameters.AddWithValue("@fechaBaja", oCliente.FechaBaja);

                cmdMaestro.ExecuteNonQuery();
            
                foreach (Cuenta cta in oCliente.Cartera)
                {
                    SqlCommand cmdDetalle = new SqlCommand(spDetalle, cnn, trans);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@cbuCta", cta.Cbu);
                    cmdDetalle.Parameters.AddWithValue("@nroClte", oCliente.NroCliente);
                    cmdDetalle.Parameters.AddWithValue("@saldoCta", cta.Saldo);
                    cmdDetalle.Parameters.AddWithValue("@idTipoCta", cta.TipoCta.IdTipo);
                    cmdDetalle.Parameters.AddWithValue("@ultMov", cta.UltimoMov);
                    cmdDetalle.ExecuteNonQuery();
                }

                trans.Commit();

            }
            catch (Exception ex)
            {
                throw ex;
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
        //-------------------------------------------------------------------------------------------
        public bool UpdateAdmin(string spMaestro, Administrador oAdministrador)
        {
            cnn = new SqlConnection(cadenaConexion);

            bool resultado = true;
            try
            {
                cnn.Open();
                trans = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand(spMaestro, cnn, trans);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@idAdmin", oAdministrador.IdAdmin);
                cmdMaestro.Parameters.AddWithValue("@passAdmin", oAdministrador.PassAdmin);
                //cmdMaestro.Parameters.AddWithValue("@fechaBaja", oCliente.FechaBaja);

                cmdMaestro.ExecuteNonQuery();

                trans.Commit();

            }
            catch (Exception ex)
            {
                throw ex;
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
