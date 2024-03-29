USE [Boromir]
GO
/****** Object:  StoredProcedure [dbo].[proc_datos_escen]    Script Date: 11/10/2011 15:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[proc_datos_escen] (
@ubica numeric (3),
@escen numeric (2),
@chora char (5),
@cdia char (9)
)
as 
declare
@tescen char (2),
@tcosto char (2),
@nombre_tescen char (30),
@cobro numeric (1),
@valor money

delete tbl_datos_escen_reser

-- preguntamos si maneja costo por tabla 
select @cobro =  ncobro_ubica 
from tbl_ubicaciones 
where ncodigo_ubica = @ubica


if @cobro <> 1 -- sino 
begin 

select  @tescen = ctipo_escen ,@nombre_tescen = cnombre_escen , @tcosto = ccod_tcosto_tescen
from tbl_escenarios, tbl_tescenarios 
where ncodigo_escen = @escen and ctipo_escen = ccodigo_tescen AND ncod_ubica_escen = @ubica

select @valor = mvalor_tcosto --traemos el valor que esta asignado directo al escenario
from  tbl_tipocosto
where ccodigo_tcosto = @tcosto

insert into tbl_datos_escen_reser -- insertamos par ahacer la consulta  esta tabla en aplicacion
(ccod_tescen_der,cnombre_tescen_der, ccod_tcosto_der, mvalor_tcosto_der)
values
(@tescen,@nombre_tescen,@tcosto,@valor)

End

if  @cobro <> 0 -- si, si vamos y hacemos la consulta a la tabla
begin 

select  @tescen = ctipo_escen ,@nombre_tescen = cnombre_tescen 
from tbl_escenarios, tbl_tescenarios 
where ncodigo_escen = @escen and ctipo_escen = ccodigo_tescen and ncod_ubica_escen = @ubica

select @tcosto = ccod_tcosto_costurno ---CONSULTAMOS EL TIPO DE COSTO
from tbl_costoturno 
where ncod_ubica_costurno = @ubica and
ccod_tescen_costurno =  @tescen and
chora_costurno = @chora and
cdia_costurno = @cdia

select @valor = mvalor_tcosto --traemos el valor que esta asignado AL TIPO DE COSTO CONSULTADO ARRIBA
from  tbl_tipocosto
where ccodigo_tcosto = @tcosto

insert into tbl_datos_escen_reser
(ccod_tescen_der,cnombre_tescen_der, ccod_tcosto_der, mvalor_tcosto_der)
values
(@tescen,@nombre_tescen,@tcosto,@valor)
end
