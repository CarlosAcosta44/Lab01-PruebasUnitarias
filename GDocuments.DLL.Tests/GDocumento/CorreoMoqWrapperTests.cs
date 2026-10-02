using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using System.Net.Mail;
using DDL;


namespace GDocuments.DLL.Tests.GDocumento
{
    public class CorreoMoqWrapperTests
    {
        [Fact]
        public void Enviar_LlamaAlSmtpConMensajeCorrecto()
        {
            var mockSmtp = new Mock<ISmtpClientWrapper>();
            var mockDoc = new Mock<IDocumento>();
            mockDoc.Setup(d => d.GenerarDocumento()).Returns("TITULO_CUERPO_FIRMA_TEST");

            var sut = new Correo(mockSmtp.Object);
            sut.Enviar(mockDoc.Object, "acerolopezandresfelipe@gmail.com");

            mockSmtp.Verify(s => s.Send(It.Is<MailMessage>(m =>
                m.To[0].Address == "destino@test.com" &&
                m.From.Address == "vladimir.cortes.a@gmail.com" &&
                m.Subject == "Curso de Test Unitarios" &&
                m.Body == "DOC_TEST"
            )), Times.Once);
        }
    }
}
