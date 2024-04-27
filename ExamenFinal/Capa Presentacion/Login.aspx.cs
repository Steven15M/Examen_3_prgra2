using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ExamenFinal.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];

            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexión"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @username AND Contraseña = @password", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int userCount = (int)command.ExecuteScalar();
                    if (userCount > 0)
                    {
                        Session["Username"] = username;
                        Response.Redirect("PáginaPrincipal.aspx");
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "loginError", "alert('Usuario o contraseña incorrectos.');", true);
                    }
                }
            }
        }
    }
}
