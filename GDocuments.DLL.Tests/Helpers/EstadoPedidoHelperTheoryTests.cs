using System;
using System.Collections.Generic;
using System.Text;
using DDL.Helpers;
using Xunit;

namespace GDocuments.DDL.Tests.Helpers
{
    public class EstadoPedidoHelperTheoryTests
    {
        [Theory]
        [InlineData(100, "Pendiente")]
        [InlineData(200, "Procesado")]
        [InlineData(300, "Enviado")]
        [InlineData(400, "Entregado")]
        [InlineData(999, "Estado desconocido")]

        public void ObtenerEstado_Combinaciones_RetornaMensajeCorrecto(int codigo, string estado)
        {
            //Arrange

            //Act
            var resultado = EstadoPedidoHelper.ObtenerEstado(codigo);

            //Assert
            Assert.Equal(estado, resultado);
        }
    }
}
