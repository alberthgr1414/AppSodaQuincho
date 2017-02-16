-----------------------------------------------
------Elimina Base de Datos Soda Quincho-------
-----------------------------------------------
IF EXISTS(SELECT * FROM DBO.SYSDATABASES    ---
WHERE                                       ---
NAME = 'DBSodaQuincho')                     ---
    BEGIN                                   ---
      USE master;                           ---
      DROP DATABASE DBSodaQuincho;          ---  
    END                                     ---
-----------------------------------------------
-----------------------------------------------

-----------------------------------------------
------Creacion Base de Datos Soda Quincho------
-----------------------------------------------
use master;                                 ---
go                                          ---
CREATE DATABASE DBSodaQuincho;              ---
go                                          ---
use DBSodaQuincho;                          ---
set dateformat dmy;                         ---                                            
-----------------------------------------------
-----------------------------------------------


-----------------------------------------------
------------Tabla Establecimiento--------------
-----------------------------------------------
CREATE TABLE Establecimiento                ---
(                                           ---
ID_Establecimiento int IDENTITY(1,1)        ---
PRIMARY KEY,                                ---
Nombre_Establecimiento varchar(50),         ---
Telefono numeric(8,0),                      ---
Direccion varchar(100)                      ---
)                                           ---
-----------------------------------------------
-----------------------------------------------


-----------------------------------------------
------------Tabla Establecimiento--------------
-----------------------------------------------
CREATE TABLE PC                             ---
(                                           ---
ID_PC nvarchar(100)                         ---
PRIMARY KEY,                                ---
Mac_Adress varchar(100)                     ---
)                                           ---
-----------------------------------------------
-----------------------------------------------

-----------------------------------------------
-----------------Tabla Turno-------------------
-----------------------------------------------
CREATE TABLE Turno                          ---
(                                           ---
ID_Turno int IDENTITY(1,1) PRIMARY KEY,     ---
ID_Usuario int,                             ---
Apertura Datetime,                          ---
Cierre Datetime,                            ---
Fondo Decimal,                              ---
Estado bit                                  ---
)                                           ---
-----------------------------------------------

-----------------------------------------------
------------------Tabla Caja-------------------
-----------------------------------------------
CREATE TABLE Caja                           ---
(                                           ---
ID_Caja int IDENTITY(1,1) PRIMARY KEY,      ---
ID_Usuario int,                             ---
Apertura Datetime,                          ---
Cierre Datetime,                            ---
Fondo Decimal,                              ---
ID_PC nvarchar(100),                        ---
Estado bit                                  ---
)                                           ---
-----------------------------------------------

-----------------------------------------------
----------------Tabla TipoUsuario--------------
-----------------------------------------------
CREATE TABLE TipoUsuario                    ---
(                                           ---
ID_TipoUsuario int                          ---
PRIMARY KEY,                                ---
Descripcion varchar(50)                     ---
)                                           ---                  
-----------------------------------------------
-----------------------------------------------


-----------------------------------------------
----------------Tabla Usuario------------------
-----------------------------------------------
CREATE TABLE Usuario                        ---
(                                           ---
ID_Usuario int IDENTITY(1,1)                ---
PRIMARY KEY,                                ---
ID_TipoUsuario int,                         ---
ID_Establecimiento int,                     ---
Nombre_Usuario varchar(50),                 ---
Contrasenna varchar(50),                    ---
)                                           ---
-----------------------------------------------
-----------------------------------------------


-----------------------------------------------
----------------Tabla Mesa---------------------
-----------------------------------------------
CREATE TABLE Mesa                           ---
(                                           ---
ID_Mesa int IDENTITY(1,1) PRIMARY KEY,      ---
ID_EncFactura int,                          ---
Num_Mesa numeric(2,0)                       ---
)                                           ---
-----------------------------------------------
-----------------------------------------------

                                             
-----------------------------------------------          
----------------Tabla TipoPlato----------------          
-----------------------------------------------          
CREATE TABLE TipoPlato                      ---          
(                                           ---
ID_TipoPlato int IDENTITY(1,1)              ---
PRIMARY KEY,                                ---
Descripcion nvarchar(30),                   ---
)                                           ---
-----------------------------------------------
-----------------------------------------------


