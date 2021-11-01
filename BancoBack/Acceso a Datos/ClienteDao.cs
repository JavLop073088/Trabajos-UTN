using BancoBack.Dominio;
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

        public List<Revenue> GetGraficoTorta()
        {
            List<Revenue> lst = new List<Revenue>();
            DataTable t = HelperDao.ObtenerInstancia().ConsultaTabla("SP_GRAFICO_TORTA");

            foreach (DataRow row in t.Rows)
            {
                Revenue oIngresos = new Revenue();
                oIngresos.Year = Convert.ToInt32(row["years"].ToString());
                oIngresos.Value = Convert.ToInt32(row["total"].ToString());

                lst.Add(oIngresos);
            }
            return lst;
        }

        public bool SaveCliente(Cliente oCliente)
        {
            return HelperDao.ObtenerInstancia().Insert("SP_INSERTAR_CLIENTE", "SP_INSERTAR_CUENTA", oCliente);
        }

        public int NextNumCliente()
        {
            int proxNroCliente = 0;
            SqlParameter param = HelperDao.ObtenerInstancia().ConsultaNro("SP_CONSULTAR_PROX_NRO_CLIENTE", "@nroCliente");
            return proxNroCliente = Convert.ToInt32(param.Value);         
        }

    }
}
