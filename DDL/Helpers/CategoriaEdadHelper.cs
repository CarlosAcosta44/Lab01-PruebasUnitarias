using System;
using System.Collections.Generic;
using System.Text;

namespace DDL.Helpers
{
    public static class CategoriaEdadHelper
    {
        public static string ObtenerCategoria(int edad)
        {
            if (edad < 0)
                return "Edad Invalida";
            if (edad <= 12)
                return "Niño";
            if (edad <= 17)
                return "Adolecente";
            if (edad <= 64)
                return "Adulto";
            
            return "Adulto Mayor";
                
        }
    }
}