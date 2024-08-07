using System;

namespace Bases
{
    public class Operadores
    {
        public void EjecutarCodigo()
        {
            int a = 10;
            int b = 5;

            // Operadores aritméticos
            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            int division = a / b;
            int modulo = a % b;

            // Imprimir resultados
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicación: " + multiplicacion);
            Console.WriteLine("División: " + division);
            Console.WriteLine("Módulo: " + modulo);

            // Operadores de comparación
            bool esMayor = a > b;
            bool esIgual = a == b;

            // Imprimir resultados de comparación
            Console.WriteLine("¿Es 'a' mayor que 'b'?: " + esMayor);
            Console.WriteLine("¿'a' es igual a 'b'?: " + esIgual);

            // Operadores lógicos
            bool resultadoLogico = (a > b) && (a > 0);

            // Imprimir resultado lógico
            Console.WriteLine("Resultado lógico: " + resultadoLogico);
        }
    }
}
