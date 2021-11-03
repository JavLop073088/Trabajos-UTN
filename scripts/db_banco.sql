create database db_Banco

use db_Banco

create table tipo_cuentas(
id_tipo_cuenta int identity (1,1),
nom_tipo varchar (30)
constraint pk_tipo_cuentas primary key (id_tipo_cuenta)
);

create table clientes(
nro_cliente int identity(1,1),
nom_cliente varchar(30)not null,
ape_cliente varchar(30)not null,
dni_cliente int not null,
fecha_baja date 
constraint pk_clientes primary key(nro_cliente)
);

create table cuentas(
cbu nvarchar(22) not null,
nro_cliente int not null,--FK
saldo decimal(30,2),
id_tipo_cuenta int not null,--FK
ultimo_mov date
constraint pk_cuentas primary key (cbu),
constraint fk_tipoctas_cuentas foreign key(id_tipo_cuenta) references tipo_cuentas(id_tipo_cuenta),
constraint fk_clientes_cuentas foreign key(nro_cliente) references  clientes(nro_cliente)
);

create table administradores (
id_admin int identity(1,1),
nom_admin varchar(30),
pass_admin varchar(30)
constraint pk_administradores primary key(id_admin)
)

insert into tipo_cuentas (nom_tipo)
values ('Cuenta Corriente'),
		('Caja de Ahorros'),
		('Cuenta Sueldo'),
		('Cuenta de la Seguridad Social')


GO

--Insertar el Cliente 1 para que no genere error el SP que busca el número de Cliente
SET DATEFORMAT DMY
insert into clientes values ('Carlos','Torres',19236854,null)
insert into cuentas values ('2256685987457125469325',1,40000,1,'28/10/2021')

insert into administradores (nom_admin, pass_admin) 
values
	('CaroKuba', '112927'),
	('JaviLopez', '112704'),
	('FedeIrusta', '113102'),
	('FabriLoPresti', '112713')
select * from administradores

--STORED PROCEDURES--

CREATE PROCEDURE SP_CONSULTAR_TIPOS
AS
BEGIN
	
	SELECT * from tipo_cuentas;

END
------------------------------------------------------
CREATE PROCEDURE SP_CONSULTAR_PROX_NRO_CLIENTE
	@nroCliente int OUTPUT
AS
BEGIN
	SET @nroCliente = (SELECT MAX(nro_cliente)+1  FROM clientes)
END	

------------------------------------------------------
CREATE PROCEDURE SP_INSERTAR_CLIENTE
	@nomClte varchar(30),
	@apeClte varchar(30),
	@dniClte int,
	@nroClte int output
AS
BEGIN
	INSERT INTO clientes (nom_cliente, ape_cliente, dni_cliente)
		VALUES (@nomClte, @apeClte, @dniClte)
	
	SET @nroClte = SCOPE_IDENTITY();
END
-------------------------------------------------------
CREATE PROCEDURE SP_INSERTAR_CUENTA
	@cbuCta nvarchar(22),
	@nroClte int,
	@saldoCta decimal(30, 2),
	@idTipoCta int,
	@ultMov date
AS
BEGIN
	INSERT INTO cuentas (cbu, nro_cliente, saldo, id_tipo_cuenta, ultimo_mov)
		VALUES (@cbuCta, @nroClte, @saldoCta, @idTipoCta, @ultMov)
END

-------------------------------------------------------
--Cambio  01/11
ALTER PROCEDURE SP_LOGIN_ADMINS
	@username VARCHAR(30),
	@password VARCHAR(30),
	@retorno INT OUTPUT
AS
BEGIN
	SELECT
		@retorno = COUNT(*)
	FROM administradores
	WHERE nom_admin = @username
	AND pass_admin = @password
END
DECLARE @resultado int
EXEC SP_LOGIN_ADMINS 'CaroKuba', '112927', @resultado output
SELECT @resultado
-------------------------------------------------------

