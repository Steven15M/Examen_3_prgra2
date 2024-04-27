using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ExamenFinal.CapaDatos
{
    public class ClsCliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public static List<ClsCliente> ObtenerClientes()
        {
            List<ClsCliente> listaClientes = new List<ClsCliente>();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes", con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listaClientes.Add(new ClsCliente
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString(),
                            Email = dr["Email"].ToString(),
                            Telefono = dr["Telefono"].ToString()
                        });
                    }
                }
            }

            return listaClientes;
        }

        // Métodos para agregar, modificar y eliminar clientes
    }

    public class ClsAgente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public static List<ClsAgente> ObtenerAgentes()
        {
            List<ClsAgente> listaAgentes = new List<ClsAgente>();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Agentes", con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listaAgentes.Add(new ClsAgente
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString(),
                            Email = dr["Email"].ToString(),
                            Telefono = dr["Telefono"].ToString()
                        });
                    }
                }
            }

            return listaAgentes;
        }

        // Métodos para agregar, modificar y eliminar agentes
    }
}
