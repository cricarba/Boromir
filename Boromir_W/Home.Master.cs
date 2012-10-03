using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Boromir_W
{
    public partial class Home : System.Web.UI.MasterPage
    {

        DataTable datos = new DataTable();
        DataTable dt = new DataTable();       
        string objeto;
        Seguridad conex = new Seguridad();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { //Esto ocurre solo la primera vez que se carga tu página
                if (Session["Obj"] == "marca")
                    marca();
                else
                    categoria();

                if (Session["ctd"] != null)
                    LbCantiad = Session["ctd"].ToString();
            }
            else
            {
                
            }
        }

        public string LbCantiad
        {
            get 
            {
                return LbCtd.Text;
            }
            set
            {
                LbCtd.Text = value;

            }
        }

        protected void Btn_Click1(object sender, EventArgs e)
        {
            marca();
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            categoria();
        }

        protected void Filtro_1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
            int index = Convert.ToInt16(Filtro_1.SelectedIndex.ToString());
            string flt = Filtro_1.Rows[index].Cells[1].Text;           
            Response.Redirect("Productos.aspx?Flt=" + flt.ToLower() + "&Obj=" + Session["Obj"].ToString().ToLower());
        }


        protected void categoria()
        {
            string comando = "SELECT cnombre_categ Categoria FROM tbl_categorias";
            datos = conex.conexion(comando);
            Filtro_1.DataSourceID = null;
            Filtro_1.DataSource = datos;
            Filtro_1.DataBind();
            objeto = "categ";
            Session["Obj"] = objeto;
            Session["categ"] = datos;
        }

        protected void marca()
        {
            string comando = "SELECT cnombre_marca Marca FROM tbl_marcas";
            datos = conex.conexion(comando);
            Filtro_1.DataSourceID = null;
            Filtro_1.DataSource = datos;
            Filtro_1.DataBind();
            objeto = "marca";
            Session["Obj"] = objeto;
            Session["categ"] = datos;
        }

        protected void Carrito_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Pedido.aspx");
        }

        protected void ImgBuscar_Click(object sender, ImageClickEventArgs e)
        {
            string buscar = TxtBuscar.Text;
            Response.Redirect("Productos.aspx?scr=" + buscar);
        }

        protected void Btsalir_Click(object sender, EventArgs e)
        {
            Session["Obj"] = "";
            Session["categ"] = "";
            Session["ctd"] = "";
            Session["user"] = "";
            Session["pass"] = "";
            Session["datos"] = "";
            Response.Redirect("Index.aspx");
        }
     
        
    
    }
}