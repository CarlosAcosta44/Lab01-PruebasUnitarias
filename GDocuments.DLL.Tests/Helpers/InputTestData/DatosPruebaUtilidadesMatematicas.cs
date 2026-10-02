using System;
using System.Collections.Generic;
using System.Text;

namespace GDocuments.DLL.Tests.Helpers.InputTestData
{
    internal class DatosPruebaUtilidadesMatematicas
    {
        public static IEnumerable<object[]> DatosSuma => new List<object[]>
        {
            new object[] { 2, 3, 5 },
            new object[] { -5, -3, -8 },
            new object[] { -7, 4, -3 },
            new object[] { 0, 0, 0 },
            new object[] { -2.5, 1.2, -1.3 }
            // Se puede agregar más de n conjuntos de datos de prueba
        };

        public static IEnumerable<object[]> DatosDivision => new List<object[]>
        {
            new object[] { 50, 25, 2 },
            new object[] { 50, -10, -5 },
            new object[] { -100, -25, 4 },
            new object[] { 0, 5, 0 },
            new object[] { -20.50, 10.25, -2 }
            // Se puede agregar más de n conjuntos de datos de prueba
        };

        public static IEnumerable<object[]> DatosMultiplicacion (int factor)
        {
            yield return new object[] { 50 * factor, 25 * factor, 2500*factor };
            yield return new object[] { 50*factor, -10*factor, -1000*factor };
            yield return new object[] { -100*factor, -25*factor, 5000*factor };
            yield return new object[] { 0*factor, 5*factor, 0*factor };
            yield return new object[] { -20.50*factor, 10.25*factor, -420.25*factor };
            // Se puede agregar más de n conjuntos de datos de prueba
        }
        
    }
}