-----------------------------------------------
------------------Tabla Plato------------------
-----------------------------------------------
CREATE TABLE Plato                          ---
(                                           ---
ID_Plato int IDENTITY(1,1)                  ---
PRIMARY KEY,                                ---
ID_TipoPlato int,                           ---
Nombre_Plato nvarchar(30),                  ---
Precio_Plato Decimal,                       ---
foto image not null                         ---
)                                           ---
-----------------------------------------------
-----------------------------------------------


-----------------------------------------------
----------------Tabla Express------------------
-----------------------------------------------
CREATE TABLE Express                        ---
(                                           ---
ID_Express int IDENTITY(1,1) PRIMARY KEY,   ---
ID_EncFactura int,                          ---
ID_Empleado int,                            ---
ID_Zona int,                                ---
Total_Express Decimal                       ---
)                                           ---
-----------------------------------------------
-----------------------------------------------



-----------------------------------------------
--------------Tabla EncFactura-----------------
-----------------------------------------------
CREATE TABLE EncFactura                     ---
(                                           ---
ID_EncFactura int IDENTITY(1,1) PRIMARY KEY,---
ID_Turno int,                               ---
ID_Caja int,                                ---
Fecha Datetime,                             ---
Total Decimal,                              ---
ID_EstadoEncFactura int                     ---
)                                           ---
-----------------------------------------------
-----------------------------------------------

-----------------------------------------------
--------------Tabla EstadoEncFactuar-----------
-----------------------------------------------
CREATE TABLE EstadoEncFactura               ---
(                                           ---
ID_EstadoEncFactura int PRIMARY KEY,        ---
NombreEstado nvarchar(100)                  ---
)                                           ---
-----------------------------------------------
-----------------------------------------------


-----------------------------------------------
--------------Tabla DetFactura-----------------
-----------------------------------------------
CREATE TABLE DetFactura                     ---
(                                           ---
ID_DetFactura int IDENTITY(1,1) PRIMARY KEY,---
ID_EncFactura int,                          ---
ID_Plato int,                               ---
Cantidad int,                               ---
Total Decimal                               ---
)                                           ---
-----------------------------------------------
-----------------------------------------------


-------------------------------------------------------------------------------------------------------------------------
----------------------------------------------LLAVES FOREANES------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------


-------------------------------------Usuario-TipoUsuario-----------------------------------------------------------------
ALTER TABLE Usuario ADD                                                                                               ---
CONSTRAINT FK_Usuario_TipoUsuario FOREIGN KEY (ID_TipoUsuario) REFERENCES TipoUsuario(ID_TipoUsuario)                 ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------Usuario-Establecimiento-------------------------------------------------------------
ALTER TABLE Usuario ADD                                                                                               ---
CONSTRAINT FK_Usuario_Establecimiento FOREIGN KEY (ID_Establecimiento) REFERENCES Establecimiento(ID_Establecimiento) ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------Plato-TipoPlato---------------------------------------------------------------------
ALTER TABLE Plato ADD                                                                                                 ---
CONSTRAINT FK_Plato_TipoPlato FOREIGN KEY (ID_TipoPlato) REFERENCES TipoPlato(ID_TipoPlato)                           ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------DetFactura-EncFactura---------------------------------------------------------------
ALTER TABLE DetFactura ADD                                                                                            ---
CONSTRAINT FK_DetFactura_EncFactura FOREIGN KEY (ID_EncFactura) REFERENCES EncFactura(ID_EncFactura)                  ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------DetFactura-Plato--------------------------------------------------------------------
ALTER TABLE DetFactura ADD                                                                                            ---
CONSTRAINT FK_EncFactura_Plato FOREIGN KEY (ID_Plato) REFERENCES Plato(ID_Plato)                                      ---
-------------------------------------------------------------------------------------------------------------------------

