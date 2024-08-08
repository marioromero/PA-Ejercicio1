using System;

namespace Bases
{
    public class EjericioEnClases
    {
        public void EjecutarCodigo()
        {
            int[] conteoCalificaciones = new int[10];
            int sumaCalificaciones = 0;
            int totalClientes = 20;

            for (int i = 0; i < totalClientes; i++)
            {
                int calificacion = 0;
                bool calificacionValida = false;

                while (!calificacionValida)
                {
                    try
                    {
                        Console.Write($"Ingrese la calificación del cliente {i + 1} (1-10): ");
                        calificacion = int.Parse(Console.ReadLine());

                        if (calificacion >= 1 && calificacion <= 10)
                        {
                            calificacionValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Error: La calificación debe estar entre 1 y 10.");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Debe ingresar un número válido.");
                    }
                }

                conteoCalificaciones[calificacion - 1]++;
                sumaCalificaciones += calificacion;
            }

            Console.WriteLine("");
            Console.WriteLine("Resultados de la encuesta:");

            for (int i = 0; i < conteoCalificaciones.Length; i++)
            {
                Console.WriteLine($"Calificaciones de {i + 1}: {conteoCalificaciones[i]} clientes");
            }

            double promedio = (double)sumaCalificaciones / totalClientes;
            Console.WriteLine("");
            Console.WriteLine($"Promedio de calificaciones: {promedio:F2}");
        }
    }
}
