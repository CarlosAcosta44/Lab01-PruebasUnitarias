using DDL.Utilidades;

namespace GDocuments.DLL.Tests
{
    public class ClassEjemploTests
    {
        [Fact]
        public void SiempreDevuelvoTrue_RetornaTrue()
        {
            // Arranque
                var classEjemplo = new ClassEjemplo();
            // Act
                var resultado = classEjemplo.SiempreDevuelvoTrue();
            // Assert
            Assert.True(resultado);
        }
    }
}