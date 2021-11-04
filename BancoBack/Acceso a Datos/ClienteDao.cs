using BancoBack.Dominio;
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
    class ClienteDao : IDao
    {
        //-------------------------------------------------------------------------------------------
        public List<TipoCuenta> GetTipoCuentas()
        {
            List<TipoCuenta> lst = new List<TipoCuenta>();

            DataTable t = HelperDao.ObtenerInstancia().ConsultaTabla("SP_CONSULTAR_TIPOS");

            foreach (DataRow row in t.Rows)
            {
                TipoCuenta oTipo = new TipoCuenta();
                oTipo.IdTipo = Convert.ToInt32(row["id_tipo_cuenta"].ToString());
                oTipo.NombreTipo = row["nom_tipo"].ToString();

                lst.Add(oTipo);
            }
            return lst;
        }
        //-------------------------------------------------------------------------------------------
        public List<Revenue> GetGraficoTorta()
        {
            List<Revenue> lst = new List<Revenue>();
            DataTable t = HelperDao.ObtenerInstancia().ConsultaTabla("SP_GRAFICO_TORTA");

            foreach (DataRow row in t.Rows)
            {
                Revenue oIngresos = new Revenue();
                oIngresos.Value = Convert.ToInt32(row["cantidad"].ToString());
                oIngresos.Tipo = row["tipo_cuenta"].ToString();

                lst.Add(oIngresos);
            }
            return lst;
        }
        //-------------------------------------------------------------------------------------------
        public List<Revenue> GetGraficoCartesiano()
        {
            List<Revenue> lst = new List<Revenue>();
            DataTable t = HelperDao.ObtenerInstancia().ConsultaTabla("SP_GRAFICO_CARTESIANO");

            foreach (DataRow row in t.Rows)
            {
                Revenue oIngresos = new Revenue();
                oIngresos.Year = Convert.ToInt32(row["years"].ToString());
                oIngresos.Month = Convert.ToInt32(row["months"].ToString());
                oIngresos.Value = Convert.ToDouble(row["total"].ToString());

                lst.Add(oIngresos);
            }
            return lst;
        }
        //-------------------------------------------------------------------------------------------
        public List<Revenue> GetGraficoDashboard()
        {
            List<Revenue> lst = new List<Revenue>();
            DataTable t = HelperDao.ObtenerInstancia().ConsultaTabla("SP_DASHBOARD");

            foreach (DataRow row in t.Rows)
            {
                Revenue oIngresos = new Revenue();
                oIngresos.Year = Convert.ToInt32(row["cantidad_admins"].ToString());
                oIngresos.Month = Convert.ToInt32(row["cantidad_clientes"].ToString());
                oIngresos.Cantidad = Convert.ToInt32(row["cantidad_cuentas"].ToString());
                oIngresos.Value = Convert.ToDouble(row["monto_total"].ToString());

                lst.Add(oIngresos);
            }
            return lst;
        }
        //-------------------------------------------------------------------------------------------
        public bool SaveCliente(Cliente oCliente)
        {
            return HelperDao.ObtenerInstancia().Insert("SP_INSERTAR_CLIENTE", "SP_INSERTAR_CUENTA", oCliente);
        }
        //-------------------------------------------------------------------------------------------
        public int NextNumCliente()
        {
            int proxNroCliente = 0;
            SqlParameter param = HelperDao.ObtenerInstancia().ConsultaNro("SP_CONSULTAR_PROX_NRO_CLIENTE", "@nroCliente");
            return proxNroCliente = Convert.ToInt32(param.Value);         
        }
        //-------------------------------------------------------------------------------------------
        public List<Cliente> GetByFilters(List<Parametro> criterios)
        {
            List<Cliente> listClts = new List<Cliente>();
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTablaParam("SP_CONSULTAR_CLIENTES", criterios);

            foreach (DataRow row in tabla.Rows)
            {
                Cliente oCliente = new Cliente();
                oCliente.NroCliente = Convert.ToInt32(row["nro_cliente"].ToString());
                oCliente.NomCliente = row["nom_cliente"].ToString();
                oCliente.ApeCliente = row["ape_cliente"].ToString();
                oCliente.dni = Convert.ToInt32(row["dni_cliente"].ToString());
                if (!row["fecha_baja"].Equals(DBNull.Value))
                    oCliente.FechaBaja = Convert.ToDateTime(row["fecha_baja"].ToString());
                
                listClts.Add(oCliente);
            }

            return listClts;
        }
        //-------------------------------------------------------------------------------------------
        public int GetByFiltersAdmins(Administrador oAdmin)
        {
            SqlParameter param = HelperDao.ObtenerInstancia().ConsultarAdministrador("SP_LOGIN_ADMINS", "@retorno", oAdmin);
            if (param.Value.Equals(DBNull.Value))
            {
                return 0;
            }

            return Convert.ToInt32(param.Value);
        }
        //-------------------------------------------------------------------------------------------
        public bool SaveBajaCliente(int numeroClte)
        {
            return HelperDao.ObtenerInstancia().DeleteById("SP_REGISTRAR_BAJA", numeroClte);
        }
        //-------------------------------------------------------------------------------------------
        public bool SaveTipoCuenta(TipoCuenta oTipo)
        {
            return HelperDao.ObtenerInstancia().InsertTipo("SP_INSERTAR_TIPOS", oTipo);
        }
        //-------------------------------------------------------------------------------------------
        public Cliente GetByNro(int nro)
        {      
            return HelperDao.ObtenerInstancia().SelectByNro("SP_CONSULTAR_POR_NRO", nro);
        }
        //-------------------------------------------------------------------------------------------
        public Administrador GetByNroAdmin(List<Parametro> filtros)
        {
            Administrador oAdmin = new Administrador();
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTablaParam("SP_CONSULTAR_POR_NRO_ADMIN", filtros);

            foreach (DataRow row in tabla.Rows)
            {
                oAdmin.IdAdmin = Convert.ToInt32(row["id_admin"].ToString());
                oAdmin.NomAdmin = row["nom_admin"].ToString();
            }

            return oAdmin;
        }
        //-------------------------------------------------------------------------------------------
        public bool SaveModifCliente(Cliente oCliente)
        {
            return HelperDao.ObtenerInstancia().Update("SP_ACTUALIZAR_CLIENTE", "SP_ACTUALIZAR_CUENTA", oCliente);
        }
        //-------------------------------------------------------------------------------------------
        public bool SaveModifAdmin(Administrador oAdministrador)
        {
            return HelperDao.ObtenerInstancia().UpdateAdmin("SP_UPDATE_ADMIN", oAdministrador);
        }

    }

}
