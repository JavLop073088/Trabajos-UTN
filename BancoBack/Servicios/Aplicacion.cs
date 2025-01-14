﻿using AppBanco.Acceso_a_Datos;
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
        //-----------------------------------------------------------
        public List<TipoCuenta> ConsultarTipos()
        {
            return dao.GetTipoCuentas();
        }
        //-----------------------------------------------------------
        public List<Revenue> ConsultarGraficoTorta()
        {
            return dao.GetGraficoTorta();
        }
        //-----------------------------------------------------------
        public List<Revenue> ConsultarGraficoCartesiano()
        {
            return dao.GetGraficoCartesiano();
        }
        //-----------------------------------------------------------
        public List<Revenue> ConsultarDashboard()
        {
            return dao.GetGraficoDashboard();
        }
        //-----------------------------------------------------------
        public int ProximoNroCliente()
        {
            return dao.NextNumCliente();
        }
        //-----------------------------------------------------------
        public bool RegistrarCliente(Cliente oCliente)
        {
            return dao.SaveCliente(oCliente);
        }
        //-----------------------------------------------------------
        public List<Cliente> ConsultarClientes(List<Parametro> criterios)
        {
            return dao.GetByFilters(criterios);
        }
        //------------------------------------------------------------
        public int ConsultarAdmins(Administrador oAdmin)
        {
            return dao.GetByFiltersAdmins(oAdmin);
        }
        //------------------------------------------------------------
        public Administrador ObtenerAdminByNro(List<Parametro> filtros)
        {
            return dao.GetByNroAdmin(filtros);
        }
        //------------------------------------------------------------
        public bool RegistrarBajaCliente(int numeroClte)
        {
            return dao.SaveBajaCliente(numeroClte);
        }
        //------------------------------------------------------------
        public bool RegistrarTipoCuenta(TipoCuenta oTipo)
        {
            return dao.SaveTipoCuenta(oTipo);
        }
        //------------------------------------------------------------
        public Cliente ObtenerClienteByNro(int nro)
        {
            return dao.GetByNro(nro);
        }
        //------------------------------------------------------------
        public bool ActualizarCliente(Cliente oCliente)
        {
            return dao.SaveModifCliente(oCliente);
        }
        //------------------------------------------------------------
        public bool ActualizarAdmin(Administrador oAdministrador)
        {
            return dao.SaveModifAdmin(oAdministrador);
        }
        //------------------------------------------------------------
        public bool ActualizarTipoCuenta(TipoCuenta oTipo)
        {
            return dao.UpdateTipoCuenta(oTipo);
        }
        //------------------------------------------------------------
        public bool BorrarTipoCuenta(int idTipo)
        {
            return dao.DeleteTipoCuenta(idTipo);

        }
        //------------------------------------------------------------
    }


}
