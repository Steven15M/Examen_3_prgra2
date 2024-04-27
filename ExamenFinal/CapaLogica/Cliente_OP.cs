using System;
using System.Collections.Generic;
using ExamenFinal.CapaDatos; 

namespace ExamenFinalIBD.sql
{
    public class Cliente_OP
    {
        public bool AgregarCliente(string nombre, string email, string telefono)
        {
            ClsCliente nuevoCliente = new ClsCliente
            {
                Nombre = nombre,
                Email = email,
                Telefono = telefono
            };

            return ClsCliente.AgregarCliente(nuevoCliente);
        }

        public bool ModificarCliente(int id, string nombre, string email, string telefono)
        {
            ClsCliente clienteExistente = new ClsCliente
            {
                ID = id,
                Nombre = nombre,
                Email = email,
                Telefono = telefono
            };

            return ClsCliente.ModificarCliente(clienteExistente);
        }

        public bool EliminarCliente(int id)
        {
            return ClsCliente.EliminarCliente(id);
        }

        public List<ClsCliente> ObtenerClientes()
        {
            return ClsCliente.ObtenerClientes();
        }
    }
}
