USE GD1C2016
GO
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'TODO_X2_LUCAS')
BEGIN
	EXEC ('CREATE SCHEMA TODO_X2_LUCAS AUTHORIZATION gd')
END
GO 
/**************************************************  DROP TRABLES AND PROCEDURES ***************************************************/
IF OBJECT_ID('TODO_X2_LUCAS.Auditoria_Login') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Auditoria_Login;
IF OBJECT_ID('TODO_X2_LUCAS.Compras') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Compras;
IF OBJECT_ID('TODO_X2_LUCAS.Detalles_Empresas') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Detalles_Empresas;
IF OBJECT_ID('TODO_X2_LUCAS.Calificaciones') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Calificaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Funcionalidades_Por_Rol') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Funcionalidades_Por_Rol;
IF OBJECT_ID('TODO_X2_LUCAS.Funcionalidades') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Funcionalidades;
IF OBJECT_ID('TODO_X2_LUCAS.Inconsistencias_Calificaciones') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Inconsistencias_Calificaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Items_Facturas') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Items_Facturas;
IF OBJECT_ID('TODO_X2_LUCAS.Facturas') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Facturas;
IF OBJECT_ID('TODO_X2_LUCAS.Formas_De_Pago') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Formas_De_Pago;
IF OBJECT_ID('TODO_X2_LUCAS.Ofertas') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Ofertas;
IF OBJECT_ID('TODO_X2_LUCAS.Detalles_Clientes') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Detalles_Clientes;
IF OBJECT_ID('TODO_X2_LUCAS.Domicilios') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Domicilios;
IF OBJECT_ID('TODO_X2_LUCAS.Publicaciones') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Publicaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Estados_Publicaciones') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Estados_Publicaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Rubros') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Rubros;
IF OBJECT_ID('TODO_X2_LUCAS.Tipos_Publicaciones') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Tipos_Publicaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Usuarios') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Usuarios;
IF OBJECT_ID('TODO_X2_LUCAS.Visibilidades_Publicaciones') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Visibilidades_Publicaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Roles') IS NOT NULL
DROP TABLE TODO_X2_LUCAS.Roles;
IF OBJECT_ID('TODO_X2_LUCAS.Validar_Login') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Validar_Login;
IF OBJECT_ID('TODO_X2_LUCAS.ActualizarIntentos') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.ActualizarIntentos;
IF OBJECT_ID('TODO_X2_LUCAS.MigrarPublicaciones') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.MigrarPublicaciones;
IF OBJECT_ID('TODO_X2_LUCAS.MigrarEmpresas') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.MigrarEmpresas;
IF OBJECT_ID('TODO_X2_LUCAS.MigrarClientes') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.MigrarClientes;
IF OBJECT_ID('TODO_X2_LUCAS.Agregar_Calificacion_Posible') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Agregar_Calificacion_Posible;
IF OBJECT_ID('TODO_X2_LUCAS.Baja_Rol') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Baja_Rol;
IF OBJECT_ID('TODO_X2_LUCAS.Modificar_Estado_Rol') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Modificar_Estado_Rol;
IF OBJECT_ID('TODO_X2_LUCAS.Modificar_Nombre_Rol') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Modificar_Nombre_Rol;
IF OBJECT_ID('TODO_X2_LUCAS.Quitar_Funcionalidad_A_Rol') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Quitar_Funcionalidad_A_Rol;
IF OBJECT_ID('TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad;
IF OBJECT_ID('TODO_X2_LUCAS.Agregar_Rol') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Agregar_Rol;
IF OBJECT_ID('TODO_X2_LUCAS.Agregar_Funcionalidad') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Agregar_Funcionalidad;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Calificacion_Por_Publicacion') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Calificacion_Por_Publicacion;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Calificaciones_Por_Publicaciones') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Calificaciones_Por_Publicaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Publicacion') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Publicacion;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Publicaciones') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Publicaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Estado') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Estado;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Estados') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Estados;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Visibilidad') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Visibilidad;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Visibilidades') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Visibilidades;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Rubro') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Rubro;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Rubros') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Rubros;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Item_De_Factura') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Item_De_Factura;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Items_De_Facturas') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Items_De_Facturas;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Factura') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Factura;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Facturas') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Facturas;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Forma_De_Pago') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Forma_De_Pago;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Formas_De_Pago') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Formas_De_Pago;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Empresa') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Empresa;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Empresas') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Empresas;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Cliente') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Cliente;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Clientes') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Clientes;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Domicilio') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Domicilio;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Domicilios') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Domicilios;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Calificacion') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Calificacion;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Calificaciones') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Calificaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Usuario') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Usuario;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Usuarios') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Usuarios;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Funcionalidades_Por_Rol') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Funcionalidades_Por_Rol;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Funcionalidades_Por_Roles') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Funcionalidades_Por_Roles;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Funcionalidad') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Funcionalidad;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Funcionalidades') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Funcionalidades;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Rol') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Rol;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Roles') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Roles;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Tipo_De_Publicacion') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Tipo_De_Publicacion;
IF OBJECT_ID('TODO_X2_LUCAS.Get_Tipos_De_Publicacion') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Get_Tipos_De_Publicacion;
IF OBJECT_ID('TODO_X2_LUCAS.Migrar_Calificaciones') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Migrar_Calificaciones;
IF OBJECT_ID('TODO_X2_LUCAS.Alta_Usuario') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Alta_Usuario;
IF OBJECT_ID('TODO_X2_LUCAS.Modificar_Usuario') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Modificar_Usuario;
IF OBJECT_ID('TODO_X2_LUCAS.Baja_Usuario') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Baja_Usuario;
IF OBJECT_ID('TODO_X2_LUCAS.Alta_Domicilio') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Alta_Domicilio;
IF OBJECT_ID('TODO_X2_LUCAS.Alta_Cliente') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Alta_Cliente;
IF OBJECT_ID('TODO_X2_LUCAS.Alta_Empresa') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Alta_Empresa;
IF OBJECT_ID('TODO_X2_LUCAS.Alta_Visibilidad') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Alta_Visibilidad;
IF OBJECT_ID('TODO_X2_LUCAS.Modificar_Cliente') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Modificar_Cliente;
IF OBJECT_ID('TODO_X2_LUCAS.Modificar_Empresa') IS NOT NULL
DROP PROCEDURE TODO_X2_LUCAS.Modificar_Empresa;

IF OBJECT_ID('TODO_X2_LUCAS.ObtenerUsuario') IS NOT NULL
DROP FUNCTION TODO_X2_LUCAS.ObtenerUsuario;
IF OBJECT_ID('TODO_X2_LUCAS.Obtener_Cod_Domicilio') IS NOT NULL
DROP FUNCTION TODO_X2_LUCAS.Obtener_Cod_Domicilio;
IF OBJECT_ID('TODO_X2_LUCAS.ObtenerFuncionalidad') IS NOT NULL
DROP FUNCTION TODO_X2_LUCAS.ObtenerFuncionalidad;
IF OBJECT_ID('TODO_X2_LUCAS.ObtenerRol') IS NOT NULL
DROP FUNCTION TODO_X2_LUCAS.ObtenerRol;
IF OBJECT_ID('TODO_X2_LUCAS.Obtener_Calificacion') IS NOT NULL
DROP FUNCTION TODO_X2_LUCAS.Obtener_Calificacion;