--------------------------------------Turno-Usuario----------------------------------------------------------------------
ALTER TABLE Turno ADD                                                                                                 ---
CONSTRAINT FK_Turno_Usuario FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario)                                   ---
-------------------------------------------------------------------------------------------------------------------------

--------------------------------------EncFactura-Turno-------------------------------------------------------------------
ALTER TABLE EncFactura ADD                                                                                            ---
CONSTRAINT FK_EncFactura_Turno FOREIGN KEY (ID_Turno) REFERENCES Turno(ID_Turno)                                      ---
-------------------------------------------------------------------------------------------------------------------------

------------------------------------- EncFactura-Caja  ------------------------------------------------------------------
ALTER TABLE EncFactura ADD                                                                                            ---
CONSTRAINT FK_EncFactura_Caja  FOREIGN KEY (ID_Caja) REFERENCES Caja(ID_Caja)                                         ---
-------------------------------------------------------------------------------------------------------------------------

-----------------------------------------Caja-Usuario--------------------------------------------------------------------
ALTER TABLE Caja ADD                                                                                                  ---
CONSTRAINT FK_Caja_Usuario  FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario)                                   ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------Express-EncFactura------------------------------------------------------------------
ALTER TABLE Express ADD                                                                                               ---
CONSTRAINT FK_Express_EncFactura FOREIGN KEY (ID_EncFactura) REFERENCES EncFactura(ID_EncFactura)                     ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------Mesa-EncFactura---------------------------------------------------------------------
ALTER TABLE Mesa ADD                                                                                                  ---
CONSTRAINT FK_Mesa_EncFactura FOREIGN KEY (ID_EncFactura) REFERENCES EncFactura(ID_EncFactura)                        ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------Caja-PC-----------------------------------------------------------------------------
ALTER TABLE Caja ADD                                                                                                  ---
CONSTRAINT FK_Caja_PC FOREIGN KEY (ID_PC) REFERENCES PC(ID_PC)                                                        ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------EncFactura-EstadoEncFactura---------------------------------------------------------------
ALTER TABLE EncFactura ADD                                                                                                  ---
CONSTRAINT FK_EncFactura_EstadoEncFactura FOREIGN KEY (ID_EstadoEncFactura) REFERENCES EstadoEncFactura(ID_EstadoEncFactura)---
-------------------------------------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------





-------------------------------------------------------------------------------------------------------------------------
----------------------------------------------INSERTS TABLAS-------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------


-------------------------------------Establecimiento-Insert--------------------------------------------------------------
insert into Establecimiento values('Soda Quincho',24162537,'800 metros noroeste del templo catolico de Jaris')      ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------TipoUsuario-Insert------------------------------------------------------------------
insert into TipoUsuario values(1,'Administrador')                                                                     ---
insert into TipoUsuario values(2,'Gerente')                                                                           ---
insert into TipoUsuario values(3,'Colaborador')                                                                       ---
insert into TipoUsuario values(4,'Express')                                                                           ---
-------------------------------------------------------------------------------------------------------------------------

-----------------------------------------Usuario-Insert------------------------------------------------------------------
insert into Usuario values(1,1,'Admin','123')                                                                         ---
-------------------------------------------------------------------------------------------------------------------------

INSERT INTO PC (ID_PC,Mac_Adress) VALUES ('Caja1','Caja 1')


---------------------------------------------Mesa-Insert-------------------------------------------------------------------
--insert into Mesa values(1)                                                                                            ---
--insert into Mesa values(2)                                                                                            ---     
--insert into Mesa values(3)                                                                                            ---     
--insert into Mesa values(4)                                                                                            ---     
--insert into Mesa values(5)                                                                                            ---     
--insert into Mesa values(6)                                                                                            ---     
--insert into Mesa values(7)                                                                                            ---     
--insert into Mesa values(8)                                                                                            ---    
---------------------------------------------------------------------------------------------------------------------------

