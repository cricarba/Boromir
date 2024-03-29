USE [Boromir]
GO
/****** Object:  StoredProcedure [dbo].[proc_crea_fact_reser]    Script Date: 11/09/2011 10:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_crea_fact_reser]
AS 
declare
@ncodigo_factu numeric (38),
@ncod_ubic_factu numeric (3),
@ncod_terce_factu numeric (10),
@ccod_estad_factu char (2),
@ccod_concep_factu char (2),
@nescenario_reser_detfactu numeric (2) ,
@hhora_reser_detfactu char (5),
@ffecha_factu  varchar (50),
@ccod_tcosto_reser char (1),
@neto_total_factu numeric (38),
@impuesto numeric,
@descuento numeric

select @ncodigo_factu = ncodigo_reser ,
@ncod_ubic_factu = ncod_ubic_reser,
@ncod_terce_factu = ncod_terce_reser,
@ffecha_factu = ffecha_reser,
@nescenario_reser_detfactu = ncod_escen_reser,
@hhora_reser_detfactu = hhora_reser,
@ccod_tcosto_reser = ccod_tcosto_reser
from tbl_reservas
where ncodigo_reser =(select MAX(ncodigo_reser) from tbl_reservas)

select @neto_total_factu = mvalor_tcosto
from tbl_tipocosto 
where ccodigo_tcosto = @ccod_tcosto_reser

select @impuesto = nimpuesto_produ,
@descuento = ndescuento_produ
from tbl_productos
where ncodigo_produ = 9999

insert into tbl_facturas
(ncodigo_factu,ncod_ubic_factu,ncod_terce_factu,ffecha_factu,ccod_conce_factu,ccod_estad_factu,nneto_factu,ndescuento_factu,nimpuesto_factu,ntotal_factu) 
values
(@ncodigo_factu,@ncod_ubic_factu,@ncod_terce_factu,@ffecha_factu,'FR','AC',@neto_total_factu ,0,0,@neto_total_factu )

insert into tbl_detalle_movimientos
(ncod_movim_detmovim,ccod_conce_detmovim,ncod_ubica_detmovim,ffecha_detmovim ,ncod_produ_detmovim,ncantidad_detmovim,nprecio_detmovim,ndescuento_detmovim,nimpuesto_detmovim)
values
(@ncodigo_factu,'FR',@ncod_ubic_factu,@ffecha_factu,9999,1,@neto_total_factu,@descuento,@impuesto)
---------------------
