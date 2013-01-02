using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Web.Services;


namespace Boromir_W
{
    public partial class Productos : System.Web.UI.Page
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
                    SqlConnection myConnection;
                    SqlDataAdapter myCommand;
                    String Base = "Data Source= .\\SQLEXPRESS;Initial Catalog=Boromir;Integrated Security=True";
                    myConnection = new SqlConnection(Base);

                    string consulta = "select ncodigo_produ Codigo, cnombre_produ Producto,nprecio_venta_produ Precio, nimpuesto_produ IVA,(nprecio_venta_produ + (nprecio_venta_produ * nimpuesto_produ / 100)) Total from tbl_productos";

                    string flt = "", obj = "", scr = "";

                    if (Request.QueryString["Flt"] != null)
                        flt = Request.QueryString["Flt"];

                    if (Request.QueryString["Obj"] != null)
                    {
                        obj = Request.QueryString["Obj"];
                        switch (obj)
                        {
                            case "marca":
                                consulta = consulta + " where ccod_marca_produ = '" + flt + "'";
                                break;
                            case "categ":
                                consulta = consulta + " where ccod_categ_produ = '" + flt + "'";
                                break;

                        }
                    }
                    if (Request.QueryString["scr"] != null)
                    {
                        scr = Request.QueryString["scr"];
                        if (string.IsNullOrEmpty(scr))
                            consulta = "select ncodigo_produ Codigo, cnombre_produ Producto from tbl_productos";
                        else
                            consulta = consulta + " where cnombre_produ like '%" + scr.Trim() + "%'";
                    }
                    myCommand = new SqlDataAdapter(consulta, myConnection);
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds);
                    Dt_productos.DataSourceID = null;
                    Dt_productos.DataSource = ds;
                    Dt_productos.DataBind();

                } 
                else
                { Response.Redirect("Error.aspx"); }
            }
            else
            {
                if (string.IsNullOrEmpty(Session["user"].ToString()) || string.IsNullOrEmpty(Session["pass"].ToString()))
                    Response.Redirect("Error.aspx");
            }
        }

        protected void Dt_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var = sender.ToString();


            if (Session["datos"] != null)
            {
                if (Session["datos"] != "")
                    Carro = Session["datos"] as DataTable;
            }

            int index = Convert.ToInt16(Dt_productos.SelectedIndex.ToString());  
      
            TextBox txt = new TextBox();            
            txt = (TextBox)(Dt_productos.Rows[index].Cells[2].Controls[1]);
            if (string.IsNullOrEmpty(txt.Text))
                txt.Text = "1";

            string cantidad = txt.Text;
            string codigo = Dt_productos.Rows[index].Cells[3].Text;
            string nombre = Dt_productos.Rows[index].Cells[4].Text;
            string precio = Dt_productos.Rows[index].Cells[7].Text;
            if (Carro.Rows.Count >= 1)
            {
                add(codigo, nombre, cantidad,precio);
            }
            else
            {
                Carro.Columns.Add(new DataColumn("Cantidad"));
                Carro.Columns.Add(new DataColumn("Codigo"));
                Carro.Columns.Add(new DataColumn("Producto"));
                Carro.Columns.Add(new DataColumn("Precio"));
                add(codigo, nombre,cantidad,precio);               
            }          

        }

        protected void add(string codigo,string nombre,string cantidad, string precio)
        {
            DataRow Row = Carro.NewRow();
            Row["Cantidad"] = cantidad;
            Row["Codigo"] = codigo;
            Row["Producto"] = nombre;
            Row["Precio"] = (Convert.ToDouble(precio) * Convert.ToDouble(cantidad)).ToString();
            Carro.Rows.Add(Row);
            Session["datos"] = Carro;
            Session["ctd"] = Carro.Rows.Count.ToString();
            Master.LbCantiad = Carro.Rows.Count.ToString();
          
        }

        
    }
}