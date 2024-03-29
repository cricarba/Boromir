﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Boromir_W
{
    public partial class Pedido : System.Web.UI.Page
    {
 
        DataTable Carro = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            { //Esto ocurre solo la primera vez que se carga tu página
                string user = "", pass = "";
                bool rta = false;
                if (Session["user"] != null)
                    user = Session["user"].ToString();
                else
                    user = "";
                if (Session["pass"] != null)
                    pass = Session["pass"].ToString();
                else
                    pass = "";

                Seguridad login = new Seguridad();
                rta = login.login(user, pass);
                if (rta)
                {
                    if (Session["datos"] != null)
                    {
                        Carro = Session["datos"] as DataTable;
                        DT_Carro.DataSourceID = null;
                        DT_Carro.DataSource = Carro;
                        DT_Carro.DataBind();
                    }

                    if (Session["ctd"] != null)
                    {
                        Master.LbCantiad = Session["ctd"].ToString();
                    }
                   
                }
                else
                { Response.Redirect("Error.aspx"); }
            }
            else
            {
                if (!string.IsNullOrEmpty(Session["user"].ToString()) || !string.IsNullOrEmpty(Session["pass"].ToString()))//si se salio y quiere volver con el boto atras
                {
                    if (Session["datos"] != null)
                    {
                        Carro = Session["datos"] as DataTable;
                        DT_Carro.DataSourceID = null;
                        DT_Carro.DataSource = Carro;
                        DT_Carro.DataBind();
                    }

                    if (Session["ctd"] != null)
                    {
                        Master.LbCantiad = Session["ctd"].ToString();
                    }
                }
                else
                {
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void DT_Carro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt16(DT_Carro.SelectedIndex.ToString());
            Carro.Rows[index].Delete();
            Session["datos"] = Carro;
            Session["ctd"] = Carro.Rows.Count.ToString();
            Master.LbCantiad = Session["ctd"].ToString();
            Response.Redirect("Pedido.aspx");
         }

        protected void Confirmar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {       
                Int64 ncodigo_pedid = 0;
                Seguridad conex = new Seguridad();            
                Int64 tercero;
                tercero = conex.tercero(Session["user"].ToString());
                String pedido;
                pedido = conex.pedido();
                ncodigo_pedid = Convert.ToInt64(pedido) + 1;
                DataTable datos = new DataTable();
                string comando = "insert into tbl_pedidos (ncodigo_pedid,ncod_ubic_pedid,ncod_terce_pedid,ffecha_pedid,ccod_conce_pedid,ccod_estad_pedid,nneto_pedid,nimpuesto_pedid,ndescuento_pedid,ntotal_pedid,cobservacion_pedid) values " +
                    "('" + ncodigo_pedid + "','0','" + tercero.ToString() + "','" + DateTime.Now.ToString() + "','PD','AC',0,0,0,0,'')";
                datos = conex.conexion(comando);
                for (int i = 0; i < Carro.Rows.Count; i++)
                {
                    string comando2 = "exec proc_detalles_movimientos "  + ncodigo_pedid + ",'PD'," + Carro.Rows[i]["Codigo"].ToString() + ", 0 ,'"  + DateTime.Now.ToString() + "'," + Carro.Rows[i]["Cantidad"].ToString()+ ", " + Carro.Rows[i]["Precio"].ToString() + ", 0 , 0 ,'agregar'";
                    datos = conex.conexion(comando2);
                }
                Lbpedido.Text = "Pedido Numero: " + ncodigo_pedid.ToString();
                Confirmar.Visible = false;
                Cancelar.Visible = false;
            }
            catch
            {
                Lbpedido.Text = "Error Creando Pedido";
            }
        }
    }
}