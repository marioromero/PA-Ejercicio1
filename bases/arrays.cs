using System;

namespace Bases
{
    public class Arrays
    {
        public void EjecutarCodigo()
        {

            // Declaración de un array
            int[] numeros = new int[5];

            // Asignación de valores
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            // Imprimir valores
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Valor en la posición " + i + ": " + numeros[i]);
            }

            // Declaración e inicialización de un array
            string[] nombres = { "Juan", "Pedro", "María", "Ana" };

            // Imprimir valores
            foreach (string nombre in nombres)
            {
                Console.WriteLine("Nombre: " + nombre);
            }

            // Array multidimensional
            int[,] matriz = new int[2, 2];

            // Asignación de valores por consola

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Ingrese un valor para la posición [" + i + "," + j + "]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Imprimir valores
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Valor en la posición [" + i + "," + j + "]: " + matriz[i, j]);
                }
            }

        }
  
    }
}
