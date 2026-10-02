using System;
using System.Collections.Generic;
using DDL.Utilidades;
using System.Text;
using GDocuments.DLL.Tests.Helpers.InputTestData;


namespace GDocuments.DLL.Tests
{
    public class UtilidadesMatematicasTests1
    {
        private readonly UtilidadesMatematicas _calculadora;

        public UtilidadesMatematicasTests1()
        {
            this._calculadora = new UtilidadesMatematicas();
        }

        [Fact]
        public void Sumar_DosNumeros_RetornaSumaCorrecta()
        {
            //Arrange

            // Act
            var resultado = _calculadora.Sumar(2, 3);

            // Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Sumar_DosNumerosNegativos_RetornaSumaCorrecta()
        {
            //Arrange

            // Act
            var resultado = _calculadora.Sumar(-5, -3);

            // Assert
            Assert.Equal(-8, resultado);
        }

        [Fact]
        public void Sumar_DosNumerosDecimales_RetornaSumaCorrecta()
        {
            //Arrange

            // Act
            var resultado = _calculadora.Sumar(-2.5, 1.2);

            // Assert
            Assert.Equal(-1.3, resultado);
        }

        // 22 Métodos de prueba x SUMA. ¿Es racional? ¿Es proporcional?

        [Fact]
        public void EsPar_ShouldBeTrue_IfA2()
        {
            // Arrange
            var a = 2;

            // Act
            var resultado = _calculadora.EsPar(a);

            // Assert
            Assert.True(resultado);
        }

        // División
        [Fact]
        public void Dividir_DosNumerosPositivos_RetornaResultadoCorrecto()
        {
            //Arrange

            var numero1 = 50;
            var numero2 = 25;

            //Assert
            var resultado = _calculadora.Dividir(numero1, numero2);

            // Act
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Dividir_PositivoEntreNegativo_RetornaResultadoCorrecto()
        {
            // Arrange

            var numero1 = 50;
            var numero2 = -10;
            //Assert
            var resultado = _calculadora.Dividir(numero1, numero2);

            //Act
            Assert.Equal(-5, resultado);
        }

        // public static IEnumerable<object[]> DatosSuma => new List<object[]>
        //     {
        //         new object[] {1, 2,3},
        //         new object[] {-5, -3, -8},
        //         new object[] {-7,4,-3},
        //         new object[] {0,0,0},
        //         new object[] {-2.5,1.2,-1.3}
        //         // Se puede agregar mas de un conjunto de datos de prueba
        //     };

        //=====================================================Suma========================================================================
        [Theory]
        [MemberData(nameof(DatosPruebaUtilidadesMatematicas.DatosSuma), MemberType = typeof(DatosPruebaUtilidadesMatematicas))]
        public void Sumar_DevuelveResultadoCorrectoMemberData(double numero1, double numero2, double esperado)
        {
         //Arrange

         //Act
         var resultado = _calculadora.Sumar(numero1, numero2);   

         //Assert
         Assert.Equal(esperado, resultado);
        }

        //===================================================Division======================================================================
        [Theory]
        [MemberData(nameof(DatosPruebaUtilidadesMatematicas.DatosDivision), MemberType = typeof(DatosPruebaUtilidadesMatematicas))]
        public void Dividir_DevuelveResultadoCorrectoMemberData(double numero1, double numero2, double esperado)
        {
         //Arrange

         //Act
         var resultado = _calculadora.Dividir(numero1, numero2);   

         //Assert
         Assert.Equal(esperado, resultado);
        }

        //===================================Dividir entre 0===========================================================================
        [Fact]
        public void Dividir_EntreCero_LanzaDivideByZeroException()
        {
            //Arrange

            var numero1 = 50;
            var numero2 = 0;
            //Assert

            //Act
            var exception = Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(numero1, numero2));
            Assert.Equal("No se puede dividir entre cero", exception.Message);
        }


        //==============================================Multiplicacion======================================================
        [Theory]
        [MemberData(nameof(DatosPruebaUtilidadesMatematicas.DatosMultiplicacion), parameters: new object[] { 2 }, MemberType = typeof(DatosPruebaUtilidadesMatematicas))]
        public void Multiplicar_DevuelveResultadoCorrectoMemberData(double numero1, double numero2, double esperado)
        {
         //Arrange

         //Act
         var resultado = _calculadora.Multiplicar(numero1, numero2);   

         //Assert
         Assert.Equal(esperado, resultado);
        }

    }
}