USE Boromir
go
--**Estados
insert into tbl_estados 
(ccodigo_estad ,cnombre_estad )
values
('AC','Activo')
insert into tbl_estados 
(ccodigo_estad ,cnombre_estad )
values
('AN','Anulado')
insert into tbl_estados 
(ccodigo_estad ,cnombre_estad )
values
('CF','Confirmado')
--**Modulos
insert into tbl_modulos
(ccodigo_modul, cnombre_modul, nuno_modul,ndos_modul,
ntres_modul,ncuatro_modul,ncinco_modul,nseis_modul)
values 
('ADMIN','ADMINISTRACION',0,9,0,9,0,4)
insert into tbl_modulos
(ccodigo_modul, cnombre_modul, nuno_modul,ndos_modul,
ntres_modul,ncuatro_modul,ncinco_modul,nseis_modul)
values 
('INVEN','INVENTARIOS',0,9,0,9,0,4)
insert into tbl_modulos
(ccodigo_modul, cnombre_modul, nuno_modul,ndos_modul,
ntres_modul,ncuatro_modul,ncinco_modul,nseis_modul)
values 
('FACTU','FACTURACION',0,9,0,9,0,4)
insert into tbl_modulos
(ccodigo_modul, cnombre_modul, nuno_modul,ndos_modul,
ntres_modul,ncuatro_modul,ncinco_modul,nseis_modul)
values 
('REPOR','REPORTES',0,9,0,9,0,4)
insert into tbl_modulos
(ccodigo_modul, cnombre_modul, nuno_modul,ndos_modul,
ntres_modul,ncuatro_modul,ncinco_modul,nseis_modul)
values 
('SEGUR','SEGURIDAD',0,9,0,9,0,4)
insert into tbl_modulos
(ccodigo_modul, cnombre_modul, nuno_modul,ndos_modul,
ntres_modul,ncuatro_modul,ncinco_modul,nseis_modul)
values 
('AYUDA','AYUDA',0,9,0,9,0,4)
--**Aplicaciones
insert into tbl_aplicaciones
(ccodigo_aplic, cnombre_aplic, ccod_modul_aplic)
values 
('PRODU','PRODUCTOS','INVEN')
insert into tbl_aplicaciones
(ccodigo_aplic, cnombre_aplic, ccod_modul_aplic)
values 
('MOVIM','MOVIMIENTOS','INVEN')
insert into tbl_aplicaciones
(ccodigo_aplic, cnombre_aplic, ccod_modul_aplic)
values 
('SALDO','SALDOS','INVEN')
insert into tbl_aplicaciones
(ccodigo_aplic, cnombre_aplic, ccod_modul_aplic)
values 
('PEDID','PEDIDOS','FACTU')
insert into tbl_aplicaciones
(ccodigo_aplic, cnombre_aplic, ccod_modul_aplic)
values 
('FACTU','FACTURAS','FACTU')
insert into tbl_aplicaciones
(ccodigo_aplic, cnombre_aplic, ccod_modul_aplic)
values 
('COTIZ','COTIZACIONES','FACTU')
insert into tbl_aplicaciones
(ccodigo_aplic, cnombre_aplic, ccod_modul_aplic)
values 
('RESER','RESERVAS','FACTU')
insert into tbl_aplicaciones
(ccodigo_aplic, cnombre_aplic, ccod_modul_aplic)
values 
('ORDEN','ORDENES','FACTU')
insert into tbl_aplicaciones
(ccodigo_aplic, cnombre_aplic, ccod_modul_aplic)
values 
('CONCE','CONCEPTOS','ADMIN')
--**Conceptos
insert into tbl_conceptos
(ccodigo_conce,cnombre_conce,ccod_aplic_conce,caccion_conce)
values
('FR','FACTURA RESERVA','FACTU','RESTA')
insert into tbl_conceptos
(ccodigo_conce,cnombre_conce,ccod_aplic_conce,caccion_conce)
values
('FV','FACTURA DE VENTA','FACTU','RESTA')
insert into tbl_conceptos
(ccodigo_conce,cnombre_conce,ccod_aplic_conce,caccion_conce)
values
('CT','COTIZACIONES','COTIZ','NULO')
insert into tbl_conceptos
(ccodigo_conce,cnombre_conce,ccod_aplic_conce,caccion_conce)
values
('EI','ENTRADAS DE INVENTARIO','MOVIM','SUMA')
insert into tbl_conceptos
(ccodigo_conce,cnombre_conce,ccod_aplic_conce,caccion_conce)
values
('SI','SALIDAS DE INVENTARIO','MOVIM','RESTA')
insert into tbl_conceptos
(ccodigo_conce,cnombre_conce,ccod_aplic_conce,caccion_conce)
values
('DV','DEVOLUCIONES','FACTU','SUMA')
insert into tbl_conceptos
(ccodigo_conce,cnombre_conce,ccod_aplic_conce,caccion_conce)
values
('OC','ORDENES DE COMPRA','ORDEN','NULO')
--**lOCALIZAVION
insert into tbl_ciudad (
ncodigo_ciudad, cnombre_ciudad)
values (0,'Ciudad Indefinida')
insert into tbl_zonas (
ncodigo_zona, cnombre_zona,ncod_ciudad_zona )
values (0,'Zona Indeinida',0)
--**Perfil
INSERT into tbl_perfiles 
(ncodigo_perfil ,cnombre_perfil , ccrear_perfil , cconsultar_perfil ,  cmodificar_perfil ,  cconfirmar_perfil,creversar_perfil, canular_perfil ,cimprimir_perfil,csql_perfil,ccod_estad_perfil )
values
(1,'Administrador','SI','SI','SI','SI','SI','SI','SI','SI','AC')
INSERT INTO tbl_aplicperfil
(ncod_perfil_aplicperfil,documentos_admon,conceptos_admon,escenarios_admon,costos_admon,cuidades_admon,zonas_admon,terceros_admon,ubicaciones_admon,escenxubica_admon,tblcostos_admon,productos_inven,movimientos_inven,saldos_inven,ordenes_inven,pedidos_factu,facturas_factu,cotizaciones_factu,reservas_factu,administraivos_report,inventarios_report,facturacion_report,perfiles_segur,usuarios_segur,claves_segur,empresa_segur,licencia_segur,auditoria_segur,proyectos_admon )
values(1,'SI','SI', 'SI', 'SI', 'SI','SI', 'SI', 'SI', 'SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI')

