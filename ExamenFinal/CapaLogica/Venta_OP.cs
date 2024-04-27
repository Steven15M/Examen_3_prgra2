using System;
using System.Collections.Generic;
using ExamenFinal.CapaDatos;

namespace ExamenFinalIBD.sql
{
    public class Venta_OP
    {
        public bool AgregarVenta(int idAgente, int idCliente, int idCasa, DateTime fecha)
        {
            ClsVenta nuevaVenta = new ClsVenta
            {
                ID_Agente = idAgente,
                ID_Cliente = idCliente,
                ID_Casa = idCasa,
                Fecha = fecha
            };

            return ClsVenta.AgregarVenta(nuevaVenta);
        }

        public bool ModificarVenta(int idVenta, int idAgente, int idCliente, int idCasa, DateTime fecha)
        {
            ClsVenta ventaExistente = new ClsVenta
            {
                ID = idVenta,
                ID_Agente = idAgente,
                ID_Cliente = idCliente,
                ID_Casa = idCasa,
                Fecha = fecha
            };

            return ClsVenta.ModificarVenta(ventaExistente);
        }

        public bool EliminarVenta(int idVenta)
        {
            return ClsVenta.EliminarVenta(idVenta);
        }

        public List<ClsVenta> ObtenerVentas()
        {
            return ClsVenta.ObtenerVentas();
        }
    }
}
