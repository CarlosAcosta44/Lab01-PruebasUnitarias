using System;
using System.Collections.Generic;
using System.Text;
using DDL.Helpers;
using GDocuments.DDL.Tests.Helpers.InputTestData;
using Xunit;

namespace GDocuments.DDL.Tests.Helpers
{
    public class CategoriaEdadHelperTests
    {
        [Theory]
        [ClassData(typeof(CategoriaEdadData))]
        public void ObtenerCategoria_ValoresVariados_RetornaCategoriaCorrecta
            (int edad, string esperado)
        {
            //Arrange
            //Act
            var resultado = CategoriaEdadHelper.ObtenerCategoria(edad);
            
            //Assert

            Assert.Equal(esperado, resultado);
        }
    }
}