CREATE PROCEDURE SP_GRAFICO_TORTA
AS
BEGIN
	SELECT
		YEAR(C.ultimo_mov) AS 'years',
		COUNT(C.id_tipo_cuenta) AS 'total'
	FROM cuentas C
	GROUP BY YEAR(C.ultimo_mov)
END

CREATE PROCEDURE SP_GRAFICO_CARTESIANO
AS
BEGIN
	SELECT
		YEAR(C.ultimo_mov) AS 'years',
		MONTH(C.ultimo_mov) AS 'months',
		SUM(C.saldo) AS 'total'
	FROM cuentas C
	GROUP BY YEAR(C.ultimo_mov), MONTH(C.ultimo_mov)
END
-------------------------------------------------------
--Cambios  02/11
ALTER PROCEDURE SP_CONSULTAR_CLIENTES
	@nroClte int,
	@nomClte varchar(50),
	@apeClte varchar(50),
	@dniClte int,
	@dato_baja varchar(4)
AS
BEGIN
	IF(@dato_baja = 'N')
		SELECT * FROM clientes c
		WHERE ( (c.nro_cliente = @nroClte) 
		OR (c.nom_cliente like '%'+@nomClte+'%')
		OR (c.ape_cliente like '%'+@apeClte+'%')
		OR (c.dni_cliente = @dniClte) )
		AND (fecha_baja is null)
	else
		SELECT * FROM clientes c
		WHERE ( (c.nro_cliente = @nroClte) 
		OR (c.nom_cliente like '%'+@nomClte+'%')
		OR (c.ape_cliente like '%'+@apeClte+'%')
		OR (c.dni_cliente = @dniClte) )
		OR (fecha_baja is not null)
	
END
-------------------------------------------------------
--Cambios  03/11
CREATE PROCEDURE SP_INSERTAR_TIPOS
	@nombreTipo varchar(50)
AS
BEGIN
	INSERT INTO tipo_cuentas
		VALUES(@nombreTipo)
END
<<<<<<< HEAD
-------------------------------------------------------
--2do Cambio  03/11
CREATE PROCEDURE SP_CONSULTAR_POR_NRO
	@nro int	
AS
BEGIN
	SELECT *
	FROM clientes t1, cuentas  t2, tipo_cuentas t3
	WHERE t1.nro_cliente = t2.nro_cliente
	AND t2.id_tipo_cuenta = t3.id_tipo_cuenta
	AND t1.nro_cliente = @nro;
END

exec SP_CONSULTAR_POR_NRO 10

-------------------------------------------------------
--3er Cambio  03/11
CREATE PROCEDURE SP_ACTUALIZAR_CLIENTE
	@nroClte int,
	@nomClte varchar(30),
	@apeClte varchar(30),
	@dniClte int--,
	--@fechaBaja datetime
AS
BEGIN
	UPDATE clientes SET nom_cliente = @nomClte WHERE nro_cliente = @nroClte
	UPDATE clientes SET ape_cliente = @apeClte WHERE nro_cliente = @nroClte
	UPDATE clientes SET dni_cliente = @dniClte WHERE nro_cliente = @nroClte
	/*IF(@fechaBaja is not null)
		UPDATE clientes SET fecha_baja = null WHERE nro_cliente = @nroClte*/
END
	 
CREATE PROCEDURE SP_ACTUALIZAR_CUENTA
    @cbuCta nvarchar(22),
	@nroClte int,
	@saldoCta decimal(30, 2),
	@idTipoCta int,
	@ultMov date
AS
BEGIN

	--UPDATE cuentas SET cbu = @cbuCta WHERE nro_cliente = @nroClte
		UPDATE cuentas SET saldo = @saldoCta WHERE nro_cliente = @nroClte
		UPDATE cuentas SET id_tipo_cuenta = @idTipoCta WHERE nro_cliente = @nroClte
		UPDATE cuentas SET ultimo_mov = @ultMov WHERE nro_cliente = @nroClte

END
*/
select * from clientes
select * from cuentas
select * from tipo_cuentas
select * from administradores*/
