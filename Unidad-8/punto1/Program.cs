using System;

namespace punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función
            int precio, cantidad, total;

            Console.WriteLine("Ingrese un precio");
            precio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad");
            cantidad = int.Parse(Console.ReadLine());

            total = producto(precio, cantidad);

            Console.WriteLine("El  monto total a pagar es " + total); 


        }

        static int producto(int a, int b){
            int p;
            p = a * b;

            return p;
        }

       

    }
}
