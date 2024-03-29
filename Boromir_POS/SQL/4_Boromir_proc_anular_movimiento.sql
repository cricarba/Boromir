USE [Boromir]
GO
/****** Object:  StoredProcedure [dbo].[proc_anular_movimiento]    Script Date: 11/25/2011 11:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_anular_movimiento](
@numero numeric,
@concepto char (2),
@ubicacion numeric (3))
as declare
@estado char (2),
@estadofac char (2),
@aplic varchar (5) 
begin tran
 select @aplic = ccod_aplic_conce
  from tbl_conceptos
  where ccodigo_conce = @concepto   
  
  if @aplic = 'FACTU'
   Begin
	   select @estado = ccod_estad_factu
	   from tbl_facturas 
	   where ncodigo_factu = @numero
	   and ccod_conce_factu = @concepto
	   and ncod_ubic_factu = @ubicacion 
		if @estado = 'AC'
		 begin
		   UPDATE tbl_facturas 
		   set ccod_estad_factu = 'AN'
		   where ncodigo_factu = @numero
		   and ccod_conce_factu = @concepto
		   and ncod_ubic_factu = @ubicacion 
		   
		   if @concepto = 'FR'
		    begin
		      UPDATE tbl_reservas 
		      set ccod_estad_reser  = 'AN'
		      where ncodigo_reser = @numero
	          and ncod_ubic_reser = @ubicacion 
		    end
		    
	    end
	    
	    if @estado in  ('CF','AN')
	    BEGIN
	    raiserror ('%s',16,1,'La Factura debe estar Activa')
	    rollback
	    return 1
	    END
    end
   
   if @aplic = 'MOVIM'
   Begin
	   select @estado = ccod_estad_moviprodu 
	   from tbl_movimiento_producto  
	   where ncodigo_moviprodu = @numero
	   and ccod_conce_moviprodu = @concepto
	   and ncod_ubica_moviprodu = @ubicacion 
		if @estado = 'AC'
		 begin
		   UPDATE tbl_movimiento_producto 
		   set ccod_estad_moviprodu  = 'AN'
		   where ncodigo_moviprodu = @numero
		   and ccod_conce_moviprodu = @concepto
		   and ncod_ubica_moviprodu = @ubicacion 
	    end
	    
	    if @estado in  ('CF','AN')
	    BEGIN
	    raiserror ('%s',16,1,'El Movimiento debe estar Activo')
	    rollback
	    return 1
	    END
    end
    
if @concepto = 'RV'
    begin
       select @estadofac = ccod_estad_factu
	   from tbl_facturas 
	   where ncodigo_factu = @numero
	   and ccod_conce_factu = @concepto
	   and ncod_ubic_factu = @ubicacion 
	
	   if @@ROWCOUNT > 0 
	    begin
		  if @estadofac = 'CF'
		  BEGIN
		   raiserror ('%s',16,1,'La Reserva tiene una Factura Confirmada')
		   rollback
		   return 1
	      END
	      
	      IF @estadofac = 'AC'
	        BEGIN
			   select @estado = ccod_estad_reser
			   from tbl_reservas 
			   where ncodigo_reser = @numero
			   and ncod_ubic_reser = @ubicacion 
		   
				if @estado = 'AC'
					 begin
					   UPDATE tbl_reservas 
					   set ccod_estad_reser  = 'AN'
					   where ncodigo_reser = @numero
						and ncod_ubic_reser = @ubicacion 
				        
					   UPDATE tbl_facturas 
					   set ccod_estad_factu = 'AN'
					   where ncodigo_factu = @numero
					   and ccod_conce_factu = 'FR'
					   and ncod_ubic_factu = @ubicacion 
					  end
				  
				  if @estado in  ('CF','AN')
				    BEGIN
					raiserror ('%s',16,1,'La Reserva debe estar Activa')
					rollback
					return 1
					END 
	    end
	   
   end
    
   if @@ROWCOUNT = 0
    begin
    select @estado = ccod_estad_reser
		   from tbl_reservas 
		   where ncodigo_reser = @numero
		   and ncod_ubic_reser = @ubicacion 
		   if @estado = 'AC'
		    begin
					   UPDATE tbl_reservas 
					   set ccod_estad_reser  = 'AN'
					   where ncodigo_reser = @numero
						and ncod_ubic_reser = @ubicacion 
			end
			 if @estado in  ('CF','AN')
			      BEGIN
					raiserror ('%s',16,1,'La Reserva debe estar Activa')
					rollback
					return 1
					END 
			
   end
   end
   commit 