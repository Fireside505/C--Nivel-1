using System;

namespace punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int producto, suma, a, b, c;

            Console.WriteLine("Ingrese un número por favor");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número por favor");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un último número por favor");
            c = int.Parse(Console.ReadLine());

            suma = a+ b;
            producto = b * c;
            
            if(suma>producto){
                Console.WriteLine("La suma es mayor al producto");
            }
            Console.WriteLine("Programa finalizado");
        }
    }
}
