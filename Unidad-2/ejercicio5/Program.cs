using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, resultado;

            Console.WriteLine("Ingrese primer nota");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segunda nota");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tercera nota");
            nota3 = float.Parse(Console.ReadLine());

            resultado = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio de notas es " + resultado);
        }
    }
}
