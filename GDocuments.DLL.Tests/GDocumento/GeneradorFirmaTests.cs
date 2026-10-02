using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using Moq;
using DDL;

namespace GDocuments.DLL.Tests.GDocuments;

public class GeneradorFirmaTests
{
    [Fact]
    public void Firma_RetornaTextFirma()
    {
        //Arrange
        GeneradorFirma firma = new GeneradorFirma();
        
        //Act
        var resultado = firma.Firma();
        
        //Assert
        Assert.Equal("firmado por Carlos Acosta", resultado); ;
    }

    public void GenerarDocumento_ConstruyeDocumentoCorrectamente()
    {
        //se mockea IGeneradorFirma para controlar la firma
        var mockFirma = new Mock<IGeneradorFirma>();
        mockFirma.Setup(f => f.Firma()).Returns("FIRMA_TEST");

        var documento = new Documento(mockFirma.Object);
        documento.EscribirTitulo("TITULO_");
        documento.EscribirCuerpo("CUERPO_");
        
        var resultado = documento.GenerarDocumento();
        
        //Se valida la concatacion final
        Assert.Equal("TITULO_CUERPO_FIRMA_TEST", resultado);
        //Se verifica que firma
        mockFirma.Verify(f => f.Firma(), Times.Once);
    }
    
}