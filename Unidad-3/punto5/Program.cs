using System;

namespace punto5
{
    class Program
    {
        static void Main(string[] args)
        {
        //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
        
        int n1, n2, n3, n4;

        Console.WriteLine("Ingrese el primer número por favor");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número por favor");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número por favor");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el cuarto número por favor");
        n4 = int.Parse(Console.ReadLine());

        if(n1>100) {
            Console.WriteLine("El número " + n1 + " es mayor a 100");
        }
        
        if(n2>100){
            Console.WriteLine("El número " + n2 + " es mayor a 100");
        }          

        if(n3>100){
            Console.WriteLine("El número " + n3 + " es mayor a 100");
        }
        
        if(n4>100){
        Console.WriteLine("El número " + n4 + " es mayor a 100");
        }        
        
            }
        }
    }