/**************************************************  CREACION DE TABLAS ***************************************************/
-- CREACION TABLA TIPOS DE PUBLICACIONES -- 
CREATE TABLE TODO_X2_LUCAS.Tipos_Publicaciones ( 
	Cod_Tipos_Publicaciones int PRIMARY KEY CLUSTERED IDENTITY,
	Descripcion_Tipo nvarchar(255)
)
;
-- CREACION TABLA ROLES --
CREATE TABLE TODO_X2_LUCAS.Roles ( 
	Cod_Rol int PRIMARY KEY CLUSTERED IDENTITY,
	Nombre nvarchar(255),
	Estado_Rol bit
)
;
-- CREACION TABLA FUNCIONALIDADES --
CREATE TABLE TODO_X2_LUCAS.Funcionalidades ( 
	Cod_Funcionalidad int PRIMARY KEY CLUSTERED IDENTITY,
	Descripcion_Funcionalidad nvarchar(255)
)
;
--CREACION TABLA FUNCIONALIDADES POR ROL --
CREATE TABLE TODO_X2_LUCAS.Funcionalidades_Por_Rol ( 
	Cod_Rol int REFERENCES TODO_X2_LUCAS.Roles (Cod_Rol),
	Cod_Funcionalidad int REFERENCES TODO_X2_LUCAS.Funcionalidades (Cod_Funcionalidad),
	PRIMARY KEY CLUSTERED(Cod_Rol,Cod_Funcionalidad)
)
;
-- CREACION TABLA USUARIOS --
CREATE TABLE TODO_X2_LUCAS.Usuarios ( 
	Cod_Usuario int PRIMARY KEY CLUSTERED IDENTITY,
	Nombre_Usuario nvarchar(255) NOT NULL,
	Contraseña nvarchar(255) NOT NULL,
	Cod_Rol int REFERENCES TODO_X2_LUCAS.Roles (Cod_Rol),
	Intentos_Login int NOT NULL DEFAULT 0,
	Estado_Usuario bit NOT NULL
)
;
-- CREACION TABLA AUDITORIA LOGIN --
CREATE TABLE TODO_X2_LUCAS.Auditoria_Login (
	Cod_Auditoria int IDENTITY PRIMARY KEY CLUSTERED,
	Usuario_Nombre int  REFERENCES TODO_X2_LUCAS.Usuarios (Cod_Usuario),
	Fecha datetime NOT NULL DEFAULT GETDATE(),
	Estado bit NOT NULL,
	Numero_De_Intento int 
);
-- CREACION TABLA CALIFICACIONES --
CREATE TABLE TODO_X2_LUCAS.Calificaciones ( 
	Cod_Calificacion int PRIMARY KEY CLUSTERED IDENTITY,
	Cantidad_Estrella numeric(18) UNIQUE,
	Peso numeric(18)
)
;
-- CREACION TABLA DOMICILIOS --
CREATE TABLE TODO_X2_LUCAS.Domicilios ( 
	Cod_Domicilio int PRIMARY KEY CLUSTERED IDENTITY,
	Calle nvarchar(255),
	Nro_Calle numeric(18),
	Piso numeric(18),
	Depto nvarchar(50),
	Localidad nvarchar(50)
)
;
-- CREACION TABLA DETALLES DE CLIENTE --
CREATE TABLE TODO_X2_LUCAS.Detalles_Clientes ( 
	Cod_Cliente int IDENTITY PRIMARY KEY CLUSTERED,
	Cod_Usuario int REFERENCES TODO_X2_LUCAS.Usuarios (Cod_Usuario),
	Nombre nvarchar(255) NOT NULL,
	Apellido nvarchar(255) NOT NULL,
	DNI numeric(18) NOT NULL,
	Mail nvarchar(255),
	Telefono numeric(10) ,
	Cod_Domicilio int REFERENCES TODO_X2_LUCAS.Domicilios (Cod_Domicilio),
	Cod_Postal nvarchar(50) NOT NULL,
	Fecha_Nacimiento datetime NOT NULL,
	Fecha_Creacion datetime NOT NULL,
	Estado_Cliente bit NOT NULL
)
;
--CREACION TABLA DETALLES DE UNA EMPRESA --
CREATE TABLE TODO_X2_LUCAS.Detalles_Empresas ( 
	Cod_Empresa int IDENTITY PRIMARY KEY CLUSTERED,
	Cod_Usuario int REFERENCES TODO_X2_LUCAS.Usuarios (Cod_Usuario),
	Razon_Social nvarchar(255) UNIQUE NOT NULL,
	Mail nvarchar(50) NOT NULL,
	Telefono numeric(10) ,
	Cod_Domicilio int REFERENCES TODO_X2_LUCAS.Domicilios (Cod_Domicilio),
	Cod_Postal nvarchar(50) NOT NULL,
	Ciudad nvarchar(255) ,
	CUIT nvarchar(50) NOT NULL UNIQUE,
	Rubro nvarchar(255) ,
	Estado_Empresa bit NOT NULL
)
;
-- CREACION FORMAS DE PAGO --
CREATE TABLE TODO_X2_LUCAS.Formas_De_Pago ( 
	Cod_Formas_De_Pago int IDENTITY PRIMARY KEY CLUSTERED,
	Descripcion_Forma nvarchar(255)
)
;
-- CREACION TABLA FACTURAS --
CREATE TABLE TODO_X2_LUCAS.Facturas ( 
	Cod_Factura int IDENTITY PRIMARY KEY CLUSTERED,
	Nro_Factura numeric(18) ,
	Fecha_Factura datetime NOT NULL,
	Total_Factura numeric(18,2) NOT NULL,
	Vendedor_Correspondiente int REFERENCES TODO_X2_LUCAS.Usuarios(Cod_Usuario),
	Cod_Forma_De_Pago int REFERENCES TODO_X2_LUCAS.Formas_De_Pago(Cod_Formas_De_Pago)
)
;
-- CREACION TALBA ITEMS DE UNA FACTURA--
CREATE TABLE TODO_X2_LUCAS.Items_Facturas ( 
	Cod_Item int IDENTITY PRIMARY KEY CLUSTERED,
	Cod_Factura int REFERENCES TODO_X2_LUCAS.Facturas (Cod_Factura),
	Item_Factura_Cantidad numeric(18),
	Item_Factura_Monto numeric(18,2)
)
;
-- CREACION TABLAS RUBROS --
CREATE TABLE TODO_X2_LUCAS.Rubros ( 
	Cod_Rubro int IDENTITY PRIMARY KEY CLUSTERED,
	Descripcion_Breve nvarchar(50),
	Descripcion_Rubro nvarchar(255) NOT NULL
)
;
-- CREACION TABLA VISIBILIDADES DE UNA PUBLICACION --
CREATE TABLE TODO_X2_LUCAS.Visibilidades_Publicaciones ( 
	Cod_Visibilidad numeric(18) IDENTITY PRIMARY KEY CLUSTERED,
	Descripcion_Visibilidad nvarchar(255) NOT NULL,
	Precio_Visibilidad numeric(18,2) NOT NULL,
	Porcentaje numeric(18,2) NOT NULL,
	Comision_Entregas numeric(18,2)
)
;
-- CREACION TABLA ESTADOS PUBLICACIONES --
CREATE TABLE TODO_X2_LUCAS.Estados_Publicaciones(
	Cod_Estado int IDENTITY PRIMARY KEY,
	Descripcion_Estado nvarchar(255)
)
;
-- CREACION TABLA PUBLICACIONES --
CREATE TABLE TODO_X2_LUCAS.Publicaciones ( 
	Cod_Publicacion int IDENTITY PRIMARY KEY CLUSTERED,
	Cod_Publicacion_Anterior numeric(18) ,
	Descripcion_Publicacion nvarchar(255) NOT NULL,
	Stock_Publicacion numeric(18) NOT NULL,
	Fecha_Publicacion datetime NOT NULL,
	Fecha_Vencimiento_Publicacion datetime NOT NULL,
	Precio_Publicacion numeric(18,2) NOT NULL,
	Cod_Tipos_Publicacion int REFERENCES TODO_X2_LUCAS.Tipos_Publicaciones (Cod_Tipos_Publicaciones),
	Cod_Rubro int REFERENCES TODO_X2_LUCAS.Rubros (Cod_Rubro),
	Cod_Visibilidad numeric(18) REFERENCES TODO_X2_LUCAS.Visibilidades_Publicaciones (Cod_Visibilidad),
	Costo_Publicacion numeric(18,2),
	Cod_Usuario_Responsable int REFERENCES TODO_X2_LUCAS.Usuarios (Cod_Usuario),
	Cod_Estado_Publicacion int REFERENCES TODO_X2_LUCAS.Estados_Publicaciones (Cod_Estado),
	Permiso_Preguntas bit,
	Entregas bit
) 
;
--CREACION TABLA OFERTAS--
CREATE TABLE TODO_X2_LUCAS.Ofertas (
	Cod_Oferta int IDENTITY PRIMARY KEY CLUSTERED,
	Oferta_Fecha datetime,
	Oferta_Monto numeric(18,2),
	Cod_Publicacion int REFERENCES TODO_X2_LUCAS.Publicaciones (Cod_Publicacion),
	Cod_Usuario int REFERENCES TODO_X2_LUCAS.Usuarios (Cod_Usuario)
)
;