-------------------------------------TipoPlato-Insert--------------------------------------------------------------------
insert into TipoPlato values('Menu Regular')                                                                          ---
insert into TipoPlato values('Postres')                                                                               ---
insert into TipoPlato values('Bebidas')                                                                               ---
insert into TipoPlato values('Helados')                                                                               ---
insert into TipoPlato values('Adiconales')                                                                            ---
-------------------------------------------------------------------------------------------------------------------------


-------------------------------------turno-Insert------------------------------------------------------------------------
INSERT INTO Turno VALUES(1,'12-12-12','12-12-12',60000,1)                                                             ---
INSERT INTO Turno VALUES(1,'12-12-12','12-12-12',60000,1)                                                             ---
-------------------------------------------------------------------------------------------------------------------------

-------------------------------------EsadosEncFactura-Insert-------------------------------------------------------------
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(1,'En Facturacion')                  ---
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(2,'En Mesa')                         ---
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(3,'En Express')                      ---
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(4,'Comer Aqui Facturado')            ---
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(5,'Llevar Facturado')                ---
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(6,'Mesa Facturado')                  ---
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(7,'Express Facturado')               ---
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(8,'Comida Empleado')                 ---
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(9,'Promo Todo')                      ---
INSERT INTO [dbo].[EstadoEncFactura]([ID_EstadoEncFactura],[NombreEstado])VALUES(10,'Editar Mesa')                    ---
-------------------------------------------------------------------------------------------------------------------------





/* --------------------------------------------------------------- */
/* SpPlatoListar                                                   */
/* Procedimiento para Lista       de Platos                        */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpPlatoListar', 'P') is not null
   drop procedure SpPlatoListar;
go

CREATE PROCEDURE SpPlatoListar
@TipoPlato AS int
AS
BEGIN
SELECT ID_Plato
      ,tp.Descripcion
      ,Nombre_Plato
      ,Precio_Plato
      ,foto
  FROM Plato p, TipoPlato tp where p.ID_TipoPlato = @TipoPlato and 
  p.ID_TipoPlato = tp.ID_TipoPlato;
  END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */

/* --------------------------------------------------------------- */
/* SpPlatoListarScalar                                             */
/* Procedimiento para Listar un Plato                              */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               
if OBJECT_ID ('SpPlatoListarScalar', 'P') is not null
   drop procedure SpPlatoListarScalar;
go
CREATE PROCEDURE SpPlatoListarScalar
@ID_Plato AS int
AS
BEGIN
SELECT Nombre_Plato
      ,Precio_Plato
  FROM Plato where ID_Plato = @ID_Plato
  END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpPlatoListar                                                   */
/* Procedimiento para Modificar Platos                             */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpPlatoActualizar', 'P') is not null
   drop procedure SpPlatoActualizar;
go
CREATE PROCEDURE SpPlatoActualizar
@ID_Plato AS INT,
@ID_TipoPlato AS INT,
@Nombre_Plato AS NVARCHAR(60),
@Precio_Plato AS DECIMAL(18,0),
@foto AS IMAGE
AS
BEGIN
UPDATE Plato
SET ID_TipoPlato = @ID_TipoPlato,
Nombre_Plato = @Nombre_Plato,
Precio_Plato = @Precio_Plato,
foto = @foto
WHERE ID_Plato = @ID_Plato
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpPlatoInsertar                                                 */
/* Procedimiento para Insertar Platos                              */
/* --------------------------------------------------------------- */


use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpPlatoInsertar', 'P') is not null
   drop procedure SpPlatoInsertar;
go

CREATE PROCEDURE SpPlatoInsertar
@ID_TipoPlato AS INT,
@Nombre_Plato AS NVARCHAR(60),
@Precio_Plato AS DECIMAL(18,0),
@foto AS IMAGE
AS
BEGIN
INSERT INTO Plato (ID_TipoPlato,Nombre_Plato,Precio_Plato,foto)
VALUES (@ID_TipoPlato,@Nombre_Plato,@Precio_Plato,@foto)
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */



