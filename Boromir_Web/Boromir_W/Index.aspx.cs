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
    public partial class Index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = "", pass = "";
            user = TBuser.Text;
            pass = TBpass.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            String Cnn = "Data Source= .\\SQLEXPRESS;Initial Catalog=Boromir;Integrated Security=True";
            string comando = "SELECT *  FROM tbl_usuarios where cnombre_usua = '" + user.Trim() + "'and ccontraseña_usua = '" + pass.Trim() +"'";
            da = new SqlDataAdapter(comando, Cnn);
            da.Fill(dt);
            if (dt != null && dt.Rows.Count == 1)
            {
                Session["user"] = user;
                Session["pass"] = pass;
                Response.Redirect("Home.aspx");
            }
            else
                Response.Redirect("Error.aspx");
        }
    }
}