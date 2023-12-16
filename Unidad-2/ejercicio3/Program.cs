using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           float velocidad, distancia, resultado;

            Console.WriteLine("ingrese distancia en metros");
            distancia = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese velocidad en metros sobre segundos");
            velocidad = float.Parse(Console.ReadLine());

            resultado = distancia / velocidad; 

            Console.WriteLine("El tiempo en segundos es " + resultado.ToString("0.00"));
        }
    }
}