/* --------------------------------------------------------------- */
/* SpTipoPlatoListar                                               */
/* Procedimiento para Lista Tipos de Platos                        */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               
if OBJECT_ID ('SpTipoPlatoListar', 'P') is not null
   drop procedure SpTipoPlatoListar;
go
CREATE PROCEDURE SpTipoPlatoListar
AS
BEGIN
SELECT ID_TipoPlato,
Descripcion
FROM TipoPlato
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */




/* --------------------------------------------------------------- */
/* SpTipoUsuarioListar                                             */
/* Procedimiento para Lista Tipos de Usuarios                      */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               
if OBJECT_ID ('SpTipoUsuarioListar', 'P') is not null
   drop procedure SpTipoUsuarioListar;
go
CREATE PROCEDURE SpTipoUsuarioListar
AS
BEGIN
SELECT ID_TipoUsuario,
Descripcion
FROM TipoUsuario
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */



/* --------------------------------------------------------------- */
/* SpNuevoEncFactura                                               */
/* Procedimiento para Insertar Encabezado Factura                  */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpNuevoEncFactura', 'P') is not null
   drop procedure SpNuevoEncFactura;
go

CREATE PROCEDURE SpNuevoEncFactura
@ID_Empleado AS INT,
@Fecha AS datetime
AS
BEGIN
INSERT INTO [dbo].[EncFactura]
           ([Fecha])
     VALUES
           (
            @Fecha)
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */

/* --------------------------------------------------------------- */
/* SpUsuarioLogin                                               */
/* Procedimiento para Lista el usuario login                       */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpUsuarioLogin', 'P') is not null
   drop procedure SpUsuarioLogin;
go

CREATE PROCEDURE SpUsuarioLogin
@Nombre_Usuario AS NVARCHAR(50),
@Contrasenna AS NVARCHAR(50)
AS
BEGIN
SELECT [ID_Usuario]
      ,[ID_TipoUsuario]
      ,[ID_Establecimiento]
      ,[Nombre_Usuario]
      ,[Contrasenna]
  FROM [dbo].[Usuario] where Nombre_Usuario=@Nombre_Usuario and Contrasenna = @Contrasenna
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpPlatoInsertar                                                 */
/* Procedimiento para Insertar Platos                              */
/* --------------------------------------------------------------- */


use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpPlatoInsertar', 'P') is not null
   drop procedure SpPlatoInsertar;
go

CREATE PROCEDURE SpPlatoInsertar
@ID_TipoPlato AS INT,
@Nombre_Plato AS NVARCHAR(60),
@Precio_Plato AS DECIMAL(18,0),
@foto AS IMAGE
AS
BEGIN
INSERT INTO Plato (ID_TipoPlato,Nombre_Plato,Precio_Plato,foto)
VALUES (@ID_TipoPlato,@Nombre_Plato,@Precio_Plato,@foto)
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpTurnoListar                                                   */
/* Procedimiento para ultimo turno                                 */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpTurnoListar', 'P') is not null
   drop procedure SpTurnoListar;
go

CREATE PROCEDURE SpTurnoListar
AS
BEGIN

SELECT ID_Turno
      ,ID_Usuario
      ,Apertura
      ,Cierre
      ,Estado
  FROM Turno where ID_Turno = (SELECT MAX(ID_Turno) from Turno) and Estado = 1

END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpTurnoCerrar                                                   */
/* Procedimiento para Cerrar Turno                                 */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpTurnoCerrar', 'P') is not null
   drop procedure SpPlatoActualizar;
go
CREATE PROCEDURE SpTurnoCerrar
AS
Begin
UPDATE Turno
   SET Cierre = GETDATE()
      ,Estado = 0
 WHERE ID_Turno = (SELECT MAX(ID_Turno) from Turno)
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpTurnoAbrir                                                    */
/* Procedimiento para Abre Turno                                   */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpTurnoAbrir', 'P') is not null
   drop procedure SpTurnoAbrir;
