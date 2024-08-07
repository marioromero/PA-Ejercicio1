using System;

namespace Bases
{
    //nombre de clase
    public class Variables
    {

        //método
        public void EjecutarCodigo()
        {
            // Definición de variables
            int edad = 30;
            double altura = 1.75;
            string nombre = "Juan";
            bool esEstudiante = false;

            // Definición de constantes
            const double PI = 3.1416;
            const string CURSO = ".NET 7";

            // Imprimir valores en la consola
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("¿Es estudiante?: " + esEstudiante);
            Console.WriteLine("Valor de PI: " + PI);
            Console.WriteLine("Curso: " + CURSO);
        }
    }
}
