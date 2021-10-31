using AppBanco.Acceso_a_Datos;
using BancoBack.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Servicios
{
    public class ApplicationFactory : AbstractApplicationFactory
    {
        public override IAplicacion CrearAplicacion(AbstractDaoFactory factory)
        {
            return new Aplicacion(factory);
        }
    }
}