go
CREATE PROCEDURE SpTurnoAbrir
@ID_Usuario AS int,
@Fondo AS int
AS
Begin

INSERT INTO [dbo].[Turno]
           ([ID_Usuario]
           ,[Apertura]
		   ,[Fondo]
           ,[Estado])
     VALUES
	 (@ID_Usuario,GETDATE(),@Fondo,1)

END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpCajaListar                                                    */
/* Procedimiento para ultima Caja                                  */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpCajaListar', 'P') is not null
   drop procedure SpCajaListar;
go

CREATE PROCEDURE SpCajaListar
AS
BEGIN
SELECT [ID_Caja]
      ,[ID_Usuario]
      ,[Apertura]
      ,[Cierre]
      ,[Fondo]
      ,[Estado]
  FROM Caja where ID_Caja = (SELECT MAX(ID_Caja) from Caja) and
  Estado = 1

END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpCajaCerrar                                                    */
/* Procedimiento para Cerrar Caja                                  */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpCajaCerrar', 'P') is not null
   drop procedure SpCajaCerrar;
go
CREATE PROCEDURE SpCajaCerrar
AS
Begin
UPDATE Caja
   SET Cierre = GETDATE()
      ,Estado = 0
 WHERE ID_Caja = (SELECT MAX(ID_Caja) from Caja)
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpCajaAbrir                                                     */
/* Procedimiento para Abre Caja                                    */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpCajaAbrir', 'P') is not null
   drop procedure SpCajaAbrir;
go
CREATE PROCEDURE SpCajaAbrir
@ID_Usuario AS int,
@Fondo AS int
AS
Begin
INSERT INTO [dbo].[Caja]
           ([ID_Usuario]
           ,[Apertura]
           ,[Fondo]
		   ,[ID_PC]
           ,[Estado])
     VALUES
           (@ID_Usuario,GETDATE(),@Fondo,'Caja1',1)
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpCaja                                                          */
/* Procedimiento para Abre Caja                                    */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpCaja', 'P') is not null
   drop procedure SpCaja;
go
CREATE PROCEDURE SpCaja
AS
Begin
SELECT [ID_Caja]
  FROM Caja where ID_Caja = (SELECT MAX(ID_Caja) from Caja) and
  Estado = 1
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpTurno                                                          */
/* Procedimiento para Abre Caja                                    */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpTurno', 'P') is not null
   drop procedure SpTurno;
go
CREATE PROCEDURE SpTurno
AS
Begin
SELECT [ID_Turno]
  FROM Turno where ID_Turno = (SELECT MAX(ID_Turno) from Turno) and
  Estado = 1
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpEncFactura                                                    */
/* Procedimiento Nueva Factura                                     */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpEncFactura', 'P') is not null
   drop procedure SpEncFactura;
go
CREATE PROCEDURE SpEncFactura
AS
Begin
SELECT [ID_EncFactura]
  FROM EncFactura where ID_EncFactura = (SELECT MAX(ID_EncFactura) from EncFactura) and
  ID_EstadoEncFactura = 1
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpNuevoEncFactura                                                 */
/* Procedimiento para Insertar Platos                              */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpNuevoEncFactura', 'P') is not null
   drop procedure SpNuevoEncFactura;
go

CREATE PROCEDURE SpNuevoEncFactura
@ID_Turno AS INT,
@ID_Caja AS int,
@Estado AS int
AS
BEGIN
INSERT INTO [dbo].[EncFactura]
           ([ID_Turno]
           ,[ID_Caja]
           ,[Fecha]
		   ,[Total]
           ,[ID_EstadoEncFactura])
     VALUES
           (@ID_Turno,
           @ID_Caja,
          GETDATE(),
		  0,
          1)
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */

/* --------------------------------------------------------------- */
/* SpEncFacturaListar                                              */
/* Procedimiento para ultima Factura                               */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpEncFacturaListar', 'P') is not null
   drop procedure SpEncFacturaListar;
go

