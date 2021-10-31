using AppBanco.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBack.Servicios
{
    public interface IAplicacion
    {
        public List<TipoCuenta> ConsultarTipos();

        public bool RegistrarCliente(Cliente oCliente);

        public int ProximoNroCliente();
    }
}
