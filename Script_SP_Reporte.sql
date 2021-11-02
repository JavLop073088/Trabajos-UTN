ALTER PROC [dbo].[SP_REPORTE_CUENTAS]		
@baja varchar(1)   

AS
BEGIN 

	SELECT cl.nro_cliente as Nro_Cliente, cl.ape_cliente+' '+cl.nom_cliente as Cliente, cl.dni_cliente as DNI, sum(c.saldo) as Total_Cartera, COUNT(c.id_tipo_cuenta) as Cantidad_Cuentas, cl.fecha_baja as Fecha_Baja
	FROM cuentas c, clientes cl, tipo_cuentas tc
	where tc.id_tipo_cuenta = c.id_tipo_cuenta
	and cl.nro_cliente = c.nro_cliente
	and (@baja is null OR (@baja = 'S'and cl.fecha_baja IS NOT NULL) OR (@baja = 'N' and cl.fecha_baja IS  NULL))
	GROUP BY cl.nro_cliente, cl.ape_cliente+' '+cl.nom_cliente, cl.dni_cliente, cl.fecha_baja

END



declare @var varchar(1)
exec  SP_REPORTE_CUENTAS 'S'