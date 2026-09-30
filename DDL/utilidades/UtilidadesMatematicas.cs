using System;
using System.Collections.Generic;
using System.Text;

namespace DDL.Utilidades
{
    public class UtilidadesMatematicas
    {
        public double Sumar(double a, double b)
        { return a + b; }

        public double Restar(double a, double b)
        { return a - b; }

        public double Multiplicar(double a, double b)
        { return a * b; }

        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir entre cero");

                return a / b;
        }


        public double Modulo(double a, double b)
        { return a % b; }


        public double Potencia(double baseNum, double exponente)
        { 
            return Math.Pow(baseNum, exponente); 
        }

        public bool EsPar(double a)
        {
            if(a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}