using System;

namespace punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

            int a, b, c, d;

            Console.WriteLine("Ingrese un primer número, por favor");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número, por favor");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un tercer numero, por favor");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un cuarto número, por favor");
            d = int.Parse(Console.ReadLine());

            if(a>b && b>c && c>d) {
                Console.WriteLine("Los números se encuentran ordenados de forma decreciente");
            }

            Console.WriteLine("Los números no se encuentran ordenados de manera decreciente");
        }
    }
}
