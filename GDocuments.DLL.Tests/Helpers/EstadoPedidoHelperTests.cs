using DDL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GDocuments.DDL.Tests.Helpers
{
    public class EstadoPedidoHelperFactTests
    {
    [Fact]
    public void ObtenerEstado_Codigo100_RetornaPendiente()
    {
        var resultado = EstadoPedidoHelper.ObtenerEstado(100);
        Assert.Equal("Pendiente", resultado);
    }

    [Fact]
    public void ObtenerEstado_Codigo200_RetornaProcesado()
    {
        var resultado = EstadoPedidoHelper.ObtenerEstado(200);
        Assert.Equal("Procesado", resultado);
    }

    [Fact]
    public void ObtenerEstado_Codigo300_RetornaEnviado()
    {
        var resultado = EstadoPedidoHelper.ObtenerEstado(300);
        Assert.Equal("Enviado", resultado);
    }

    [Fact]
    public void ObtenerEstado_Codigo400_RetornaEntregado()
    {
        var resultado = EstadoPedidoHelper.ObtenerEstado(400);
        Assert.Equal("Entregado", resultado);
    }

    [Fact]
    public void ObtenerEstado_CodigoDesconocido_RetornaEstadoDesconocido()
    {
        var resultado = EstadoPedidoHelper.ObtenerEstado(999);
        Assert.Equal("Estado desconocido", resultado);
    }
    }
}