USE [Boromir]
GO
/****** Object:  StoredProcedure [dbo].[proc_detalles_movimientos]    Script Date: 01/16/2012 11:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_detalles_movimientos]
(@movimiento numeric,
@concepto char (2),
@producto numeric,
@ubicacion numeric,
@fecha varchar (50),
@cantidad_recibida numeric (15),
@precio_compra numeric (30),
@impuesto_compra numeric,
@descuento_compra numeric,	
@accion varchar (10)
)
as
declare
@registros numeric,
@cantidad_producto numeric,
@cantidad_total numeric,
@cantidad_detalle numeric,
@descuento_total numeric,
@impuesto_total numeric,
@precio_total numeric,
@descuento numeric,
@impuesto numeric,
@precio numeric,
@total numeric,
@neto numeric,
@neto_ttl numeric,
@descuento_ttl numeric,
@impuesto_ttl numeric,
@total_ttl numeric,
@app varchar (5)

select @app =ccod_aplic_conce
from tbl_conceptos 
where ccodigo_conce = @concepto

select @registros = count(*)--averiguamos si el registro ya existe en el detalle
from tbl_detalle_movimientos
where ncod_movim_detmovim = @movimiento
and ccod_conce_detmovim =@concepto
and ncod_produ_detmovim = @producto
and ncod_ubica_detmovim = @ubicacion 


select @cantidad_detalle = ncantidad_detmovim  --traemos la cantidad actual del detalle
from tbl_detalle_movimientos
where ncod_movim_detmovim = @movimiento
and ccod_conce_detmovim =@concepto
and ncod_produ_detmovim = @producto
and ncod_ubica_detmovim = @ubicacion 

select @precio = nprecio_venta_produ,@descuento = ndescuento_produ,
@impuesto = nimpuesto_produ --- traemos los valores por producto
from tbl_productos 
where ncodigo_produ = @producto 
              

if @app <> 'MOVIM'
begin
	select @precio_total = @precio * @cantidad_recibida
	select @impuesto_total = @precio_total * (@impuesto / 100) 
	select @descuento_total = @precio_total * (@descuento / 100)
end

if @app = 'MOVIM'
Begin
    select @precio_total = @precio_compra * @cantidad_recibida
	select @impuesto_total = @precio_total * (@impuesto_compra / 100) 
	select @descuento_total = @precio_total * (@descuento_compra / 100)
end

if @accion = 'agregar' 
begin  
	
	if @registros = 1 --si existe registro le sumamos al mismo
	begin
	update tbl_detalle_movimientos
	set ncantidad_detmovim = @cantidad_detalle + @cantidad_recibida,
	    nprecio_detmovim = @precio_total +  nprecio_detmovim ,
	    ndescuento_detmovim = @descuento_total + ndescuento_detmovim,
	    nimpuesto_detmovim = @impuesto_total + nimpuesto_detmovim
	where ncod_movim_detmovim = @movimiento
    and ccod_conce_detmovim =@concepto
    and ncod_produ_detmovim = @producto
    and ncod_ubica_detmovim = @ubicacion
    end
    
	if @registros = 0 -- sino, lo agregamos
	begin
	insert into tbl_detalle_movimientos
	(ncod_movim_detmovim,ccod_conce_detmovim,ncod_ubica_detmovim,ffecha_detmovim,ncod_produ_detmovim,ncantidad_detmovim,nprecio_detmovim,ndescuento_detmovim,nimpuesto_detmovim)
	values
	(@movimiento,@concepto,@ubicacion,@fecha,@producto,@cantidad_recibida,@precio_total,@descuento_total,@impuesto_total)
	end
end	

if @accion = 'eliminar'
begin
    if @registros = 0 -- sino existe enviamos mensje que no esta en detalle
	begin
	raiserror ('%s',16,1, 'Producto no esta en el detalle')
	return 1
	end
	
	if @registros = 1 and @cantidad_detalle < @cantidad_recibida -- si hay menos productos en el detalle
	begin
	raiserror ('%s',16,1, 'Hay menos productos  en el detalle')
	return 1
	end 
	
	
    if @registros = 1 and @cantidad_detalle = @cantidad_recibida -- si es la misma cantidad
	begin
	delete tbl_detalle_movimientos
	where ncod_movim_detmovim = @movimiento
and ccod_conce_detmovim =@concepto
and ncod_produ_detmovim = @producto
and ncod_ubica_detmovim = @ubicacion
   end
    
	if @registros = 1 and @cantidad_detalle >= 2  and @cantidad_detalle > @cantidad_recibida-- si existe le restamos uno
	begin
	update tbl_detalle_movimientos
	set ncantidad_detmovim = @cantidad_detalle - @cantidad_recibida,
	    nprecio_detmovim =  nprecio_detmovim -@precio_total ,
	    ndescuento_detmovim =  ndescuento_detmovim - @descuento_total ,
	    nimpuesto_detmovim = nimpuesto_detmovim - @impuesto_total 
	where ncod_movim_detmovim = @movimiento
    and ccod_conce_detmovim =@concepto
    and ncod_produ_detmovim = @producto
    and ncod_ubica_detmovim = @ubicacion
    end
    
    if @registros = 1 and @cantidad_detalle = 1-- si existe con un solo item
	begin
	delete tbl_detalle_movimientos
	where ncod_movim_detmovim = @movimiento
    and ccod_conce_detmovim =@concepto
    and ncod_produ_detmovim = @producto
    and ncod_ubica_detmovim = @ubicacion
    end 
end    
--**************ACTUALIZAR EL VALOR TOTAL DEL DOCUMENTO

            select @neto_ttl = SUM(nprecio_detmovim),@descuento_ttl =  SUM(ndescuento_detmovim),@impuesto_ttl = SUM(nimpuesto_detmovim)
            from tbl_detalle_movimientos 
			where ncod_movim_detmovim = @movimiento 
			and ncod_ubica_detmovim = @ubicacion
			and ccod_conce_detmovim = @concepto 
			
			IF 	@neto_ttl IS null
			select @neto_ttl = 0
			IF 	@descuento_ttl IS null
			select @descuento_ttl = 0
			IF 	@impuesto_ttl IS null
			select @impuesto_ttl = 0
					
			select @total_ttl = @neto_ttl + @impuesto_ttl - @descuento_ttl 
			
			if @app = 'COTIZ'
			begin            
            update tbl_cotizaciones
			set ndescuento_cotiz = @descuento_ttl,nimpuesto_cotiz = @impuesto_ttl ,nneto_cotiz= @neto_ttl , ntotal_cotiz = @total_ttl
			where ncodigo_cotiz = @movimiento 
			and ncod_ubic_cotiz = @ubicacion
			and ccod_conce_cotiz  = @concepto 
			end
			
			if @app = 'MOVIM'
			begin      
            update tbl_movimiento_producto 
			set ndescuento_moviprodu = @descuento_ttl,nimpuesto_moviprodu = @impuesto_ttl ,nneto_moviprodu = @neto_ttl , ntotal_moviprodu = @total_ttl
			where ncodigo_moviprodu = @movimiento 
			and ncod_ubica_moviprodu = @ubicacion
			and ccod_conce_moviprodu  = @concepto 
			end
			
			if @app = 'FACTU'
			begin      
            update tbl_facturas 
			set ndescuento_factu= @descuento_ttl,nimpuesto_factu = @impuesto_ttl ,nneto_factu = @neto_ttl , ntotal_factu = @total_ttl
			where ncodigo_factu = @movimiento 
			and ncod_ubic_factu = @ubicacion
			and ccod_conce_factu  = @concepto 
			end
			
		    if @app = 'ORDEN'
			begin      
            update tbl_ordenes 
			set ndescuento_orden= @descuento_ttl,nimpuesto_orden = @impuesto_ttl ,nneto_orden = @neto_ttl , ntotal_orden = @total_ttl
			where ncodigo_orden = @movimiento 
			and ncod_ubic_orden = @ubicacion
			and ccod_conce_orden  = @concepto 
			end
			