CREATE PROCEDURE SpEncFacturaListar
@ID_EstadoEncFactura AS INT
AS
BEGIN
SELECT [ID_EncFactura]
      ,[ID_Turno]
      ,[ID_Caja]
      ,[Fecha]
      ,[Total]
      ,[ID_EstadoEncFactura]
  FROM EncFactura where ID_EncFactura = (SELECT MAX(ID_EncFactura) from EncFactura) and
  ID_EstadoEncFactura = @ID_EstadoEncFactura

END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */

/* --------------------------------------------------------------- */
/* SpNuevoDetFactura                                               */
/* Procedimiento para Crear Nuevo Detalle de Factura               */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpNuevoDetFactura', 'P') is not null
   drop procedure SpNuevoDetFactura;
go
CREATE PROCEDURE SpNuevoDetFactura
@ID_EncFactura AS int,
@ID_Plato AS int,
@Cantidad AS int
AS
Begin
INSERT INTO [dbo].[DetFactura]
           ([ID_EncFactura]
           ,[ID_Plato]
           ,[Cantidad]
           ,[Total])
     VALUES
           (@ID_EncFactura,
            @ID_Plato,
            @Cantidad,
            (select Precio_Plato from Plato where ID_Plato=@ID_Plato)*(@Cantidad))

END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */

/* --------------------------------------------------------------- */
/* SpDetFacturaListar                                              */
/* Procedimiento para todos Detallles                              */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpDetFacturaListar', 'P') is not null
   drop procedure SpDetFacturaListar;
go
CREATE PROCEDURE SpDetFacturaListar
@ID_EncFactura AS int
AS
BEGIN
SELECT [ID_DetFactura],[Cantidad],
        P.Nombre_Plato,
       [Total]
  FROM DetFactura D, Plato P where D.ID_EncFactura = @ID_EncFactura and P.ID_Plato=D.ID_Plato
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpDetFacturaSum                                                 */
/* Procedimiento para todos Detallles Sumar                        */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpDetFacturaSum', 'P') is not null
   drop procedure SpDetFacturaSum;
go
CREATE PROCEDURE SpDetFacturaSum
@ID_EncFactura AS int
AS
BEGIN
SELECT Sum([Total]) As Total
  FROM DetFactura where ID_EncFactura=@ID_EncFactura 
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */


/* --------------------------------------------------------------- */
/* SpEliminarDetFactura                                            */
/* Procedimiento para Eliminar Detalles                            */
/* --------------------------------------------------------------- */
use DBSodaQuincho                                                    
go                                                               

if OBJECT_ID ('SpEliminarDetFactura', 'P') is not null
   drop procedure SpEliminarDetFactura;
go
CREATE PROCEDURE SpEliminarDetFactura
@ID_EncFactura AS int,
@ID_DetFactura AS int
AS
BEGIN
DELETE FROM [dbo].[DetFactura]
      WHERE ID_EncFactura = @ID_EncFactura and ID_DetFactura = @ID_DetFactura
END
GO
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */

/* --------------------------------------------------------------- */
/* SpBackupDb                                                      */
/* Procedimiento crear Backup Base de Datos                        */
/* --------------------------------------------------------------- */
if OBJECT_ID ('SpBackupDb', 'P') is not null
   drop procedure SpBackupDb;
go
create procedure SpBackupDb
as
BACKUP DATABASE [DBSodaQuincho] TO  
DISK =N'C:\Users\Alberth\Dropbox\copia\test.bak'
WITH NOFORMAT, NOINIT,  
NAME = N'DBSodaQuincho-Completa Base de datos Copia de seguridad', 
SKIP,NOREWIND, NOUNLOAD,  STATS = 10
/* --------------------------------------------------------------- */
/* --------------------------------------------------------------- */

/*SELECT * FROM TipoUsuario where ID_TipoUsuario = 
(SELECT MAX(ID_TipoUsuario) from TipoUsuario)*/
/*select net_address from sysprocesses where spid = @@SPID*/

