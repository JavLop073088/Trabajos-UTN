using AppBanco.Acceso_a_Datos;
using AppBanco.Dominio;
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
     
        public int ProximoNroCliente()
        {
            return dao.NextNumCliente();
        }

        public bool RegistrarCliente(Cliente oCliente)
        {
            return dao.SaveCliente(oCliente);
        }
    }
}
