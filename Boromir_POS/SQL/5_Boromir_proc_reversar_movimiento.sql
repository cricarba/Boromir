USE [Boromir]
GO
/****** Object:  StoredProcedure [dbo].[proc_reversar_movimiento]    Script Date: 02/27/2012 16:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_reversar_movimiento] (
@numero numeric,
@concepto char (2),
@ubicacion numeric (3))
as
declare
@producto numeric,
@cantidad numeric,
@ubicadetalle numeric,
@aplic varchar (5),
@accion char (6),
@saldo numeric (38),
@estado char (2),
@combo char (2),
@componente numeric (13),
@registro numeric,
@ctd_componente numeric,
@error varchar (500)

begin tran
Declare cur_producto cursor
  for
  select ncod_produ_detmovim,ncod_ubica_detmovim,ncantidad_detmovim
  from tbl_detalle_movimientos 
  where ncod_movim_detmovim = @numero 
  and ncod_ubica_detmovim = @ubicacion
  and ccod_conce_detmovim = @concepto 
     
  select @accion = caccion_conce, @aplic = ccod_aplic_conce
  from tbl_conceptos
  where ccodigo_conce = @concepto 
 
  
  if @aplic = 'FACTU'
  begin
   select @estado = ccod_estad_factu
   from tbl_facturas
   where ncodigo_factu = @numero
   and ccod_conce_factu = @concepto
   and ncod_ubic_factu = @ubicacion 
   
    if @estado in  ('AC','AN')
    begin
		raiserror ('%s',16,1, 'La Factura no esta Confirmada')
		deallocate cur_producto
		rollback
		return 1
    end
    
  if  @estado = 'CF'
    begin  
	  update tbl_facturas
	  set nneto_factu = 0,
	  ndescuento_factu = 0,
	  nimpuesto_factu = 0,
	  ntotal_factu = 0,
	  ccod_estad_factu = 'AC'
	  where 
	  ncodigo_factu = @numero
	  and ncod_ubic_factu = @ubicacion 
	  and ccod_conce_factu = @concepto 
  end
end

  If @aplic = 'MOVIM'
  begin
   open cur_producto
    fetch next from cur_producto
    into @producto,@ubicadetalle,@cantidad
    while @@fetch_status = 0
    begin  
	  select @saldo = ncantidad_saldo
	  from tbl_saldos
	  where ncod_produ_saldo = @producto
		   if @saldo < @cantidad
			 begin 
			   select @error = 'El Producto ' + convert(varchar,@producto) + ' no tiene saldo suficiente' 
			   rollback
			   raiserror ('%s',16,1, @error)
			   return 1
					--- deallocate cur_producto
			 end
	  fetch next from cur_producto
      into @producto,@ubicadetalle,@cantidad
     end
    close cur_producto 
    end
    
  begin
  select @estado = ccod_estad_moviprodu
  from tbl_movimiento_producto 
  where ncodigo_moviprodu = @numero
  and ncod_ubica_moviprodu = @ubicacion
  and ccod_conce_moviprodu = @concepto 
  
  if @estado in  ('AC','AN')
    begin
		raiserror ('%s',16,1, 'El movimiento  no esta Confirmado')
		 deallocate cur_producto
		 rollback
		return 1
    end
    
  if  @estado = 'CF'
  begin  
  update tbl_movimiento_producto
  set nneto_moviprodu = 0,
   ndescuento_moviprodu = 0,
  nimpuesto_moviprodu = 0,
  ntotal_moviprodu = 0,
  ccod_estad_moviprodu = 'AC'
  where 
  ncodigo_moviprodu = @numero
  and ncod_ubica_moviprodu = @ubicacion 
  and ccod_conce_moviprodu = @concepto 
  end
 end 
 
if @accion = 'SUMA'
BEGIN  
    open cur_producto
    fetch next from cur_producto
    into @producto,@ubicadetalle,@cantidad
    while @@fetch_status = 0
    begin 		
     		               
     		select  @combo = ccombo_produ
			from tbl_productos
			where ncodigo_produ = @producto

			if @combo = 'SI' and @aplic = 'MOVIM'
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
										 set ncantidad_saldo = ncantidad_saldo + (@ctd_componente * @cantidad ) 
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
					  set ncantidad_saldo = ncantidad_saldo - @cantidad
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
    
    if @combo = 'NO' or (@combo = 'SI' and @aplic = 'FACTU')
			  BEGIN
				  update tbl_saldos
				  set ncantidad_saldo = ncantidad_saldo - @cantidad
				  where ncod_produ_saldo = @producto
				  and ncod_ubica_saldo = @ubicadetalle
			  end
			   fetch next from cur_producto
					 into @producto,@ubicadetalle,@cantidad
					 end
					 close cur_producto
END
 


if @accion = 'RESTA'
BEGIN
    open cur_producto
    fetch next from cur_producto
    into @producto,@ubicadetalle,@cantidad
    while @@fetch_status = 0
    begin
	update tbl_saldos
		set ncantidad_saldo = ncantidad_saldo + @cantidad
		where ncod_produ_saldo = @producto
		and ncod_ubica_saldo = @ubicadetalle
     
	 fetch next from cur_producto
    into @producto,@ubicadetalle,@cantidad
      end
    close cur_producto
END
 
 IF @concepto = 'FR'
 BEGIN
   UPDATE tbl_reservas
   set ccod_estad_reser = 'AC'
   where ncodigo_reser = @numero 
   and ncod_ubic_reser = @ubicacion  
   end
 deallocate cur_producto
commit
	