--CREACION TABLA COMPRAS--
CREATE TABLE TODO_X2_LUCAS.Compras (
	Cod_Compra int IDENTITY PRIMARY KEY CLUSTERED,
	Compra_Fecha datetime,
	Compra_Cantidad numeric(18),
	Cod_Publicacion int REFERENCES TODO_X2_LUCAS.Publicaciones (Cod_Publicacion),
	Cod_Usuario int REFERENCES TODO_X2_LUCAS.Usuarios (Cod_Usuario),
	Cod_Calificacion int REFERENCES TODO_X2_LUCAS.Calificaciones (Cod_Calificacion),
	Cod_Calificacion_Anterior numeric(18),
	Descripcion nvarchar(255)
)
;

--CREACION TABLA INCONSISTENCIAS_CALIFICACIONES--
CREATE TABLE TODO_X2_LUCAS.Inconsistencias_Calificaciones (
	Codigo_Anterior numeric(18),
	Cantidad_Estrellas numeric(18),
	Descripcion nvarchar(255)
)
;
GO
/************************************************** PROCEDIMIENTOS ALMACENADOS ***************************************************/
/* ------------------------------------ GETTERS ------------------------------------ */
----------------------------- GETTERS TABLA TIPOS DE PUBLICACIONES -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Tipos_De_Publicacion
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Tipos_Publicaciones
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Tipo_De_Publicacion(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Tipos_Publicaciones
		WHERE Cod_Tipos_Publicaciones = @codigo
	END
	GO
----------------------------- GETTERS TABLA ROLES -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Roles
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Roles
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Rol(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Roles
		WHERE Cod_Rol = @codigo
	END
	GO
----------------------------- GETTERS TABLA FUNCIONALIDADES -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Funcionalidades
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Funcionalidades
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Funcionalidad(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Funcionalidades
		WHERE Cod_Funcionalidad = @codigo
	END
	GO
----------------------------- GETTERS TABLA FUNCIONALIDADES POR ROL -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Funcionalidades_Por_Roles
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Funcionalidades_Por_Rol
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Funcionalidades_Por_Rol(@codigoRol int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Funcionalidades_Por_Rol
		WHERE Cod_Rol = @codigoRol 
	END
	GO
----------------------------- GETTERS TABLA USUARIOS -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Usuarios
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Usuarios
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Usuario(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Usuarios
		WHERE Cod_Usuario = @codigo
	END
	GO
----------------------------- GETTERS TABLA CALIFICACIONES -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Calificaciones
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Calificaciones
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Calificacion(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Calificaciones
		WHERE Cod_Calificacion = @codigo
	END
	GO
----------------------------- GETTERS TABLA DOMICILIOS -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Domicilios
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Domicilios
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Domicilio(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Domicilios
		WHERE Cod_Domicilio = @codigo
	END
	GO
----------------------------- GETTERS TABLA CLIENTES -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Clientes
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Detalles_Clientes
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Cliente(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Detalles_Clientes
		WHERE Cod_Cliente = @codigo
	END
	GO
----------------------------- GETTERS TABLA EMPRESAS -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Empresas
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Detalles_Empresas
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Empresa(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Detalles_Empresas
		WHERE Cod_Empresa = @codigo
	END
	GO
----------------------------- GETTERS TABLA FORMAS DE PAGO -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Formas_De_Pago
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Formas_De_Pago
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Forma_De_Pago(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Formas_De_Pago
		WHERE Cod_Formas_De_Pago = @codigo
	END
	GO
----------------------------- GETTERS TABLA FACTURAS -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Facturas
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Facturas
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Factura(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Facturas
		WHERE Cod_Factura = @codigo
	END
	GO
----------------------------- GETTERS TABLA ITEMS DE FACTURA -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Items_De_Facturas
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Items_Facturas
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Item_De_Factura(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Items_Facturas
		WHERE Cod_Item = @codigo
	END
	GO
----------------------------- GETTERS TABLA RUBROS -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Rubros
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Rubros
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Rubro(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Rubros
		WHERE Cod_Rubro = @codigo
	END	
	GO	
----------------------------- GETTERS TABLA VISIBILIDADES DE UNA PUBLICACION -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Visibilidades
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Visibilidades_Publicaciones
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Visibilidad(@codigo numeric(18))
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Visibilidades_Publicaciones
		WHERE Cod_Visibilidad = @codigo
	END
	GO
----------------------------- GETTERS TABLA ESTADOS PUBLICACIONES -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Estados
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Estados_Publicaciones
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Estado(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Estados_Publicaciones
		WHERE Cod_Estado = @codigo
	END
	GO
----------------------------- GETTERS TABLA PUBLICACIONES -----------------------------
-- DATOS TABLA COMPLETA --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Publicaciones
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Publicaciones
	END
	GO
-- DATOS TABLA SEGUN CODIGO --
	CREATE PROCEDURE TODO_X2_LUCAS.Get_Publicacion(@codigo int)
	AS
	BEGIN
		SELECT *
		FROM TODO_X2_LUCAS.Publicaciones
		WHERE Cod_Publicacion = @codigo
	END
	GO

/************************************************** FUNCTIONS ***************************************************/
-- FUNCION PARA OBTENER EL CODIGO DEL ROL DADA SU DESCRIPCION --
CREATE FUNCTION TODO_X2_LUCAS.ObtenerRol(@nombreRol nvarchar(255))
RETURNS int
AS
BEGIN
	DECLARE @CodigoRol int;

	SELECT @CodigoRol = Cod_Rol
	FROM TODO_X2_LUCAS.Roles
	WHERE Nombre = @nombreRol

	RETURN @CodigoRol;
END
GO

-- FUNCION PARA OBTENER EL CODIGO DE UNA FUNCIONALIDAD DADA SU DESCRIPCION --
CREATE FUNCTION TODO_X2_LUCAS.ObtenerFuncionalidad(@DescFuncionalidad nvarchar(255))
RETURNS int
AS
BEGIN
	DECLARE @CodigoFunc int;

	SELECT @CodigoFunc = Cod_Funcionalidad
	FROM TODO_X2_LUCAS.Funcionalidades
	WHERE Descripcion_Funcionalidad = @DescFuncionalidad

	RETURN @CodigoFunc;
END
GO

-- FUNCION PARA OBTENER EL CODIGO DE UN DOMICILIO DADA SU  DESCRIPCION --
CREATE FUNCTION TODO_X2_LUCAS.Obtener_Cod_Domicilio(@calle nvarchar(250),@nroCalle numeric(18),@piso numeric(18),@depto nvarchar(50))
RETURNS INT
AS
BEGIN
	DECLARE @CodDomicilio int;
	SELECT @CodDomicilio = Cod_Domicilio
	FROM TODO_X2_LUCAS.Domicilios
	WHERE Calle = @calle AND Nro_Calle = @nroCalle AND Piso = @piso AND Depto = @depto

	RETURN @codDomicilio;
END
GO

-- FUNCION PARA OBTENER EL CODIGO DE UN USUARIO DADO SU DNI O CUIT --
CREATE FUNCTION TODO_X2_LUCAS.ObtenerUsuario(@dni numeric(18),@cuit nvarchar(50))
RETURNS INT
AS
BEGIN
	DECLARE @codUsuario int;
	IF (@dni IS NOT NULL)
	BEGIN
		SELECT @codUsuario = u.Cod_Usuario
		FROM TODO_X2_LUCAS.Usuarios u JOIN TODO_X2_LUCAS.Detalles_Clientes c ON (c.Cod_Usuario = u.Cod_Usuario)
		WHERE c.DNI = @dni
	END
	ELSE
	BEGIN
		SELECT @codUsuario = u.Cod_Usuario
		FROM TODO_X2_LUCAS.Usuarios u JOIN TODO_X2_LUCAS.Detalles_Empresas e ON (e.Cod_Usuario = u.Cod_Usuario)
		WHERE e.CUIT = @cuit
	END
	RETURN @codUsuario;
END
GO

-- FUNCION PARA OBTENER EL CODIGO DE UNA CALIFICACION DADO UNA CANTIDAD DE ESTRELLAS --
CREATE FUNCTION TODO_X2_LUCAS.Obtener_Calificacion(@cantidad_estrellas numeric(18))
RETURNS INT
AS
BEGIN
	DECLARE @codigoCalificacion int;
	
	SELECT @codigoCalificacion = Cod_Calificacion
	FROM TODO_X2_LUCAS.Calificaciones
	WHERE Cantidad_Estrella = @cantidad_estrellas
			
	RETURN @codigoCalificacion
END
GO
/************************************************** PROCEDIMIENTOS ALMACENADOS ***************************************************/

/* ------------ PROCEDIMIENTO PARA AGREGAR FUNCIONALIDADES ------------ */

CREATE PROCEDURE TODO_X2_LUCAS.Agregar_Funcionalidad(@Funcionalidad nvarchar(255))
AS
BEGIN
	IF NOT EXISTS(SELECT Cod_Funcionalidad FROM TODO_X2_LUCAS.Funcionalidades WHERE Descripcion_Funcionalidad = @Funcionalidad)
	BEGIN
		INSERT INTO TODO_X2_LUCAS.Funcionalidades(Descripcion_Funcionalidad) 
		VALUES(@Funcionalidad)
	END
	ELSE
	BEGIN
		print 'Ya existe la funcionalidad'
		RETURN -1;
	END
END
;
GO

/* ------------ PROCEDIMIENTO PARA AGREGAR ROLES  ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Agregar_Rol(@rol nvarchar(255))
AS
BEGIN
	IF NOT EXISTS (SELECT Cod_Rol FROM TODO_X2_LUCAS.Roles WHERE Nombre = @rol)
	BEGIN
	INSERT INTO TODO_X2_LUCAS.Roles(Nombre ,Estado_Rol)
	VALUES (@rol,1)
	END
	ELSE 
	BEGIN
		print 'Ya existe el rol'
		RETURN -1;
	END
END
;
GO

/* ------------ PROCEDIMIENTO QUE AGREGA LAS FUNCIONALIDADES A UN ROL DETERMINADO ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad(@rol nvarchar(255),@funcionalidad nvarchar(255))
AS
BEGIN
	DECLARE @codRol int,@codFuncionalidad int;
	SET @codFuncionalidad = TODO_X2_LUCAS.ObtenerFuncionalidad(@funcionalidad)
	SET @codRol = TODO_X2_LUCAS.ObtenerRol(@rol)
	IF NOT EXISTS(SELECT Cod_Funcionalidad FROM TODO_X2_LUCAS.Funcionalidades_Por_Rol WHERE Cod_Funcionalidad = @codFuncionalidad AND Cod_Rol = @codRol)
	BEGIN
		INSERT INTO TODO_X2_LUCAS.Funcionalidades_Por_Rol(Cod_Rol,Cod_Funcionalidad)
		VALUES (@codRol,@codFuncionalidad)
	END
	ELSE
	BEGIN 
		print 'El rol ya posee esa funcionalidad'
		RETURN -1;
	END
END
; 
GO
/* ------------ PROCEDIMIENTO PARA QUITAR FUNCIONALIDADES ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Quitar_Funcionalidad_A_Rol(@funcionalidad nvarchar(255), @codRol int)
AS
BEGIN
	DELETE FROM TODO_X2_LUCAS.Funcionalidades_Por_Rol 
	WHERE Cod_Rol = @codRol AND 
			Cod_Funcionalidad = (SELECT Cod_Funcionalidad FROM TODO_X2_LUCAS.Funcionalidades WHERE Descripcion_Funcionalidad = @funcionalidad)

END
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR ROLES  ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Modificar_Nombre_Rol(@rol nvarchar(255),@nuevoNombreRol nvarchar(255))
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM TODO_X2_LUCAS.Roles WHERE Nombre = @nuevoNombreRol)
	BEGIN
		UPDATE TODO_X2_LUCAS.Roles
		SET Nombre = @nuevoNombreRol
		WHERE Nombre = @rol
	END
	ELSE
	BEGIN
		PRINT 'El nombre de rol al que quiere modificar ya existe'
		RETURN -1;
	END
END
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR EL ESTADO DE UN ROL ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Modificar_Estado_Rol(@rol nvarchar(255),@estado bit)
AS
BEGIN
	IF EXISTS (SELECT Cod_Rol FROM TODO_X2_LUCAS.Roles WHERE Nombre = @rol)
	BEGIN
		UPDATE TODO_X2_LUCAS.Roles
		SET Estado_Rol = @estado
		WHERE Nombre = @rol
	END
	ELSE
	BEGIN
		print 'El rol a modificar no existe'
	END
END
GO

/* ------------ PROCEDIMIENTO PARA DAR DE BAJA UN ROL ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Baja_Rol(@rol nvarchar(255))
AS
BEGIN
	IF EXISTS (SELECT Cod_Rol FROM TODO_X2_LUCAS.Roles WHERE Nombre=@rol)
	BEGIN
		--Si el estado del rol esta en 1 esta activo en 0 esta inactivo--
		UPDATE TODO_X2_LUCAS.Roles
		SET Estado_Rol = 0
		WHERE Nombre=@rol
	END
	ELSE
	BEGIN
		print 'El rol que quiere dar de baja no existe'
	END
END
GO

-- PROCEDIMIENTO PARA AGREGAR ALGUN TIPO DE CALIFICACION PARA LAS PUBLICACIONES --
CREATE PROCEDURE TODO_X2_LUCAS.Agregar_Calificacion_Posible(@cantidadEstrellas int)
AS
BEGIN
	INSERT INTO TODO_X2_LUCAS.Calificaciones(Cantidad_Estrella,Peso)
	VALUES(@cantidadEstrellas, @cantidadEstrellas * 10)
END
GO

/* ------------------------------------ PROCEDIMIENTO DE LOGIN  ------------------------------------ */
/* ------------ ACTUALIZA INTENTOS DE LOGIN	------------ */
CREATE PROCEDURE TODO_X2_LUCAS.ActualizarIntentos(@username nvarchar(255),@Cantidad int ) 
AS
BEGIN
	IF (@Cantidad = 0 )
	BEGIN
		DECLARE @IntentosActuales int;
		UPDATE TODO_X2_LUCAS.Usuarios 
		SET Intentos_Login = Intentos_Login + 1 
		WHERE Nombre_Usuario = @username
		
		SELECT @IntentosActuales = Intentos_Login 
		FROM TODO_X2_LUCAS.Usuarios
		WHERE Nombre_Usuario = @username

		INSERT INTO TODO_X2_LUCAS.Auditoria_Login(Usuario_Nombre,Estado,Numero_De_Intento)
		VALUES((SELECT Nombre_Usuario FROM TODO_X2_LUCAS.Usuarios WHERE Nombre_Usuario = @username),0,@IntentosActuales)

		IF (@IntentosActuales >= 3)
		BEGIN	
			UPDATE TODO_X2_LUCAS.Usuarios 
			SET Estado_Usuario = 0 
			WHERE Nombre_Usuario = @username
		END
	END
	ELSE
	BEGIN
		UPDATE TODO_X2_LUCAS.Usuarios 
		SET Intentos_Login = 0 
		WHERE Nombre_Usuario = @username
		
		INSERT INTO TODO_X2_LUCAS.Auditoria_Login(Usuario_Nombre,Estado)
		VALUES((SELECT Nombre_Usuario FROM TODO_X2_LUCAS.Usuarios WHERE Nombre_Usuario= @username),1)
	END
END
GO
/* ------------ PROCEDIMIENTO PARA VALIDAR EL LOGIN ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Validar_Login(@username varchar(255),@password varchar(255)) 
AS
BEGIN
	DECLARE @Cantidad int;

	SELECT @Cantidad = COUNT(Nombre_Usuario) 
	FROM TODO_X2_LUCAS.Usuarios
	WHERE Estado_Usuario = 1 AND
		  Nombre_Usuario = @username AND
		  Contraseña = CONVERT(nvarchar(255),@password)
	
	EXEC TODO_X2_LUCAS.actualizarIntentos @username,@Cantidad
	IF (SELECT Estado_Usuario FROM TODO_X2_LUCAS.Usuarios WHERE Nombre_Usuario = @username) = 1	
	BEGIN
		RETURN @Cantidad
	END
	ELSE
	BEGIN
		RETURN -1;
	END
END
GO

/* ------------ PROCEDIMIENTO PARA ALTA DE UN USUARIO ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Alta_Usuario(@username nvarchar(255),@password nvarchar(255),@rol nvarchar(255))
AS
BEGIN
	IF NOT EXISTS (SELECT Nombre_Usuario FROM TODO_X2_LUCAS.Usuarios WHERE Nombre_Usuario = @username)
	BEGIN
		DECLARE @cod_rol int;
		SET @cod_rol = TODO_X2_LUCAS.ObtenerRol(@rol);

		INSERT INTO TODO_X2_LUCAS.Usuarios(Nombre_Usuario,Contraseña,Cod_Rol)
		VALUES (@username,@password,@cod_rol)
	END
	ELSE
	BEGIN
		PRINT 'YA EXISTE EL NOMBRE DE USUARIO'
		RETURN -1;
	END
END
GO
/* ------------ PROCEDIMIENTO PARA MODIFICAR UN USUARIO ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Modificar_Usuario(@Usuario nvarchar(255),@contraseñaVieja nvarchar(255),@contraseñaNueva nvarchar(255))
AS
BEGIN
	UPDATE TODO_X2_LUCAS.Usuarios
	SET Contraseña = @contraseñaNueva
	WHERE Nombre_Usuario = @Usuario AND Contraseña = @contraseñaVieja
END
GO
/* ------------ PROCEDIMIENTO PARA MODIFICAR UN USUARIO ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Baja_Usuario(@usuario nvarchar(255))
AS
BEGIN
	UPDATE TODO_X2_LUCAS.Usuarios
	SET Estado_Usuario = 0
	WHERE Nombre_Usuario = @usuario
END
GO
/* ------------ PROCEDIMIENTO PARA ALTA DE UN DOMICILIO ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Alta_Domicilio(@calle nvarchar(255),@nro_Calle numeric(18),@piso numeric(18),
												@depto nvarchar(50),@localidad nvarchar(50))
AS
BEGIN
	DECLARE @codDomicilio int;
	
	IF NOT EXISTS (SELECT 1 FROM TODO_X2_LUCAS.Domicilios WHERE Calle = @calle AND Nro_Calle = @nro_Calle AND Piso = @piso AND Depto = @depto)
	BEGIN
		INSERT INTO TODO_X2_LUCAS.Domicilios(Calle,Depto,Nro_Calle,Piso,Localidad)
		VALUES (@calle,@depto,@nro_Calle,@piso,@localidad)
		
		SET @codDomicilio = (SELECT DISTINCT @@IDENTITY FROM TODO_X2_LUCAS.Domicilios);
		RETURN @codDomicilio;
	END
	ELSE
	BEGIN
		SET @codDomicilio = (SELECT Cod_Domicilio FROM TODO_X2_LUCAS.Domicilios WHERE Calle = @calle AND Nro_Calle = @nro_Calle AND Piso = @piso AND Depto = @depto);
		RETURN @codDomicilio;
	END
END
GO
/* ------------ PROCEDIMIENTO PARA ALTA DE UN CLIENTE ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Alta_Cliente(@nombre nvarchar(255),@apellido nvarchar(255),@dni numeric(18),
											@mail nvarchar(255),@telefono numeric(10),@calle nvarchar(255),
											@nro_Calle numeric(18),@piso numeric(18),@depto nvarchar(50),
											@localidad nvarchar(50),@codPostal nvarchar(50),@fechaNacimiento datetime)
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM TODO_X2_LUCAS.Detalles_Clientes WHERE DNI = @dni)
	BEGIN
		DECLARE @codDomicilio int,@codUsuario int;
		SET @codUsuario = TODO_X2_LUCAS.ObtenerUsuario(@dni,NULL);

		EXEC @codDomicilio = TODO_X2_LUCAS.Alta_Domicilio @calle,@nro_Calle,@piso,@depto,@localidad;

		INSERT INTO TODO_X2_LUCAS.Detalles_Clientes(Apellido,Cod_Domicilio,Cod_Postal,Cod_Usuario,DNI,
													Estado_Cliente,Fecha_Creacion,Fecha_Nacimiento,Mail,Nombre,Telefono)
		VALUES (@apellido,@codDomicilio,@codPostal,@codUsuario,@dni,1,GETDATE(),@fechaNacimiento,@mail,@nombre,@telefono)

	END
	ELSE
	BEGIN
		PRINT 'EL DNI YA EXISTE'
		RETURN -1;
	END
END
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR LOS DATOS DE  CLIENTE ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Modificar_Cliente(@dniViejo numeric(18),@nombre nvarchar(255),@apellido nvarchar(255),@dni numeric(18),
											@mail nvarchar(255),@telefono numeric(10),@calle nvarchar(255),
											@nro_Calle numeric(18),@piso numeric(18),@depto nvarchar(50),
											@localidad nvarchar(50),@codPostal nvarchar(50),@fechaNacimiento datetime)
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM TODO_X2_LUCAS.Detalles_Clientes WHERE DNI = @dni)
	BEGIN
		UPDATE TODO_X2_LUCAS.Detalles_Clientes
		SET Nombre = @nombre, Apellido = @apellido, DNI = @dni, Mail = @mail, Telefono = @telefono, 
			Cod_Postal = @codPostal,Fecha_Nacimiento = @fechaNacimiento
		WHERE DNI = @dniViejo

		UPDATE TODO_X2_LUCAS.Domicilios
		SET	Calle = @calle, Nro_Calle = @nro_Calle, Piso = @piso, Depto = @depto, Localidad = @localidad
		WHERE Cod_Domicilio = (SELECT D.Cod_Domicilio 
								FROM TODO_X2_LUCAS.Domicilios D JOIN Detalles_Clientes C ON (D.Cod_Domicilio = C.Cod_Domicilio)
								WHERE C.DNI = @dniViejo)
	END
	ELSE
	BEGIN
		PRINT 'EL DNI NUEVO QUE SE MODIFICO YA EXISTE, NO SE PUEDE REALIZAR LA MODIFICACION'
		RETURN -1;
	END
END
GO
/* ------------ PROCEDIMIENTO PARA ALTA DE UNA EMPRESA ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Alta_Empresa(@razon_Social nvarchar(255),@mail nvarchar(50),@telefono numeric(10),
											@calle nvarchar(255),@nro_Calle numeric(18),@piso numeric(18),@depto nvarchar(50),
											@localidad nvarchar(50),@cod_Postal nvarchar(50),@ciudad nvarchar(255),
											@CUIT nvarchar(50),@rubro nvarchar(255),@estado_Empresa bit)
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM TODO_X2_LUCAS.Detalles_Empresas WHERE CUIT = @CUIT OR Razon_Social = @razon_Social)
	BEGIN
		DECLARE @codDomicilio int,@codUsuario int;
		SET @codUsuario = TODO_X2_LUCAS.ObtenerUsuario(NULL,@CUIT);

		EXEC @codDomicilio = TODO_X2_LUCAS.Alta_Domicilio @calle,@nro_Calle,@piso,@depto,@localidad;

		INSERT INTO TODO_X2_LUCAS.Detalles_Empresas(Ciudad,Cod_Domicilio,Cod_Postal,Cod_Usuario,CUIT,Estado_Empresa,
													Mail,Razon_Social,Rubro)
		VALUES (@ciudad,@codDomicilio,@cod_Postal,@codUsuario,@CUIT,@estado_Empresa,@mail,@razon_Social,@rubro)

	END
	ELSE
	BEGIN
		PRINT 'EL CUIT O LA RAZON SOCIAL YA EXISTEN'
		RETURN -1;
	END
END
GO

/* ------------ PROCEDIMIENTO PARA LA MODIFICACION DE UNA EMPRESA ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Modificar_Empresa(@cuitViejo nvarchar(50),@razonSocialVieja nvarchar(255),@razon_Social nvarchar(255),@mail nvarchar(50),@telefono numeric(10),
											@calle nvarchar(255),@nro_Calle numeric(18),@piso numeric(18),@depto nvarchar(50),
											@localidad nvarchar(50),@cod_Postal nvarchar(50),@ciudad nvarchar(255),
											@CUIT nvarchar(50),@rubro nvarchar(255),@estado_Empresa bit)
AS
BEGIN
	
	IF NOT EXISTS (SELECT * FROM TODO_X2_LUCAS.Detalles_Empresas WHERE CUIT = @CUIT OR Razon_Social = @razonSocialVieja)
	BEGIN

		UPDATE TODO_X2_LUCAS.Detalles_Empresas
		SET Razon_Social = @razon_Social, Mail = @mail, Telefono = @telefono,Cod_Postal = @cod_Postal, Ciudad = @ciudad,
			CUIT = @CUIT, Rubro = @rubro, Estado_Empresa = @estado_Empresa
		WHERE CUIT = @cuitViejo

		UPDATE TODO_X2_LUCAS.Domicilios
		SET	Calle = @calle, Nro_Calle = @nro_Calle, Piso = @piso, Depto = @depto, Localidad = @localidad
		WHERE Cod_Domicilio = (SELECT D.Cod_Domicilio 
							FROM TODO_X2_LUCAS.Domicilios D JOIN Detalles_Empresas E ON (D.Cod_Domicilio = E.Cod_Domicilio)
							WHERE CUIT = @cuitViejo)

	END
	ELSE
	BEGIN
		PRINT 'EL CUIT O LA RAZON SOCIAL NUEVAS MODIFICADAS YA EXISTEN, NO SE PUEDE REALIZAR LA MODIFICACION'
		RETURN -1; 
	END


END
GO
/* ------------ PROCEDIMIENTO PARA ALTA DE LAS VISIBILIDADES DE LAS PUBLICACIONES ------------ */
CREATE PROCEDURE TODO_X2_LUCAS.Alta_Visibilidad(@descripcion nvarchar(255),@precio numeric(18,2),
											@porcentaje numeric(18,2), @entregas numeric(18,2))
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM TODO_X2_LUCAS.Visibilidades_Publicaciones WHERE Descripcion_Visibilidad = @descripcion)
	BEGIN
		INSERT INTO TODO_X2_LUCAS.Visibilidades_Publicaciones(Descripcion_Visibilidad,Porcentaje,Precio_Visibilidad,Comision_Entregas)
		VALUES (@descripcion,@precio,@porcentaje,@entregas)
	END
	ELSE
	BEGIN
		PRINT 'YA EXISTE LA VISIBILIDAD'
		RETURN -1;
	END
END
GO
/************************************************ PROCEDIMIENTOS PARA MIGRACIONES ************************************************/
-- PROCEDIMIENTO PARA LA MIGRACION DE LOS CLIENTES --
CREATE PROCEDURE TODO_X2_LUCAS.MigrarClientes
AS
BEGIN
	DECLARE @apellido nvarchar(255),@nombre nvarchar(255),@dni numeric(18),@mail nvarchar(255),@telefono numeric(10),@codDom int,@codPostal nvarchar(50),
			@fechaNac datetime,@contraseña nvarchar(255),@codRol int,@calle nvarchar(250),@nroCalle numeric(18),@piso numeric(18),
			@depto nvarchar(50),@nombreUsuario nvarchar(250);

	
	DECLARE cursorCliente CURSOR
	FOR
	SELECT DISTINCT Cli_Apeliido,Cli_Cod_Postal,Cli_Dni,Cli_Fecha_Nac,Cli_Mail,Cli_Nombre,
			Cli_Dom_Calle,Cli_Nro_Calle,Cli_Piso,Cli_Depto
	FROM gd_esquema.Maestra
	WHERE Cli_Dni IS NOT NULL

	OPEN cursorCliente
    FETCH NEXT FROM cursorCliente INTO @apellido,@codPostal,@dni,@fechaNac,@mail,@nombre,@calle,@nroCalle,@piso,@depto
		
	SET @contraseña = CONVERT(nvarchar(255),HASHBYTES('SHA2_256','clave temporal'));
	SET @codRol = TODO_X2_LUCAS.ObtenerRol('Cliente');
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @codDom = TODO_X2_LUCAS.Obtener_Cod_Domicilio(@calle,@nroCalle,@piso,@depto);
		SET @nombreUsuario = @apellido + CONVERT(nvarchar(255),@dni);
	
		INSERT INTO TODO_X2_LUCAS.Usuarios(Nombre_Usuario,Contraseña,Cod_Rol,Estado_Usuario)
		VALUES(@nombreUsuario,@contraseña,@codRol,1)
		
		DECLARE @codUsuario int = (SELECT DISTINCT @@IDENTITY FROM TODO_X2_LUCAS.Usuarios);
			
		INSERT INTO TODO_X2_LUCAS.Detalles_Clientes(Cod_Usuario,Nombre,Apellido,DNI,Mail,Telefono,Cod_Domicilio,Cod_Postal,Fecha_Nacimiento,Fecha_Creacion,Estado_Cliente)
		VALUES(@codUsuario,@nombre,@apellido,@dni,@mail,@telefono,@codDom,@codPostal,@fechaNac,GETDATE(),1)

		FETCH NEXT FROM cursorCliente INTO @apellido,@codPostal,@dni,@fechaNac,@mail,@nombre,@calle,@nroCalle,@piso,@depto
	END

	CLOSE cursorCliente
    DEALLOCATE cursorCliente
END
GO

-- PROCEDIMIENTO PARA LA MIGRACION DE LAS EMPRESAS --
CREATE PROCEDURE TODO_X2_LUCAS.MigrarEmpresas
AS
BEGIN
	DECLARE @mail nvarchar(255),@codDom int,@codPostal nvarchar(50),@fechaCreacion datetime,
			@contraseña nvarchar(255),@codRol int, @calle nvarchar(250),@nroCalle numeric(18),@piso numeric(18),
			@depto nvarchar(50),@nombreUsuario nvarchar(250),@cuit nvarchar(50),@razonSocial nvarchar(255);

	
	DECLARE cursorEmpresas CURSOR
	FOR
	SELECT DISTINCT Publ_Empresa_Cod_Postal,Publ_Empresa_Cuit,Publ_Empresa_Depto,Publ_Empresa_Dom_Calle,Publ_Empresa_Fecha_Creacion,Publ_Empresa_Mail,
					Publ_Empresa_Nro_Calle,Publ_Empresa_Piso,Publ_Empresa_Razon_Social
	FROM gd_esquema.Maestra
	WHERE Publ_Empresa_Cuit IS NOT NULL

	OPEN cursorEmpresas
    FETCH NEXT FROM cursorEmpresas INTO @codPostal,@cuit,@depto,@calle,@fechaCreacion,@mail,@nroCalle,@piso,@razonSocial
		
	SET @contraseña = CONVERT(nvarchar(255),HASHBYTES('SHA2_256','clave temporal'));
	SET @codRol = TODO_X2_LUCAS.ObtenerRol('Empresa');
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @codDom = TODO_X2_LUCAS.Obtener_Cod_Domicilio(@calle,@nroCalle,@piso,@depto);
		SET @nombreUsuario = CONVERT(nvarchar(255),@cuit);
	
		INSERT INTO TODO_X2_LUCAS.Usuarios(Nombre_Usuario,Contraseña,Cod_Rol,Estado_Usuario)
		VALUES(@nombreUsuario,@contraseña,@codRol,1)
		
		DECLARE @codUsuario int = (SELECT DISTINCT @@IDENTITY FROM TODO_X2_LUCAS.Usuarios);
			
		INSERT INTO TODO_X2_LUCAS.Detalles_Empresas(Cod_Usuario,Razon_Social,Mail,Cod_Domicilio,
													Cod_Postal,CUIT,Estado_Empresa)
		VALUES(@codUsuario,@razonSocial,@mail,@codDom,@codPostal,@cuit,1)

	    FETCH NEXT FROM cursorEmpresas INTO @codPostal,@cuit,@depto,@calle,@fechaCreacion,@mail,@nroCalle,@piso,@razonSocial
	END

	CLOSE cursorEmpresas
    DEALLOCATE cursorEmpresas
END
GO

-- PROCEDIMIENTO PARA LA MIGRACION DE LAS PUBLICACIONES --
CREATE PROCEDURE TODO_X2_LUCAS.MigrarPublicaciones
AS
BEGIN
	DECLARE @codPublicacion numeric(18),@descripcion nvarchar(255),@codEstado numeric(18),@fechaPublicacion datetime,@fechaVenc datetime,@precio numeric(18,2),
			@codRubro int,@stock numeric(18),@codTipo int,@codVisib numeric(18),@dni numeric(18),@cuit nvarchar(50),@codUsuario int;
	
	DECLARE publicaciones CURSOR FOR
	SELECT DISTINCT Publicacion_Cod,Publicacion_Descripcion,e.Cod_Estado,Publicacion_Fecha,Publicacion_Fecha_Venc,Publicacion_Precio,
			r.Cod_Rubro,Publicacion_Stock,t.Cod_Tipos_Publicaciones,v.Cod_Visibilidad,Publ_Cli_Dni,Publ_Empresa_Cuit
	FROM gd_esquema.Maestra m JOIN TODO_X2_LUCAS.Estados_Publicaciones e ON (m.Publicacion_Estado = e.Descripcion_Estado)
							JOIN TODO_X2_LUCAS.Rubros r ON (m.Publicacion_Rubro_Descripcion = r.Descripcion_Rubro)
							JOIN TODO_X2_LUCAS.Tipos_Publicaciones t ON (m.Publicacion_Tipo = t.Descripcion_Tipo)
							JOIN TODO_X2_LUCAS.Visibilidades_Publicaciones v ON (m.Publicacion_Visibilidad_Cod = v.Cod_Visibilidad)
	WHERE Publicacion_Cod IS NOT NULL

	OPEN publicaciones
	FETCH NEXT FROM publicaciones INTO @codPublicacion,@descripcion,@codEstado,@fechaPublicacion,@fechaVenc,@precio,@codRubro,@stock,@codTipo,@codVisib,@dni,@cuit
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @codUsuario = TODO_X2_LUCAS.ObtenerUsuario(@dni,@cuit);
		
		INSERT INTO TODO_X2_LUCAS.Publicaciones(Cod_Publicacion_Anterior,Descripcion_Publicacion,Stock_Publicacion,Fecha_Publicacion,
						Fecha_Vencimiento_Publicacion,Precio_Publicacion,Cod_Tipos_Publicacion,Cod_Rubro,Cod_Visibilidad,Cod_Usuario_Responsable,
						Cod_Estado_Publicacion)
		VALUES(@codPublicacion,@descripcion,@stock,@fechaPublicacion,@fechaVenc,@precio,@codTipo,@codRubro,@codVisib,@codUsuario,@codEstado)
	
		FETCH NEXT FROM publicaciones INTO @codPublicacion,@descripcion,@codEstado,@fechaPublicacion,@fechaVenc,@precio,@codRubro,@stock,@codTipo,@codVisib,@dni,@cuit
	END

	CLOSE publicaciones
	DEALLOCATE publicaciones
END
GO

/************************************************ MIGRACION DE DATOS ************************************************/
-- MIGRACION TABLA TIPOS DE PUBLICACIONES --

INSERT INTO TODO_X2_LUCAS.Tipos_Publicaciones
SELECT DISTINCT Publicacion_Tipo
FROM gd_esquema.Maestra
WHERE Publicacion_Tipo is not null

-- MIGRACION TABLA ROLES --
EXEC TODO_X2_LUCAS.Agregar_Rol 'Cliente'
EXEC TODO_X2_LUCAS.Agregar_Rol 'Empresa'
EXEC TODO_X2_LUCAS.Agregar_Rol 'Administrador'

-- MIGRACION TABLA FUNCIONALIDADES --
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Alta Rol'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Modificación Rol'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Baja Rol'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Alta Usuario' 
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Modificación Usuario'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Baja Usuario'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Alta Rubro'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Modificación Rubro'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Baja Rubro'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Alta visibilidad de publicación'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Modificación visibilidad de publicación'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Baja visibilidad de publicación'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Generar Publicación'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Comprar/Ofertar'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Historial Cliente'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Calificar al vendedor'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Consulta de facturas realizadas al vendedor'
EXEC TODO_X2_LUCAS.Agregar_Funcionalidad 'Listado Estadístico'

-- MIGRACION TABLA FUNCIONALIDADES POR ROL --
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador', 'Alta Rol'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador', 'Modificación Rol'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador', 'Baja Rol'

EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Alta Usuario'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Modificación Usuario'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Baja Usuario'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Alta visibilidad de publicación'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Modificación visibilidad de publicación'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Baja visibilidad de publicación'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Generar Publicación'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Comprar/Ofertar'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Historial Cliente'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Calificar al vendedor'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Consulta de facturas realizadas al vendedor'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente', 'Listado Estadístico'

EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Alta Usuario'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Modificación Usuario'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Baja Usuario'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Alta visibilidad de publicación'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Modificación visibilidad de publicación'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Baja visibilidad de publicación'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Generar Publicación'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Comprar/Ofertar'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Historial Cliente'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Calificar al vendedor'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Consulta de facturas realizadas al vendedor'
EXEC TODO_X2_LUCAS.Agregar_Rol_Por_Funcionalidad 'Empresa', 'Listado Estadístico'

-- MIGRACION TABLA CALIFICACIONES --
EXEC TODO_X2_LUCAS.Agregar_Calificacion_Posible 1
EXEC TODO_X2_LUCAS.Agregar_Calificacion_Posible 2
EXEC TODO_X2_LUCAS.Agregar_Calificacion_Posible 3
EXEC TODO_X2_LUCAS.Agregar_Calificacion_Posible 4
EXEC TODO_X2_LUCAS.Agregar_Calificacion_Posible 5

-- MIGRACION TABLA DOMICILIOS --
INSERT INTO TODO_X2_LUCAS.Domicilios(Calle,Nro_Calle,Piso,Depto)
SELECT DISTINCT Cli_Dom_Calle,Cli_Nro_Calle,Cli_Piso,Cli_Depto
FROM gd_esquema.Maestra
WHERE Cli_Dom_Calle IS NOT NULL
UNION
SELECT DISTINCT Publ_Cli_Dom_Calle,Publ_Cli_Nro_Calle,Publ_Cli_Piso,Publ_Cli_Depto
FROM gd_esquema.Maestra
WHERE Publ_Cli_Dom_Calle IS NOT NULL
UNION
SELECT DISTINCT Publ_Empresa_Dom_Calle,Publ_Empresa_Nro_Calle,Publ_Empresa_Piso,Publ_Empresa_Depto
FROM gd_esquema.Maestra
WHERE Publ_Empresa_Dom_Calle IS NOT NULL

-- MIGRACION TABLA CLIENTES --
EXEC TODO_X2_LUCAS.MigrarClientes

-- MIGRACION TABLA EMPRESAS --
EXEC TODO_X2_LUCAS.MigrarEmpresas

-- MIGRACION TABLA FORMAS DE PAGO --
INSERT INTO TODO_X2_LUCAS.Formas_De_Pago(Descripcion_Forma)
SELECT DISTINCT Forma_Pago_Desc
FROM gd_esquema.Maestra
WHERE Forma_Pago_Desc IS NOT NULL

--MIGRACION TABLA FACTURAS -- (58726)
INSERT INTO TODO_X2_LUCAS.Facturas(Nro_Factura,Fecha_Factura,Total_Factura,Vendedor_Correspondiente,Cod_Forma_De_Pago)
SELECT DISTINCT Factura_Nro,Factura_Fecha,Factura_Total,u.Cod_Usuario,f.Cod_Formas_De_Pago
FROM gd_esquema.Maestra m JOIN TODO_X2_LUCAS.Detalles_Clientes c  ON (m.Publ_Cli_Dni = c.DNI)
							JOIN TODO_X2_LUCAS.Usuarios u ON (u.Cod_Usuario = c.Cod_Usuario)
							JOIN TODO_X2_LUCAS.Formas_De_Pago f ON (m.Forma_Pago_Desc = f.Descripcion_Forma)
WHERE Factura_Nro IS NOT NULL
	
INSERT INTO TODO_X2_LUCAS.Facturas(Nro_Factura,Fecha_Factura,Total_Factura,Vendedor_Correspondiente,Cod_Forma_De_Pago)
SELECT DISTINCT Factura_Nro,Factura_Fecha,Factura_Total,u.Cod_Usuario,f.Cod_Formas_De_Pago
FROM gd_esquema.Maestra m JOIN TODO_X2_LUCAS.Detalles_Empresas e  ON (m.Publ_Empresa_Cuit = e.CUIT)
							JOIN TODO_X2_LUCAS.Usuarios u ON (u.Cod_Usuario = e.Cod_Usuario)
							JOIN TODO_X2_LUCAS.Formas_De_Pago f ON (m.Forma_Pago_Desc = f.Descripcion_Forma)
WHERE Factura_Nro IS NOT NULL

--MIGRACION TABLA ITEMS FACTURA --
INSERT INTO TODO_X2_LUCAS.Items_Facturas(Cod_Factura,Item_Factura_Cantidad,Item_Factura_Monto)
SELECT f.Cod_Factura,m.Item_Factura_Cantidad,m.Item_Factura_Monto
FROM gd_esquema.Maestra m JOIN TODO_X2_LUCAS.Facturas f ON (m.Factura_Nro = f.Nro_Factura)
WHERE f.Nro_Factura IS NOT NULL

-- MIGRACION TABLA RUBROS --
INSERT INTO TODO_X2_LUCAS.Rubros (Descripcion_Rubro)
SELECT DISTINCT  Publicacion_Rubro_Descripcion
FROM gd_esquema.Maestra

-- MIGRACION TABLA VISIBILIDADES DE PUBLICACIONES --
SET IDENTITY_INSERT TODO_X2_LUCAS.Visibilidades_Publicaciones ON
	INSERT INTO TODO_X2_LUCAS.Visibilidades_Publicaciones(Cod_Visibilidad,Descripcion_Visibilidad,Porcentaje,Precio_Visibilidad)
	SELECT DISTINCT Publicacion_Visibilidad_Cod,Publicacion_Visibilidad_Desc,Publicacion_Visibilidad_Porcentaje,Publicacion_Visibilidad_Precio
	FROM gd_esquema.Maestra
	WHERE Publicacion_Visibilidad_Cod IS NOT NULL
SET IDENTITY_INSERT TODO_X2_LUCAS.Visibilidades_Publicaciones OFF

-- MIGRACION TABLA ESTADOS DE PUBLICACIONES --
INSERT INTO TODO_X2_LUCAS.Estados_Publicaciones
SELECT DISTINCT Publicacion_Estado
FROM gd_esquema.Maestra


-- MIGRACION TABLA PUBLICACIONES --
INSERT INTO TODO_X2_LUCAS.Publicaciones(Cod_Publicacion_Anterior,Descripcion_Publicacion,
										Stock_Publicacion,Fecha_Publicacion,Fecha_Vencimiento_Publicacion,
										Precio_Publicacion,Cod_Tipos_Publicacion,Cod_Rubro,
										Cod_Visibilidad,Cod_Usuario_Responsable,
										Cod_Estado_Publicacion)
SELECT DISTINCT Publicacion_Cod,Publicacion_Descripcion,
				Publicacion_Stock,Publicacion_Fecha,Publicacion_Fecha_Venc,
				Publicacion_Precio,t.Cod_Tipos_Publicaciones,r.Cod_Rubro,
				v.Cod_Visibilidad,Usuario = CASE WHEN Publ_Cli_Dni IS NULL THEN (SELECT Cod_Empresa FROM TODO_X2_LUCAS.Detalles_Empresas WHERE CUIT = Publ_Empresa_Cuit)
												ELSE (SELECT Cod_Cliente FROM TODO_X2_LUCAS.Detalles_Clientes WHERE DNI = Publ_Cli_Dni) END,
				e.Cod_Estado
FROM gd_esquema.Maestra m JOIN TODO_X2_LUCAS.Estados_Publicaciones e ON (m.Publicacion_Estado = e.Descripcion_Estado)
						JOIN TODO_X2_LUCAS.Rubros r ON (m.Publicacion_Rubro_Descripcion = r.Descripcion_Rubro)
						JOIN TODO_X2_LUCAS.Tipos_Publicaciones t ON (m.Publicacion_Tipo = t.Descripcion_Tipo)
						JOIN TODO_X2_LUCAS.Visibilidades_Publicaciones v ON (m.Publicacion_Visibilidad_Cod = v.Cod_Visibilidad)
WHERE Publicacion_Cod IS NOT NULL

--MIGRACION TABLA COMPRAS Y CALIFICACIONES --
INSERT INTO TODO_X2_LUCAS.Compras(Cod_Calificacion_Anterior,Cod_Calificacion,Cod_Usuario,Cod_Publicacion,
									Descripcion,Compra_Cantidad,Compra_Fecha)
SELECT DISTINCT Calificacion_Codigo,TODO_X2_LUCAS.Obtener_Calificacion(Calificacion_Cant_Estrellas) as 'calificacion',
				TODO_X2_LUCAS.ObtenerUsuario(Cli_Dni,NULL) as 'usuario',
				P.Cod_Publicacion,Calificacion_Descripcion,Compra_Cantidad,Compra_Fecha
FROM gd_esquema.Maestra m JOIN TODO_X2_LUCAS.Publicaciones P ON (m.Publicacion_Cod = P.Cod_Publicacion_Anterior)
WHERE Calificacion_Codigo IS NOT NULL AND Calificacion_Cant_Estrellas <= 5

INSERT INTO TODO_X2_LUCAS.Inconsistencias_Calificaciones(Codigo_Anterior,Cantidad_Estrellas,Descripcion)
SELECT DISTINCT Calificacion_Codigo,Calificacion_Cant_Estrellas,Calificacion_Descripcion
FROM gd_esquema.Maestra	
WHERE (Calificacion_Codigo IS NOT NULL) AND ( 5 < Calificacion_Cant_Estrellas )

--MIGRACION TABLA OFERTAS--
INSERT INTO TODO_X2_LUCAS.Ofertas(Oferta_Fecha,Oferta_Monto,Cod_Publicacion,Cod_Usuario)
SELECT DISTINCT Oferta_Fecha,Oferta_Monto,P.Cod_Publicacion,TODO_X2_LUCAS.ObtenerUsuario(Cli_Dni,NULL)
FROM gd_esquema.Maestra M JOIN TODO_X2_LUCAS.Publicaciones P ON (M.Publicacion_Cod=P.Cod_Publicacion_Anterior)
WHERE Oferta_Fecha IS NOT NULL AND Oferta_Monto IS NOT NULL

