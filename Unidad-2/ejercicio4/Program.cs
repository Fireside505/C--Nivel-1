using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo, comision, totalFacturado, resultado;

            Console.WriteLine("Ingrese total facturado");
            totalFacturado = float.Parse(Console.ReadLine());

            sueldo = 15000;
            comision = 5;

            resultado = (totalFacturado*comision)/100 + sueldo;

            Console.WriteLine("El sueldo a cobrar es " + resultado);



        }
    }
}
