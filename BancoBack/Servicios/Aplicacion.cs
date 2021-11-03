using AppBanco.Acceso_a_Datos;
using BancoBack.Dominio;
using BancoBack.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Servicios
{
    public class Aplicacion : IAplicacion
    {
        private IDao dao;
        
        
        public Aplicacion(AbstractDaoFactory factory)
        {
            dao = factory.CrearClienteDao();
        }

        public List<TipoCuenta> ConsultarTipos()
        {
            return dao.GetTipoCuentas();
        }

        public List<Revenue> ConsultarGraficoTorta()
        {
            return dao.GetGraficoTorta();
        }

        public List<Revenue> ConsultarGraficoCartesiano()
        {
            return dao.GetGraficoCartesiano();
        }

        public int ProximoNroCliente()
        {
            return dao.NextNumCliente();
        }

        public bool RegistrarCliente(Cliente oCliente)
        {
            return dao.SaveCliente(oCliente);
        }

        public List<Cliente> ConsultarClientes(List<Parametro> criterios)
        {
            return dao.GetByFilters(criterios);
        }

        public int ConsultarAdmins(Administrador oAdmin)
        {
            return dao.GetByFiltersAdmins(oAdmin);
        }

        public bool RegistrarBajaCliente(int numeroClte)
        {
            return dao.SaveBajaCliente(numeroClte);
        }

        public bool RegistrarTipoCuenta(TipoCuenta oTipo)
        {
            return dao.SaveTipoCuenta(oTipo);
        }
    }
}
