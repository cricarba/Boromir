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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            rta = login.login(user,pass);
            if (rta)
            { }
            else
            { Response.Redirect("Error.aspx"); }
        }
    }
}