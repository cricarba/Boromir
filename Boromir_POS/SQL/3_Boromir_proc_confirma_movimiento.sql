USE [Boromir]
GO
/****** Object:  StoredProcedure [dbo].[proc_confirma_movimiento]    Script Date: 02/27/2012 16:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[proc_confirma_movimiento]
(@numero numeric,@concepto char (2),
@ubicacion numeric (3))
as
declare
@accion varchar (6),
@neto numeric,
@descuento numeric,
@impuesto numeric,
@total numeric,
@producto numeric (38),
@ubicadetalle numeric (3),
@cantidad numeric (6),
@registro numeric,
@aplicacion varchar (5),
@estado char (2),
@combo char (2),
@componente numeric (13),
@ctd_componente numeric,
@consecutivo_factu numeric (38),
@consecutivo_pedid numeric (38),
@fecha_movim varchar (50),
@precio_movim  numeric (38), 
@descuento_movim  numeric (38),
@impuesto_movim  numeric (38),
@tercero_cotiz numeric (10),
@tercero_pedid numeric (10),
@saldo numeric (38)
begin tran
select @accion = caccion_conce, @aplicacion = ccod_aplic_conce
from tbl_conceptos 
where @concepto = ccodigo_conce 

select @neto = SUM(nprecio_detmovim),@descuento =  SUM(ndescuento_detmovim),@impuesto = SUM(nimpuesto_detmovim)
from tbl_detalle_movimientos 
where ncod_movim_detmovim = @numero 
and ncod_ubica_detmovim = @ubicacion
and ccod_conce_detmovim = @concepto 
select @total = @neto + @impuesto - @descuento 

Declare cur_producto cursor
for
select ncod_produ_detmovim,ncod_ubica_detmovim,ncantidad_detmovim,
       nprecio_detmovim,ndescuento_detmovim,nimpuesto_detmovim
from tbl_detalle_movimientos 
where ncod_movim_detmovim = @numero 
and ncod_ubica_detmovim = @ubicacion
and ccod_conce_detmovim = @concepto 

if @aplicacion = 'COTIZ'
begin
		  		
		  SELECT @estado = ccod_estad_cotiz,@fecha_movim= ffecha_cotiz,@tercero_cotiz = ncod_terce_cotiz
		  from tbl_cotizaciones
		  where ncodigo_cotiz = @numero 
		  and ncod_ubic_cotiz = @ubicacion
		  and ccod_conce_cotiz = @concepto 
	  
	      if @estado = 'AC'
			update tbl_cotizaciones
			set ndescuento_cotiz = @descuento,nimpuesto_cotiz = @impuesto ,nneto_cotiz= @neto , ntotal_cotiz= @total, ccod_estad_cotiz = 'CF'
			where ncodigo_cotiz = @numero 
			and ncod_ubic_cotiz = @ubicacion
			and ccod_conce_cotiz  = @concepto 
	    
	   
		  if @estado IN ('AN','CF')
		  BEGIN
		    RAISERROR ('%s',16,1,'Documento no esta activo')
		    rollback
			return 1
		  END
		  
     select @consecutivo_pedid =  MAX(ncodigo_pedid) + 1 from tbl_pedidos

        insert into tbl_pedidos (ncodigo_pedid,ccod_conce_pedid,ncod_ubic_pedid,ncod_terce_pedid,ffecha_pedid,
        nneto_pedid,ndescuento_pedid,nimpuesto_pedid,ntotal_pedid,ccod_estad_pedid)
		values (@consecutivo_pedid,'PD',@ubicacion,@tercero_cotiz,@fecha_movim,
        @neto,@descuento,@impuesto,@total,'AC')  

     open cur_producto
		fetch next from cur_producto
		into @producto,@ubicadetalle,@cantidad,@precio_movim,@descuento_movim,@impuesto_movim
		while @@fetch_status = 0
        begin
           
             
         insert into tbl_detalle_movimientos (ncod_movim_detmovim,ccod_conce_detmovim,ncod_ubica_detmovim,ffecha_detmovim,
                     ncod_produ_detmovim,ncantidad_detmovim,nprecio_detmovim,ndescuento_detmovim,nimpuesto_detmovim) 
               values (@consecutivo_pedid,'PD',@ubicadetalle,@fecha_movim,
                        @producto, @cantidad,@precio_movim,@descuento_movim,@impuesto_movim)
                        
                                                         
       fetch next from cur_producto
    into @producto,@ubicadetalle,@cantidad,@precio_movim,@descuento_movim,@impuesto_movim
    end
    Close cur_producto
   end
  
if @aplicacion = 'PEDID'
begin

		  SELECT @estado = ccod_estad_pedid,@fecha_movim= ffecha_pedid,@tercero_pedid = ncod_terce_pedid 
		  from tbl_pedidos
		  where ncodigo_pedid = @numero 
		  and ncod_ubic_pedid = @ubicacion
		  and ccod_conce_pedid = @concepto 
	  
	      if @estado = 'AC'
			update tbl_pedidos
			set ndescuento_pedid = @descuento,nimpuesto_pedid = @impuesto ,nneto_pedid= @neto , ntotal_pedid= @total, ccod_estad_pedid = 'CF'
			where ncodigo_pedid = @numero 
			and ncod_ubic_pedid = @ubicacion
			and ccod_conce_pedid  = @concepto 
	    
	   
		  if @estado IN ('AN','CF')
		  BEGIN
		    RAISERROR ('%s',16,1,'Documento no esta activo')
		    rollback
			return 1
		  END
		  
     select @consecutivo_factu =  MAX(ncodigo_factu) + 1 from tbl_facturas
       insert into tbl_facturas (ncodigo_factu,ccod_conce_factu,ncod_ubic_factu,ncod_terce_factu,ffecha_factu,
                       nneto_factu,ndescuento_factu,nimpuesto_factu,ntotal_factu,ccod_estad_factu)
                 values (@consecutivo_factu,'FV',@ubicacion,@tercero_pedid,@fecha_movim,
                        @neto,@descuento,@impuesto,@total,'AC')  
     open cur_producto
		fetch next from cur_producto
		into @producto,@ubicadetalle,@cantidad,@precio_movim,@descuento_movim,@impuesto_movim
		while @@fetch_status = 0
        begin
                   
         insert into tbl_detalle_movimientos (ncod_movim_detmovim,ccod_conce_detmovim,ncod_ubica_detmovim,ffecha_detmovim,
                     ncod_produ_detmovim,ncantidad_detmovim,nprecio_detmovim,ndescuento_detmovim,nimpuesto_detmovim) 
               values (@consecutivo_factu,'FV',@ubicadetalle,@fecha_movim,
                        @producto, @cantidad,@precio_movim,@descuento_movim,@impuesto_movim)                        
        
                                                  
       fetch next from cur_producto
    into @producto,@ubicadetalle,@cantidad,@precio_movim,@descuento_movim,@impuesto_movim
    end
    Close cur_producto
   end
   
IF @aplicacion = 'FACTU'
	begin
		  SELECT @estado = ccod_estad_factu
		  from tbl_facturas
		  where ncodigo_factu = @numero 
		  and ncod_ubic_factu = @ubicacion
		  and ccod_conce_factu  = @concepto 
	  
	      if @estado = 'AC'
			update tbl_facturas
			set ndescuento_factu = @descuento,nimpuesto_factu = @impuesto ,nneto_factu= @neto , ntotal_factu= @total, ccod_estad_factu = 'CF'
			where ncodigo_factu = @numero 
			and ncod_ubic_factu = @ubicacion
			and ccod_conce_factu  = @concepto 
	    
	   
		  if @estado IN ('AN','CF')
		  BEGIN
		    RAISERROR ('%s',16,1,'Documento no esta activo')
		    rollback
			return 1
		  END
	end
 
IF @aplicacion = 'MOVIM'
  begin
		  SELECT @estado = ccod_estad_moviprodu
		  from tbl_movimiento_producto 
		  where ncodigo_moviprodu = @numero 
		  and ncod_ubica_moviprodu = @ubicacion
		  and ccod_conce_moviprodu = @concepto
     
		 if @estado = 'AC'
		   update tbl_movimiento_producto
		   set ndescuento_moviprodu = @descuento,nimpuesto_moviprodu = @impuesto ,nneto_moviprodu= @neto , ntotal_moviprodu= @total ,ccod_estad_moviprodu = 'CF'
		   where ncodigo_moviprodu = @numero 
		   and ncod_ubica_moviprodu = @ubicacion
		   and ccod_conce_moviprodu  = @concepto 
	   
		 if @estado in ('AN','CF')
		  BEGIN
		    RAISERROR ('%s',16,1,'Documento no esta activo')
		    rollback
			return 1
		  END 
   end   
 
  
if @accion = 'SUMA'
  begin
		open cur_producto
		fetch next from cur_producto
		into @producto,@ubicadetalle,@cantidad,@precio_movim,@descuento_movim,@impuesto_movim
		while @@fetch_status = 0
        begin
			select  @combo = ccombo_produ
			from tbl_productos
			where ncodigo_produ = @producto

			if @combo = 'SI'
			    begin 
					   Declare cur_componente cursor
					   for
					   select ncod_componente_combo,ncantidad_componente_combo
					   from tbl_combos
					   where ncodigo_combo= @producto 
					    --if @@ROWCOUNT >  0 
						 begin
							 open cur_componente
							 fetch next from cur_componente
							 into @componente, @ctd_componente
							 while @@fetch_status = 0
						     begin
								    select @registro = COUNT (*)
									from tbl_saldos
									where ncod_produ_saldo = @componente
									and ncod_ubica_saldo = @ubicadetalle
									and ncantidad_saldo >= 0
								
									if @registro = 1
									 begin
										 update tbl_saldos
										 set ncantidad_saldo = ncantidad_saldo - (@ctd_componente * @cantidad ) 
										 where ncod_produ_saldo = @componente
										 and ncod_ubica_saldo = @ubicadetalle
									 end--CIERRA REGISTRO 1
						
									 if @registro = 0
									  begin
										  raiserror ('%s',16,1, 'COMPONENTE  NO TIENE SALDO')
										  rollback
										  RETURN 1
									  end --CIERRA REGISTRO 0
							 
								fetch next from cur_componente
								into @componente, @ctd_componente
							  end-- CIERRA CURSOS COMPONENTE
					          Close cur_componente
					     end--CIERRA ROWS COUNT
					     
				select @registro = COUNT (*)
				from tbl_saldos
				where ncod_produ_saldo = @producto
				and ncod_ubica_saldo = @ubicadetalle
				and ncantidad_saldo >= 0
			    
				if @registro = 1
				 begin
					  update tbl_saldos
					  set ncantidad_saldo = ncantidad_saldo + @cantidad
					  where ncod_produ_saldo = @producto
					  and ncod_ubica_saldo = @ubicadetalle
				 end--CIERRA REGISTRO 1
			    
				if @registro = 0
				 begin
					  insert into tbl_saldos
					  (ncod_produ_saldo,ncod_ubica_saldo,ncantidad_saldo)
					  values
					  (@producto,@ubicadetalle,@cantidad)
				 end--CIERRA REGISTRO 0  
				 deallocate cur_componente	     
			   end --CIERRA COMBO SI
			
  
			if @combo = 'NO'
			  BEGIN
				select @registro = COUNT (*)
				from tbl_saldos
				where ncod_produ_saldo = @producto
				and ncod_ubica_saldo = @ubicadetalle
				and ncantidad_saldo >= 0
			    
				if @registro = 1
				 begin
					  update tbl_saldos
					  set ncantidad_saldo = ncantidad_saldo + @cantidad
					  where ncod_produ_saldo = @producto
					  and ncod_ubica_saldo = @ubicadetalle
				 end--CIERRA REGISTRO 1
			    
				if @registro = 0
				 begin
					  insert into tbl_saldos
					  (ncod_produ_saldo,ncod_ubica_saldo,ncantidad_saldo)
					  values
					  (@producto,@ubicadetalle,@cantidad)
				 end--CIERRA REGISTRO 0  
			   END--CIERRA COMBO NO
     
	   fetch next from cur_producto
	   into @producto,@ubicadetalle,@cantidad,@precio_movim,@descuento_movim,@impuesto_movim
	   END-- CIERRA CURSOS PRODUCTO
       close cur_producto
  end-- BEGIN SUMA


if @accion = 'RESTA'
 begin
    open cur_producto
    fetch next from cur_producto
    into @producto,@ubicadetalle,@cantidad,@precio_movim,@descuento_movim,@impuesto_movim
    while @@fetch_status = 0
    begin
		select @saldo = ncantidad_saldo 
		from tbl_saldos
		where ncod_produ_saldo = @producto
		and ncod_ubica_saldo = @ubicadetalle
		and ncantidad_saldo >= 0
	    
		if @saldo > 0
		 begin
		  update tbl_saldos
		  set ncantidad_saldo = ncantidad_saldo - @cantidad
		  where ncod_produ_saldo = @producto
				and ncod_ubica_saldo = @ubicadetalle
		 end
    
		if @saldo = 0
		 begin
		  raiserror ('%s',16,1, 'PRODUCTO NO TIENE EXISTENCIAS EN LA TABLA DE SALDOS (Movimientos --> Saldos)')
		  rollback
		  RETURN 1
		 end
		 
	fetch next from cur_producto
    into @producto,@ubicadetalle,@cantidad,@precio_movim,@descuento_movim,@impuesto_movim
    end
    Close cur_producto
 end

 deallocate cur_producto
   
commit
   
   