using System;

namespace Bases
{
    public class Condicionales
    {
        public void EjecutarCodigo()
        {
            int a = 10;
            int b = 5;
            int c = 10;

            // Condicionales
            if (a > b)
            {
                Console.WriteLine("a es mayor que b");
            }
            else if (a == b)
            {
                Console.WriteLine("a es igual a b");
            }
            else
            {
                Console.WriteLine("a es menor que b");
            }

            // Condicionales anidados
            if (a == c)
            {
                if (a > b)
                {
                    Console.WriteLine("a es igual a c y mayor que b");
                }
                else
                {
                    Console.WriteLine("a es igual a c y menor que b");
                }
            }
            else
            {
                Console.WriteLine("a es diferente de c");
            }

            // Operador ternario
            string mensaje = a > b ? "a es mayor que b" : "a es menor que b";

            switch (a)
            {
                case 1:
                    Console.WriteLine("El valor de a es 1");
                    break;
                case 2:
                    Console.WriteLine("El valor de a es 2");
                    break;
                case 3:
                    Console.WriteLine("El valor de a es 3");
                    break;
                default:
                    Console.WriteLine("El valor de a es diferente de 1, 2 y 3");
                    break;
            }

        }
    }
}
