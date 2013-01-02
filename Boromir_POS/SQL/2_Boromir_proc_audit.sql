USE [Boromir]
GO
/****** Object:  StoredProcedure [dbo].[proc_auditoria]    Script Date: 12/27/2011 10:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_auditoria] (@usuario varchar (30),
@accion varchar (30),
@app varchar (30),
@descripcion varchar (500),
@fecha varchar (50)
)
as

insert into tbl_auditoria
(ncod_usua_audi,
cnombre_aplic_audi,
caccion_audi,
cdescripcion_audi,
ffecha_audi)
values
(@usuario,
@app,
@accion,
@descripcion,
@fecha)

