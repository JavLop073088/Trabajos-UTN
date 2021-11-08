using BancoBack.Dominio;
using BancoBack.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Acceso_a_Datos
{
   public interface IDao
    {
        public List<TipoCuenta> GetTipoCuentas();

        public List<Revenue> GetGraficoTorta();

        public List<Revenue> GetGraficoCartesiano();

        public List<Revenue> GetGraficoDashboard();

        public bool SaveCliente(Cliente oCliente);

        public int NextNumCliente();

        public List<Cliente> GetByFilters(List<Parametro> criterios);

        public int GetByFiltersAdmins(Administrador oAdmin);

        public Administrador GetByNroAdmin(List<Parametro> filtros);

        public bool SaveBajaCliente(int numeroClte);

        public bool SaveTipoCuenta(TipoCuenta oTipo);

        public Cliente GetByNro(int nro);

        public bool SaveModifCliente(Cliente oCliente);

        public bool SaveModifAdmin(Administrador oAdministrador);

        public bool UpdateTipoCuenta(TipoCuenta oTipo);

        public bool DeleteTipoCuenta(int idTipo);


    }

}