--INSERT into tbl_perfiles 
--(ncodigo_perfil ,cnombre_perfil , ccrear_perfil , cconsultar_perfil ,  cmodificar_perfil ,  cconfirmar_perfil,creversar_perfil, canular_perfil ,cimprimir_perfil,csql_perfil,ccod_estad_perfil )
--values
--(1,'Administrador','SI','SI','SI','SI','SI','SI','SI','NO','AC')
--INSERT INTO tbl_aplicperfil
--(ncod_perfil_aplicperfil,documentos_admon,conceptos_admon,escenarios_admon,costos_admon,cuidades_admon,zonas_admon,terceros_admon,ubicaciones_admon,escenxubica_admon,tblcostos_admon,productos_inven,movimientos_inven,saldos_inven,facturas_factu,cotizaciones_factu,reservas_factu,administraivos_report,inventarios_report,facturacion_report,perfiles_segur,usuarios_segur,claves_segur,empresa_segur)
--values(1,'SI','SI', 'SI', 'SI', 'SI','SI', 'SI', 'SI', 'SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI','SI')
--**documentos
insert into tbl_tipodoc
(ccodigo_tipodoc,cnombre_tipodoc)
values
('IN','Indefinido')
--**tercero
insert into tbl_terceros 
(ncodigo_terce,ccod_tipodoc_terce,cnombre_terce,cnombre2_terce,capellido_terce,capellido2_terce,ntelefono_terce,
ncelular_terce,cdireccion_terce,ncod_ciudad_terce,cemail_terce,ncliente_terce,nproveedor_terce,nempleado_terce,ccod_estad_terce)
values
(0,'IN','Usuario','','Indefinido','',0,0,'0',
0,'email@empresa.com',1,1,1,'AC')
--**ubicacion
insert into tbl_ubicaciones
(ncodigo_ubica,cnombre_ubica,cdireccion_ubica,ntelefono_ubica,ncelular_ubica,ccorreo_ubica,
ncod_ciudad_ubica,ncod_zona_ubica,ncod_admon_ubica,ncobro_ubica)
values
(0,'Ubicacion Indefinida','',0,0,'',0,0,0,0)
--**usuario

INSERT INTO tbl_tipocosto
(ccodigo_tcosto,ncod_ubica_tcosto,mvalor_tcosto)
values
('I',0,0)
insert into tbl_tescenarios
(ccodigo_tescen ,cnombre_tescen)
values
('IN','Tipo Escenario Indefinido')
insert into tbl_escenarios
(ncodigo_escen,cnombre_escen,ncod_ubica_escen,ctipo_escen,ccod_estad_escen,ccod_tcosto_tescen)
values
(0,'Escenario Indefinido',0,'IN','AC','I')
insert into tbl_costoturno 
(ncod_ubica_costurno,ccod_tescen_costurno,cdia_costurno,chora_costurno,ccod_tcosto_costurno)
values
(0,'IN',1,'00:00','I')


insert into tbl_facturas
(ncodigo_factu,ncod_ubic_factu,ncod_terce_factu,ffecha_factu,ccod_conce_factu,ccod_estad_factu,nneto_factu,ndescuento_factu,nimpuesto_factu,ntotal_factu) values 
(0,0,0,'Lunes, 01 de enero de 1900','FV','AN',0,0,0,0)

INSERT INTO tbl_reservas
(ncodigo_reser ,ncod_ubic_reser ,ffecha_reser ,hhora_reser,ncod_escen_reser ,ncod_terce_reser,ccod_tcosto_reser,ccod_estad_reser)
values
(0,0,'Lunes, 01 de enero de 1900','12:00',0,0,'I','AN')



