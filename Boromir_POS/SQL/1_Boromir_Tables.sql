If Not exists (select 1 from sys.databases where name='Boromir')
 create database Boromir
go

if exists (select 1 from sys.databases where name='Boromir')
  use Boromir 
  go
  
  CREATE TABLE [dbo].[tbl_categorias](
	[cnombre_categ] [varchar](30) NOT NULL,
 CONSTRAINT [pk_cnombre_categ] PRIMARY KEY CLUSTERED 
(
	[cnombre_categ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-----------------
-------------------
CREATE TABLE [dbo].[tbl_colores](
	[cnombre_color] [varchar](30) NOT NULL,
 CONSTRAINT [pk_cnombre_color] PRIMARY KEY CLUSTERED 
(
	[cnombre_color] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
----------

------------
CREATE TABLE [dbo].[tbl_marcas](
	[cnombre_marca] [varchar](30) NOT NULL,
 CONSTRAINT [pk_cnombre_marca] PRIMARY KEY CLUSTERED 
(
	[cnombre_marca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-------------
-------------
CREATE TABLE [dbo].[tbl_unidad_medida](
	[cnombre_undmed] [varchar](30) NOT NULL,
 CONSTRAINT [pk_cnombre_undmed] PRIMARY KEY CLUSTERED 
(
	[cnombre_undmed] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
------------------
-------------------
CREATE TABLE [dbo].[tbl_empresa](
	[cnombre_empre] [varchar](50) NOT NULL,
	[nnit_empre] [numeric](13, 0) NOT NULL,
	[cdireccion_empre] [char](30) NULL,
	[cresolucion_empre] [varchar](30) NULL,
	[ntelefono_empre] [numeric](7, 0) NULL,
	[ncelular_empre] [numeric](10, 0) NULL,
	[cruta_produ_empre] [varchar](500) NOT NULL,
	[cruta_manual_empre] [varchar](500)  NULL,
	[cruta_repor_empre] [varchar](500) NOT NULL,
	[ccorreo_empre] [char](50) NULL,
	[cclave_empre] [varchar](50)  NULL,
	[csmtp_empre] [varchar](50)  NULL,
	[cpuerto_empre] [varchar](50)  NULL
) ON [PRIMARY]

GO
-----------
-----------
CREATE TABLE [dbo].[tbl_datos_escen_reser](
	[ccod_tescen_der] [char](2) NOT NULL,
	[cnombre_tescen_der] [char](30) NOT NULL,
	[ccod_tcosto_der] [char](2) NOT NULL,
	[mvalor_tcosto_der] [money] NULL
) ON [PRIMARY]

GO
--------
--------
CREATE TABLE [dbo].[tbl_estados](
	[ccodigo_estad] [char](2) NOT NULL,
	[cnombre_estad] [char](30) NOT NULL,
 CONSTRAINT [pk_ccodigo_estad] PRIMARY KEY CLUSTERED 
(
	[ccodigo_estad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-----------
-----------
CREATE TABLE [dbo].[tbl_ciudad](
	[ncodigo_ciudad] [numeric](2, 0) NOT NULL,
	[cnombre_ciudad] [char](30) NOT NULL,
 CONSTRAINT [pk_ncodigo_ciudad] PRIMARY KEY CLUSTERED 
(
	[ncodigo_ciudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
---------
---------
CREATE TABLE [dbo].[tbl_tipodoc](
	[ccodigo_tipodoc] [char](2) NOT NULL,
	[cnombre_tipodoc] [char](30) NOT NULL,
 CONSTRAINT [pk_ccodigo_tipodoc] PRIMARY KEY CLUSTERED 
(
	[ccodigo_tipodoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
------
------
CREATE TABLE [dbo].[tbl_tescenarios](
	[ccodigo_tescen] [char](2) NOT NULL,
	[cnombre_tescen] [char](30) NOT NULL,
 CONSTRAINT [pk_ccodigo_tiescen] PRIMARY KEY CLUSTERED 
(
	[ccodigo_tescen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
-------
-------
CREATE TABLE [dbo].[tbl_modulos](
	[ccodigo_modul] [char](5) NOT NULL,
	[cnombre_modul] [char](30) NOT NULL,
	[nuno_modul] [numeric](1) NOT NULL,
	[ndos_modul] [numeric](1) NOT NULL,
	[ntres_modul] [numeric](1) NOT NULL,
	[ncuatro_modul] [numeric](1) NOT NULL,
	[ncinco_modul] [numeric](1) NOT NULL,
	[nseis_modul] [numeric](1) NOT NULL,
 CONSTRAINT [pk_ccodigo_modul] PRIMARY KEY CLUSTERED 
(
	[ccodigo_modul] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-------
-------
CREATE TABLE [dbo].[tbl_aplicperfil](
	[ncod_perfil_aplicperfil] [numeric](2, 0) NOT NULL,
	[documentos_admon] [char](2) NOT NULL,
	[conceptos_admon] [char](2) NOT NULL,
	[escenarios_admon] [char](2) NOT NULL,
	[costos_admon] [char](2) NOT NULL,
	[cuidades_admon] [char](2) NOT NULL,
	[zonas_admon] [char](2) NOT NULL,
	[terceros_admon] [char](2) NOT NULL,
	[ubicaciones_admon] [char](2) NOT NULL,
	[proyectos_admon] [char](2) NOT NULL,
	[escenxubica_admon] [char](2) NOT NULL,
	[tblcostos_admon] [char](2) NOT NULL,
	[productos_inven] [char](2) NOT NULL,
	[movimientos_inven] [char](2) NOT NULL,
	[saldos_inven] [char](2) NOT NULL,
	[ordenes_inven] [char](2) NOT NULL,
	[facturas_factu] [char](2) NOT NULL,
	[cotizaciones_factu] [char](2) NOT NULL,
	[pedidos_factu] [char](2) NOT NULL,
	[reservas_factu] [char](2) NOT NULL,
	[administraivos_report] [char](2) NOT NULL,
	[inventarios_report] [char](2) NOT NULL,
	[facturacion_report] [char](2) NOT NULL,
	[perfiles_segur] [char](2) NOT NULL,
	[usuarios_segur] [char](2) NOT NULL,
	[claves_segur] [char](2) NOT NULL,
	[empresa_segur] [char](2) NOT NULL,
	[licencia_segur] [char](2) NOT NULL,
	[auditoria_segur] [char](2) NOT NULL,
	
 CONSTRAINT [pk_ncod_perfil_aplicperfil] PRIMARY KEY CLUSTERED 
(
	[ncod_perfil_aplicperfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
--------------
--------------
CREATE TABLE [dbo].[tbl_zonas](
	[ncodigo_zona] [numeric](2, 0) NOT NULL,
	[cnombre_zona] [char](30) NOT NULL,
	[ncod_ciudad_zona] [numeric](2, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ncodigo_zona] ASC,
	[ncod_ciudad_zona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_zonas]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ciudad_zona] FOREIGN KEY([ncod_ciudad_zona])
REFERENCES [dbo].[tbl_ciudad] ([ncodigo_ciudad])
GO
--------
--------
CREATE TABLE [dbo].[tbl_perfiles](
	[ncodigo_perfil] [numeric](2, 0) NOT NULL,
	[cnombre_perfil] [char](30) NOT NULL,
	[ccrear_perfil] [char](2) NOT NULL,
	[cconsultar_perfil] [char](2) NOT NULL,
	[cmodificar_perfil] [char](2) NOT NULL,
	[cconfirmar_perfil] [char](2) NOT NULL,
	[creversar_perfil] [char](2) NOT NULL,
	[canular_perfil] [char](2) NOT NULL,
	[cimprimir_perfil] [char](2) NOT NULL,
	[csql_perfil] [char](2) NOT NULL,
	[ccod_estad_perfil] [char](2) NOT NULL
) ON [PRIMARY]
SET ANSI_PADDING ON
ALTER TABLE [dbo].[tbl_perfiles] ADD  CONSTRAINT [pk_ncodigo_perfil] PRIMARY KEY CLUSTERED 
(
	[ncodigo_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_perfiles]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_perfil] FOREIGN KEY([ccod_estad_perfil])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO
------------
------------
cREATE TABLE [dbo].[tbl_aplicaciones](
	[ccodigo_aplic] [char](5) NOT NULL,
	[cnombre_aplic] [char](30) NOT NULL,
	[ccod_modul_aplic] [char](5) NOT NULL,
 CONSTRAINT [pk_ccodigo_aplic] PRIMARY KEY CLUSTERED 
(
	[ccodigo_aplic] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_aplicaciones]  WITH CHECK ADD  CONSTRAINT [fk_ccod_modul_aplic] FOREIGN KEY([ccod_modul_aplic])
REFERENCES [dbo].[tbl_modulos] ([ccodigo_modul])
GO
---------------
---------------
CREATE TABLE [dbo].[tbl_conceptos](
	[ccodigo_conce] [char](2) NOT NULL,
	[cnombre_conce] [char](39) NOT NULL,
	[ccod_aplic_conce] [char](5) NOT NULL,
	[caccion_conce] [char](6) NOT NULL,
 CONSTRAINT [pk_ccodigo_conce] PRIMARY KEY CLUSTERED 
(
	[ccodigo_conce] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_conceptos]  WITH CHECK ADD  CONSTRAINT [fk_ccod_aplic_conce] FOREIGN KEY([ccod_aplic_conce])
REFERENCES [dbo].[tbl_aplicaciones] ([ccodigo_aplic])
GO
----------
----------
CREATE TABLE [dbo].[tbl_productos](
	[ncodigo_produ] [numeric](20, 0) NOT NULL,
	[ncod_externo_produ] [numeric](38, 0) NULL,
	[cnombre_produ] [varchar](100) NOT NULL,
	[cimagen_produ] [varchar](500) NOT NULL,
	[ccod_categ_produ] [varchar](30) NOT NULL,
	[ccod_marca_produ] [varchar](30) NOT NULL,
	[ccod_und_produ] [varchar](30) NOT NULL,
	[ffecha_vence_produ] [varchar](50) NULL,
	[nalto_produ] [numeric](4, 0) NULL,
	[nancho_produ] [numeric](4, 0) NULL,
	[nlargo_produ] [numeric](4, 0) NULL,
	[ncapacidad_produ] [numeric](4, 0) NULL,
	[ndiametro_produ] [numeric](4, 0) NULL,
	[npeso_produ] [numeric](4, 0) NULL,
	[ccod_color_produ] [varchar](30) NULL,
	[ccombo_produ] [char](2) NOT NULL,
	[nimpuesto_produ] [numeric](2, 0) NOT NULL,
	[ndescuento_produ] [numeric](2, 0) NOT NULL,
	[nprecio_compra_produ] [numeric](15, 0) NOT NULL,
	[nprecio_venta_produ] [numeric](15, 0) NOT NULL,
	[cobservacion_produ] [char](500) NULL,
 CONSTRAINT [pk_ncodigo_produ] PRIMARY KEY CLUSTERED 
(
	[ncodigo_produ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_productos]  WITH CHECK ADD  CONSTRAINT [fk_ccod_categ_produ] FOREIGN KEY([ccod_categ_produ])
REFERENCES [dbo].[tbl_categorias] ([cnombre_categ])
GO

ALTER TABLE [dbo].[tbl_productos] CHECK CONSTRAINT [fk_ccod_categ_produ]
GO

ALTER TABLE [dbo].[tbl_productos]  WITH CHECK ADD  CONSTRAINT [fk_ccod_color_produ] FOREIGN KEY([ccod_color_produ])
REFERENCES [dbo].[tbl_colores] ([cnombre_color])
GO

ALTER TABLE [dbo].[tbl_productos] CHECK CONSTRAINT [fk_ccod_color_produ]
GO

ALTER TABLE [dbo].[tbl_productos]  WITH CHECK ADD  CONSTRAINT [fk_ccod_marca_produ] FOREIGN KEY([ccod_marca_produ])
REFERENCES [dbo].[tbl_marcas] ([cnombre_marca])
GO

ALTER TABLE [dbo].[tbl_productos] CHECK CONSTRAINT [fk_ccod_marca_produ]
GO

ALTER TABLE [dbo].[tbl_productos]  WITH CHECK ADD  CONSTRAINT [fk_ccod_und_produ] FOREIGN KEY([ccod_und_produ])
REFERENCES [dbo].[tbl_unidad_medida] ([cnombre_undmed])
GO

ALTER TABLE [dbo].[tbl_productos] CHECK CONSTRAINT [fk_ccod_und_produ]
GO
----------
-----------
CREATE TABLE [dbo].[tbl_combos](
	[ncodigo_combo] [numeric](20, 0) NOT NULL,
	[ncod_componente_combo] [numeric](20, 0) NOT NULL,
	[ncantidad_componente_combo] [numeric](32, 0) NOT NULL,
 CONSTRAINT [pk_ncodigo_combo] PRIMARY KEY CLUSTERED 
(
	[ncodigo_combo] ASC,
	[ncod_componente_combo]asc
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_combos]  WITH CHECK ADD  CONSTRAINT [fk_ncod_componente_combo] FOREIGN KEY([ncod_componente_combo])
REFERENCES [dbo].[tbl_productos] ([ncodigo_produ])
GO

ALTER TABLE [dbo].[tbl_combos] CHECK CONSTRAINT [fk_ncod_componente_combo]
GO

ALTER TABLE [dbo].[tbl_combos]  WITH CHECK ADD  CONSTRAINT [fk_ncodigo_combo] FOREIGN KEY([ncodigo_combo])
REFERENCES [dbo].[tbl_productos] ([ncodigo_produ])
GO
-------------
-------------
CREATE TABLE [dbo].[tbl_terceros](
	[ncodigo_terce] [numeric](10, 0) NOT NULL,
	[ccod_tipodoc_terce] [char](2) NOT NULL,
	[cnombre_terce] [char](30) NOT NULL,
	[cnombre2_terce] [char](30) NULL,
	[capellido_terce] [char](30) NOT NULL,
	[capellido2_terce] [char](30) NULL,
	[ntelefono_terce] [numeric](7, 0) NULL,
	[ncelular_terce] [numeric](15, 0) NULL,
	[cdireccion_terce] [varchar](30) NOT NULL,
	[ncod_ciudad_terce] [numeric](2, 0) NOT NULL,
	[cemail_terce] [varchar](50) NULL,
	[ncliente_terce] [numeric](1, 0) NULL,
	[nproveedor_terce] [numeric](1, 0) NULL,
	[nempleado_terce] [numeric](1, 0) NULL,
	[ccod_estad_terce] [char](2) NOT NULL,
 CONSTRAINT [pk_ncodigo_terce] PRIMARY KEY CLUSTERED 
(
	[ncodigo_terce] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbl_terceros]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_terce] FOREIGN KEY([ccod_estad_terce])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO

ALTER TABLE [dbo].[tbl_terceros]  WITH CHECK ADD  CONSTRAINT [fk_ccod_tipodoc_terce] FOREIGN KEY([ccod_tipodoc_terce])
REFERENCES [dbo].[tbl_tipodoc] ([ccodigo_tipodoc])
GO

ALTER TABLE [dbo].[tbl_terceros]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ciudad_terce] FOREIGN KEY([ncod_ciudad_terce])
REFERENCES [dbo].[tbl_ciudad] ([ncodigo_ciudad])
GO
---------
---------
CREATE TABLE [dbo].[tbl_ubicaciones](
	[ncodigo_ubica] [numeric](3, 0) NOT NULL,
	[cnombre_ubica] [char](30) NOT NULL,
	[cdireccion_ubica] [char](30) NULL,
	[ntelefono_ubica] [numeric](7, 0) NULL,
	[ncelular_ubica] [numeric](10, 0) NULL,
	[ccorreo_ubica] [char](50) NULL,
	[ncod_ciudad_ubica] [numeric](2, 0) NOT NULL,
	[ncod_zona_ubica] [numeric](2, 0) NOT NULL,
	[ncod_admon_ubica] [numeric](10, 0) NOT NULL,
	[ncobro_ubica] [numeric](1, 0) NOT NULL,
 CONSTRAINT [pk_ncodigo_ubica] PRIMARY KEY CLUSTERED 
(
	[ncodigo_ubica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_ubicaciones]  WITH CHECK ADD  CONSTRAINT [fk_ncod_admon_ubica] FOREIGN KEY([ncod_admon_ubica])
REFERENCES [dbo].[tbl_terceros] ([ncodigo_terce])
GO

ALTER TABLE [dbo].[tbl_ubicaciones]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ciudad_ubica] FOREIGN KEY([ncod_ciudad_ubica])
REFERENCES [dbo].[tbl_ciudad] ([ncodigo_ciudad])
GO

ALTER TABLE [dbo].[tbl_ubicaciones]  WITH CHECK ADD  CONSTRAINT [fk_ncod_zona_ubica] FOREIGN KEY([ncod_zona_ubica],[ncod_ciudad_ubica])
REFERENCES [dbo].[tbl_zonas] ([ncodigo_zona],[ncod_ciudad_zona]) 
GO
--------
--------
CREATE TABLE [dbo].[tbl_saldos](
	[ncod_produ_saldo] [numeric](20, 0) NOT NULL,
	[ncod_ubica_saldo] [numeric](3, 0) NOT NULL,
	[ncantidad_saldo] [numeric](38, 0) NOT NULL,
 CONSTRAINT [pk_ncod_produ_saldo] PRIMARY KEY CLUSTERED 
(
	[ncod_produ_saldo] ASC,
	[ncod_ubica_saldo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_saldos]  WITH CHECK ADD  CONSTRAINT [fk_ncod_produ_saldo] FOREIGN KEY([ncod_produ_saldo])
REFERENCES [dbo].[tbl_productos] ([ncodigo_produ])
GO

ALTER TABLE [dbo].[tbl_saldos] CHECK CONSTRAINT [fk_ncod_produ_saldo]
GO

ALTER TABLE [dbo].[tbl_saldos]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubica_saldo] FOREIGN KEY([ncod_ubica_saldo])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO

ALTER TABLE [dbo].[tbl_saldos] CHECK CONSTRAINT [fk_ncod_ubica_saldo]
GO
-----------
-----------
CREATE TABLE [dbo].[tbl_tipocosto](
	[ccodigo_tcosto] [char](1) NOT NULL,
	[ncod_ubica_tcosto] [numeric](3, 0) NOT NULL,
	[mvalor_tcosto] [money] NOT NULL,
 CONSTRAINT [pk_ccodigo_tcosto] PRIMARY KEY CLUSTERED 
(
	[ccodigo_tcosto] ASC,
	[ncod_ubica_tcosto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_tipocosto]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubica_tcosto] FOREIGN KEY([ncod_ubica_tcosto])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO
-------
-------
CREATE TABLE [dbo].[tbl_escenarios](
	[ncodigo_escen] [numeric](2, 0) NOT NULL,
	[ncod_ubica_escen] [numeric](3, 0) NOT NULL,
	[cnombre_escen] [char](30) NOT NULL,
	[ctipo_escen] [char](2) NOT NULL,
	[ccod_estad_escen] [char](2) NOT NULL,
	[ccod_tcosto_tescen] [char](1)  NULL,
 CONSTRAINT [pk_ncodigo_escen] PRIMARY KEY CLUSTERED 
(
	[ncodigo_escen] ASC,
	[ncod_ubica_escen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_escenarios]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_escen] FOREIGN KEY([ccod_estad_escen])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO

ALTER TABLE [dbo].[tbl_escenarios]  WITH CHECK ADD  CONSTRAINT [fk_ctipo_escen] FOREIGN KEY([ctipo_escen])
REFERENCES [dbo].[tbl_tescenarios] ([ccodigo_tescen])
GO

ALTER TABLE [dbo].[tbl_escenarios]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubica_escen] FOREIGN KEY([ncod_ubica_escen])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO

ALTER TABLE [dbo].[tbl_escenarios]  WITH CHECK ADD  CONSTRAINT [fk_ccod_tcosto_tescen] FOREIGN KEY([ccod_tcosto_tescen],[ncod_ubica_escen])
REFERENCES [dbo].[tbl_tipocosto] ([ccodigo_tcosto],[ncod_ubica_tcosto])
GO
---------
---------
CREATE TABLE [dbo].[tbl_costoturno](
	[ncod_ubica_costurno] [numeric](3, 0) NOT NULL,
	[ccod_tescen_costurno] [char](2) NOT NULL,
	[chora_costurno] [char](5) NOT NULL,
	[cdia_costurno] [char](9) NOT NULL,
	[ccod_tcosto_costurno] [char](1) NOT NULL
 CONSTRAINT [pk_ncod_ubica_costurno] PRIMARY KEY CLUSTERED 
(
	[ncod_ubica_costurno] ASC,
	[ccod_tescen_costurno] ASC,
	[chora_costurno] ASC,
	[cdia_costurno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_costoturno]  WITH CHECK ADD  CONSTRAINT [fk_ccod_tcosto_costurno] FOREIGN KEY([ccod_tcosto_costurno],[ncod_ubica_costurno])
REFERENCES [dbo].[tbl_tipocosto] ([ccodigo_tcosto],[ncod_ubica_tcosto])
GO

ALTER TABLE [dbo].[tbl_costoturno]  WITH CHECK ADD  CONSTRAINT [fk_ccod_tescen_costurno] FOREIGN KEY([ccod_tescen_costurno])
REFERENCES [dbo].[tbl_tescenarios] ([ccodigo_tescen])
GO

ALTER TABLE [dbo].[tbl_costoturno]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubica_costurno] FOREIGN KEY([ncod_ubica_costurno])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO
---------
---------
CREATE TABLE [dbo].[tbl_usuarios](
	[cnombre_usua] [varchar](30) NOT NULL,
	[ccontraseña_usua] [varchar](30) NOT NULL,
	[ncod_ubic_usua] [numeric](3, 0) NOT NULL,
	[ncod_perfil_usua] [numeric](2, 0) NOT NULL,
	[ncod_terce_usua] [numeric](10, 0) NOT NULL,
	[ccod_estad_usua] [char](2) NOT NULL,
 CONSTRAINT [pk_cnombre_usua] PRIMARY KEY CLUSTERED 
(
	[cnombre_usua] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_usua] FOREIGN KEY([ccod_estad_usua])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO

ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [fk_ncod_perfil_usua] FOREIGN KEY([ncod_perfil_usua])
REFERENCES [dbo].[tbl_perfiles] ([ncodigo_perfil])
GO

ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [fk_ncod_terce_usua] FOREIGN KEY([ncod_terce_usua])
REFERENCES [dbo].[tbl_terceros] ([ncodigo_terce])
GO

ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubic_usua] FOREIGN KEY([ncod_ubic_usua])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO
----------
----------
CREATE TABLE [dbo].[tbl_auditoria](
	[ncod_usua_audi] [varchar](30) NOT NULL,
	[caccion_audi] [varchar](30) NOT NULL,
	[cnombre_aplic_audi] [varchar](30) NOT NULL,
	[cdescripcion_audi] [varchar](500) NOT NULL,
	[ffecha_audi] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_auditoria]  WITH CHECK ADD  CONSTRAINT [fk_ncod_usua_audi] FOREIGN KEY([ncod_usua_audi])
REFERENCES [dbo].[tbl_usuarios] ([cnombre_usua])
GO

ALTER TABLE [dbo].[tbl_auditoria] CHECK CONSTRAINT [fk_ncod_usua_audi]
GO
--------
---------
CREATE TABLE [dbo].[tbl_reservas](
	[ncodigo_reser] [numeric](38, 0) NOT NULL,
	[ncod_ubic_reser] [numeric](3, 0) NOT NULL,
	[ffecha_reser] [varchar](50) NOT NULL,
	[hhora_reser] [char](5) NOT NULL,
	[ncod_escen_reser] [numeric](2, 0) NOT NULL,
	[ncod_terce_reser] [numeric](10, 0) NOT NULL,
	[ccod_tcosto_reser] [char](1) NOT NULL,
	[ccod_estad_reser] [char](2) NOT NULL,
 CONSTRAINT [pk_ncodigo_reser] PRIMARY KEY CLUSTERED 
(
	[ncodigo_reser] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_reservas]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_reser] FOREIGN KEY([ccod_estad_reser])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO

ALTER TABLE [dbo].[tbl_reservas]  WITH CHECK ADD  CONSTRAINT [fk_ccod_tcosto_reser] FOREIGN KEY([ccod_tcosto_reser],[ncod_ubic_reser])
REFERENCES [dbo].[tbl_tipocosto] ([ccodigo_tcosto],[ncod_ubica_tcosto])
GO

ALTER TABLE [dbo].[tbl_reservas]  WITH CHECK ADD  CONSTRAINT [fk_ncod_escen_reser] FOREIGN KEY([ncod_escen_reser],[ncod_ubic_reser])
REFERENCES [dbo].[tbl_escenarios] ([ncodigo_escen],[ncod_ubica_escen])
GO

ALTER TABLE [dbo].[tbl_reservas]  WITH CHECK ADD  CONSTRAINT [fk_ncod_terce_reser] FOREIGN KEY([ncod_terce_reser])
REFERENCES [dbo].[tbl_terceros] ([ncodigo_terce])
GO

ALTER TABLE [dbo].[tbl_reservas]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubic_resr] FOREIGN KEY([ncod_ubic_reser])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO
--------
--------
CREATE TABLE [dbo].[tbl_facturas](
	[ncodigo_factu] [numeric](38, 0) NOT NULL,
	[ccod_conce_factu] [char](2) NOT NULL,
	[ncod_ubic_factu] [numeric](3, 0) NOT NULL,
	[ncod_terce_factu] [numeric](10, 0) NOT NULL,
	[ffecha_factu] [varchar](50) NOT NULL,
	[nneto_factu] [numeric](38, 0) NOT NULL,
	[ndescuento_factu] [numeric](38, 0) NOT NULL,
	[nimpuesto_factu] [numeric](38, 0) NOT NULL,
	[ntotal_factu] [numeric](38, 0) NOT NULL,
	[ccod_estad_factu] [char](2) NOT NULL,
 CONSTRAINT [pk_ncodigo_factu] PRIMARY KEY CLUSTERED 
(
	[ncodigo_factu] ASC,
	[ccod_conce_factu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_facturas]  WITH CHECK ADD  CONSTRAINT [fk_ccod_conce_factu] FOREIGN KEY([ccod_conce_factu])
REFERENCES [dbo].[tbl_conceptos] ([ccodigo_conce])
GO

ALTER TABLE [dbo].[tbl_facturas]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_factu] FOREIGN KEY([ccod_estad_factu])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO

ALTER TABLE [dbo].[tbl_facturas]  WITH CHECK ADD  CONSTRAINT [fk_ncod_terce_factu] FOREIGN KEY([ncod_terce_factu])
REFERENCES [dbo].[tbl_terceros] ([ncodigo_terce])
GO

ALTER TABLE [dbo].[tbl_facturas]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubic_factu] FOREIGN KEY([ncod_ubic_factu])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO
---------
---------
/*CREATE TABLE [dbo].[tbl_detalle_factura](
	[ncod_factu_detfactu] [numeric](38, 0) NOT NULL,
	[ccod_conce_detfactu] [char](2) NOT NULL,
	[ncod_produ_detfactu] [numeric](13, 0) NOT NULL,
	[ncantidad_detfactu] [numeric](6, 0) NOT NULL,
	[nescenario_reser_detfactu] [numeric](2, 0) NULL,
	[hhora_reser_detfactu] [char](5) NULL,
	[ndescuento_detfactu] [numeric](9, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_detalle_factura]  WITH CHECK ADD  CONSTRAINT [fk_ncod_factu_detfactu] FOREIGN KEY([ncod_factu_detfactu],[ccod_conce_detfactu])
REFERENCES [dbo].[tbl_facturas] ([ncodigo_factu],[ccod_conce_factu])
GO

ALTER TABLE [dbo].[tbl_detalle_factura]  WITH CHECK ADD  CONSTRAINT [fk_ccod_conce_detfactu] FOREIGN KEY([ccod_conce_detfactu])
REFERENCES [dbo].[tbl_conceptos] ([ccodigo_conce])
GO

ALTER TABLE [dbo].[tbl_detalle_factura]  WITH CHECK ADD  CONSTRAINT [fk_ncod_produ_detfactu] FOREIGN KEY([ncod_produ_detfactu])
REFERENCES [dbo].[tbl_productos] ([ncodigo_produ])
GO*/
------
------
CREATE TABLE [dbo].[tbl_movimiento_producto](
	[ncodigo_moviprodu] [numeric](38, 0) NOT NULL,
	[ccod_conce_moviprodu] [char](2) NOT NULL,
	[ncod_ubica_moviprodu] [numeric](3, 0) NOT NULL,
	[ffecha_moviprodu] [varchar](50) NOT NULL,
	[ncod_terce_moviprodu] [numeric](10, 0) NOT NULL,
	[nneto_moviprodu] [numeric](38, 0) NOT NULL,
	[nimpuesto_moviprodu] [numeric](38, 0) NOT NULL,
	[ndescuento_moviprodu] [numeric](38, 0) NOT NULL,
	[ntotal_moviprodu] [numeric](38, 0) NOT NULL,
	[ccod_estad_moviprodu] [char](2) NOT NULL,
 CONSTRAINT [pk_ncodigo_moviprodu] PRIMARY KEY CLUSTERED 
(
	[ncodigo_moviprodu] ASC,
	[ccod_conce_moviprodu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_movimiento_producto]  WITH CHECK ADD  CONSTRAINT [fk_ccod_conce_moviprodu] FOREIGN KEY([ccod_conce_moviprodu])
REFERENCES [dbo].[tbl_conceptos] ([ccodigo_conce])
GO

ALTER TABLE [dbo].[tbl_movimiento_producto] CHECK CONSTRAINT [fk_ccod_conce_moviprodu]
GO

ALTER TABLE [dbo].[tbl_movimiento_producto]  WITH CHECK ADD  CONSTRAINT [fk_ncod_terce_moviprodu] FOREIGN KEY([ncod_terce_moviprodu])
REFERENCES [dbo].[tbl_terceros] ([ncodigo_terce])
GO

ALTER TABLE [dbo].[tbl_movimiento_producto] CHECK CONSTRAINT [fk_ncod_terce_moviprodu]
GO

ALTER TABLE [dbo].[tbl_movimiento_producto]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubica_moviprodu] FOREIGN KEY([ncod_ubica_moviprodu])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO

ALTER TABLE [dbo].[tbl_movimiento_producto] CHECK CONSTRAINT [fk_ncod_ubica_moviprodu]
GO

ALTER TABLE [dbo].[tbl_movimiento_producto]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_moviprodu] FOREIGN KEY([ccod_estad_moviprodu])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO
-------
-------
CREATE TABLE [dbo].[tbl_cotizaciones](
	[ncodigo_cotiz] [numeric](38, 0) NOT NULL,
	[ccod_conce_cotiz] [char](2) NOT NULL,
	[ncod_ubic_cotiz] [numeric](3, 0) NOT NULL,
	[ncod_terce_cotiz] [numeric](10, 0) NOT NULL,
	[ffecha_cotiz] [varchar](50) NOT NULL,
	[nneto_cotiz] [numeric](38, 0) NOT NULL,
	[ndescuento_cotiz] [numeric](38, 0) NOT NULL,
	[nimpuesto_cotiz] [numeric](38, 0) NOT NULL,
	[ntotal_cotiz] [numeric](38, 0) NOT NULL,
	[ccod_estad_cotiz] [char](2) NOT NULL,
	[cobservacion_cotiz] [varchar] (500), 
 CONSTRAINT [pk_ncodigo_cotiz] PRIMARY KEY CLUSTERED 
(
	[ncodigo_cotiz] ASC,
	[ccod_conce_cotiz] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_cotizaciones]  WITH CHECK ADD  CONSTRAINT [fk_ccod_conce_cotiz] FOREIGN KEY([ccod_conce_cotiz])
REFERENCES [dbo].[tbl_conceptos] ([ccodigo_conce])
GO

ALTER TABLE [dbo].[tbl_cotizaciones]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_cotiz] FOREIGN KEY([ccod_estad_cotiz])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO

ALTER TABLE [dbo].[tbl_cotizaciones]  WITH CHECK ADD  CONSTRAINT [fk_ncod_terce_cotiz] FOREIGN KEY([ncod_terce_cotiz])
REFERENCES [dbo].[tbl_terceros] ([ncodigo_terce])
GO

ALTER TABLE [dbo].[tbl_cotizaciones]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubic_cotiz] FOREIGN KEY([ncod_ubic_cotiz])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO
---------------
---------------
CREATE TABLE [dbo].[tbl_pedidos](
	[ncodigo_pedid] [numeric](38, 0) NOT NULL,
	[ccod_conce_pedid] [char](2) NOT NULL,
	[ncod_ubic_pedid] [numeric](3, 0) NOT NULL,
	[ncod_terce_pedid] [numeric](10, 0) NOT NULL,
	[ffecha_pedid] [varchar](50) NOT NULL,
	[nneto_pedid] [numeric](38, 0) NOT NULL,
	[ndescuento_pedid] [numeric](38, 0) NOT NULL,
	[nimpuesto_pedid] [numeric](38, 0) NOT NULL,
	[ntotal_pedid] [numeric](38, 0) NOT NULL,
	[ccod_estad_pedid] [char](2) NOT NULL,
	[cobservacion_pedid] [varchar] (500), 
 CONSTRAINT [pk_ncodigo_pedid] PRIMARY KEY CLUSTERED 
(
	[ncodigo_pedid] ASC,
	[ccod_conce_pedid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_pedidos]  WITH CHECK ADD  CONSTRAINT [fk_ccod_conce_pedid] FOREIGN KEY([ccod_conce_pedid])
REFERENCES [dbo].[tbl_conceptos] ([ccodigo_conce])
GO

ALTER TABLE [dbo].[tbl_pedidos]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_pedid] FOREIGN KEY([ccod_estad_pedid])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO

ALTER TABLE [dbo].[tbl_pedidos]  WITH CHECK ADD  CONSTRAINT [fk_ncod_terce_pedid] FOREIGN KEY([ncod_terce_pedid])
REFERENCES [dbo].[tbl_terceros] ([ncodigo_terce])
GO

ALTER TABLE [dbo].[tbl_pedidos]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubic_pedid] FOREIGN KEY([ncod_ubic_pedid])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO
---------------
---------------
CREATE TABLE [dbo].[tbl_detalle_movimientos](
	[ncod_movim_detmovim] [numeric](38, 0) NOT NULL,
	[ccod_conce_detmovim] [char](2) NOT NULL,
	[ncod_ubica_detmovim] [numeric](3, 0) NOT NULL,
	[ffecha_detmovim] [varchar](50) NOT NULL,
	[ncod_produ_detmovim] [numeric](20, 0) NOT NULL,
	[ncantidad_detmovim] [numeric](38, 0) NOT NULL,
	[nprecio_detmovim] [numeric](38, 0) NOT NULL,
	[ndescuento_detmovim] [numeric](38, 0) NOT NULL,
	[nimpuesto_detmovim] [numeric](38, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_detalle_movimientos]  WITH CHECK ADD  CONSTRAINT [fk_ccod_conce_detmovim] FOREIGN KEY([ccod_conce_detmovim])
REFERENCES [dbo].[tbl_conceptos] ([ccodigo_conce])
GO

ALTER TABLE [dbo].[tbl_detalle_movimientos]  WITH CHECK ADD  CONSTRAINT [fk_ncod_produ_detmovim] FOREIGN KEY([ncod_produ_detmovim])
REFERENCES [dbo].[tbl_productos] ([ncodigo_produ])
GO

ALTER TABLE [dbo].[tbl_detalle_movimientos]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubica_detmovim] FOREIGN KEY([ncod_ubica_detmovim])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO
---------------
---------------
CREATE TABLE [dbo].[tbl_ordenes](
	[ncodigo_orden] [numeric](38, 0) NOT NULL,
	[ccod_conce_orden] [char](2) NOT NULL,
	[ncod_ubic_orden] [numeric](3, 0) NOT NULL,
	[ncod_terce_orden] [numeric](10, 0) NOT NULL,
	[ffecha_orden] [varchar](50) NOT NULL,
	[nneto_orden] [numeric](38, 0) NOT NULL,
	[ndescuento_orden] [numeric](38, 0) NOT NULL,
	[nimpuesto_orden] [numeric](38, 0) NOT NULL,
	[ntotal_orden] [numeric](38, 0) NOT NULL,
	[ccod_estad_orden] [char](2) NOT NULL,
 CONSTRAINT [pk_ncodigo_orden] PRIMARY KEY CLUSTERED 
(
	[ncodigo_orden] ASC,
	[ccod_conce_orden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_ordenes]  WITH CHECK ADD  CONSTRAINT [fk_ccod_conce_orden] FOREIGN KEY([ccod_conce_orden])
REFERENCES [dbo].[tbl_conceptos] ([ccodigo_conce])
GO

ALTER TABLE [dbo].[tbl_ordenes]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_orden] FOREIGN KEY([ccod_estad_orden])
REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
GO

ALTER TABLE [dbo].[tbl_ordenes]  WITH CHECK ADD  CONSTRAINT [fk_ncod_terce_orden] FOREIGN KEY([ncod_terce_orden])
REFERENCES [dbo].[tbl_terceros] ([ncodigo_terce])
GO

ALTER TABLE [dbo].[tbl_ordenes]  WITH CHECK ADD  CONSTRAINT [fk_ncod_ubic_orden] FOREIGN KEY([ncod_ubic_orden])
REFERENCES [dbo].[tbl_ubicaciones] ([ncodigo_ubica])
GO
--ALTER TABLE [dbo].[tbl_ordenes]  WITH CHECK ADD  CONSTRAINT [fk_ncod_proye_orden] FOREIGN KEY([ncod_proye_orden])
--REFERENCES [dbo].[tbl_proyectos] ([ncodigo_proye])
--GO

----------------
----------------
--CREATE TABLE [dbo].[tbl_proyectos](
--	[ncodigo_proye] [numeric](20, 0) NOT NULL,
--	[cnombre_proye] [varchar](60) NOT NULL,
--	[ncod_terce_proye] [numeric](10, 0) NOT NULL,
--	[ccod_estad_proye] [char](2) NOT NULL,
-- CONSTRAINT [pk_ncodigo_proye] PRIMARY KEY CLUSTERED 
--(
--	[ncodigo_proye] ASC
--)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
--) ON [PRIMARY]
--GO

--ALTER TABLE [dbo].[tbl_proyectos]  WITH CHECK ADD  CONSTRAINT [fk_ncod_terce_proye] FOREIGN KEY([ncod_terce_proye])
--REFERENCES [dbo].[tbl_terceros] ([ncodigo_terce])
--GO
--ALTER TABLE [dbo].[tbl_proyectos]  WITH CHECK ADD  CONSTRAINT [fk_ccod_estad_proye] FOREIGN KEY([ccod_estad_proye])
--REFERENCES [dbo].[tbl_estados] ([ccodigo_estad])
--GO

