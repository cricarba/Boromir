using System;
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
    public partial class ProductoUp : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            SqlConnection myConnection;
            String Base = "Data Source= .\\SQLEXPRESS;Initial Catalog=Boromir;Integrated Security=True";
            myConnection = new SqlConnection(Base);

            string consulta = "select  ncodigo_produ, cnombre_produ,ccod_marca_produ,nprecio_venta_produ,nimpuesto_produ,ndescuento_produ,ccod_color_produ,ccod_und_produ,cobservacion_produ from tbl_productos";

            string cdg="" ;
            if (Request.QueryString["cdg"] != null)
                cdg = Request.QueryString["cdg"].ToString();

            consulta = consulta + " where ncodigo_produ = " + cdg ;
            SqlDataAdapter da;
            String Cnn = "Data Source= .\\SQLEXPRESS;Initial Catalog=Boromir;Integrated Security=True";
            da = new SqlDataAdapter(consulta, Cnn);            
            da.Fill(dt);
            Lbnombre.Text = dt.Rows[0]["ncodigo_produ"].ToString();
            Lbcodigo.Text = dt.Rows[0]["cnombre_produ"].ToString();
            Lbcategoria.Text = dt.Rows[0]["ccod_marca_produ"].ToString();
            lbprecio.Text = dt.Rows[0]["nprecio_venta_produ"].ToString() ;
            Lbiva.Text = dt.Rows[0]["nimpuesto_produ"].ToString();
            Lbdescuento.Text = dt.Rows[0]["ndescuento_produ"].ToString();
            Lbcolor.Text = dt.Rows[0]["ccod_color_produ"].ToString();
            Lbund.Text = dt.Rows[0]["ccod_und_produ"].ToString();
            Lbobs.Text = dt.Rows[0]["cobservacion_produ"].ToString();          
           
        }
    }
}