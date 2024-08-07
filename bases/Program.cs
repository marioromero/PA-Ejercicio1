// Archivo: Program.cs
using System;

namespace Bases
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Variables variables = new Variables();
            Operadores operadores = new Operadores();
            Condicionales condicionales = new Condicionales();
            Ciclos ciclos = new Ciclos();
            Arrays arrays = new Arrays();


            //variables.EjecutarCodigo();  
            //operadores.EjecutarCodigo();
            //condicionales.EjecutarCodigo();
            //ciclos.EjecutarCodigo();
            arrays.EjecutarCodigo();
        }
    }
}