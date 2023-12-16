using System;

namespace punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int n1, n2, n3, n4, nm;

            Console.WriteLine("Ingrese primer número por favor");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo número por favor");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tercer número por favor");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cuarto número por favor");
            n4 = int.Parse(Console.ReadLine());

            if(n1<n2) {
                nm = n1;
            }else {
                nm = n2;
            }

            if(n3<nm) {
                    if(n4<nm)
                        nm=n4;
                else nm = n3;
            }
            Console.WriteLine("El número menor ingresado del grupo es " + nm);
        }
    }
}
