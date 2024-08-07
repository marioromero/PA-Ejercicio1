using System;

namespace Bases
{
    public class Ciclos
    {
        public void EjecutarCodigo()
        {

            // Ciclo for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor de i: " + i);
            }

            // Ciclo while
            int j = 0;

            while (j < 5)
            {
                Console.WriteLine("Valor de j: " + j);
                j++;
            }

            // Ciclo do-while
            int k = 0;

            do
            {
                Console.WriteLine("Valor de k: " + k);
                k++;
            } while (k < 5);

            // Ciclo foreach

            string[] nombres = { "Juan", "Pedro", "María", "Ana" };

            foreach (string nombre in nombres)
            {
                Console.WriteLine("Nombre: " + nombre);
            }

        }
  
    }
}
