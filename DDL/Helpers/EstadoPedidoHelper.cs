using System;
using System.Collections.Generic;
using System.Text;

namespace DDL.Helpers
{
    public class EstadoPedidoHelper
    {
        public static string ObtenerEstado(int codigo)
        {
            switch (codigo)
            {
                case 100:
                    return "Pendiente";
                case 200:
                    return "Procesado";
                case 300:
                    return "Enviado";
                case 400:
                    return "Entregado";
                default:
                    return "Estado desconocido";
            }
        }
    }
}