using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Boromir_W
{
    public class Seguridad
    {
        public bool login(string user,string pass)
        {
            bool rta = false;
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            String Cnn = "Data Source= .\\SQLEXPRESS;Initial Catalog=Boromir;Integrated Security=True";
            string comando = "SELECT *  FROM tbl_usuarios where cnombre_usua = '" + user.Trim() + "'and ccontraseña_usua = '" + pass.Trim() + "'";
            da = new SqlDataAdapter(comando, Cnn);
            da.Fill(dt);
            if (dt != null && dt.Rows.Count == 1)
            {
                rta = true;

            }
            else
                rta = false;

            return rta;
        }
        public string pedido()
        {
            DataTable datos = new DataTable();
            string codigo = "";
            string comando = "select  ncodigo_pedid from tbl_pedidos order by ncodigo_pedid desc";
            datos = conexion(comando);
            if (datos.Rows.Count > 0 && datos != null)
                codigo = datos.Rows[0][0].ToString();
            else
                codigo = "0";
            return codigo;
        }
        public Int64 tercero(string user)
        {
            DataTable datos = new DataTable();
            Int64 tercero = 0;
            string comando = "select  ncodigo_terce,ncod_ubic_usua from tbl_terceros, tbl_usuarios where cnombre_usua = '" + user.Trim() + "' and ncodigo_terce = ncod_terce_usua";
            datos = conexion(comando);
            tercero = Convert.ToInt64(datos.Rows[0][0].ToString());
            return tercero;
        }
        public DataTable conexion (string comando)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();  
            String Cnn = "Data Source= .\\SQLEXPRESS;Initial Catalog=Boromir;Integrated Security=True";
            da = new SqlDataAdapter(comando, Cnn);
            da.Fill(dt);
            return dt;
        }

     
    }
}