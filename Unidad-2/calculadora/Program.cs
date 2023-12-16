using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paso 0: definir las variables con sus tipo de datos (se pueden asignar varias variables en una linea de código si las variables corresponden a un mismo tipo de datos)
            //Tipos de datos: int(enteros), float(decimales), char(letras), bool(t o f)
            int n1, n2, resultado;
            //Paso 1: pedir valores para hacer el calculo
            //console.WriteLine("texto"): permite "mostrar carteles". SIEMPRE TERMINAR LAS LINEAS DE CÓDIGO CON UN ;
            //console.ReadLine: permite que el usuario cargue información al programa
            // int.Parse("codigo"): permite convertir datos que se ingresan al tipo INT
            //ASIGNAR UNA VARIABLE: N1 = Código
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número:");
            n2 = int.Parse(Console.ReadLine());

            //Paso 2: realizar el calculo
            resultado = n1 + n2; 

            //Paso 3: emitir el resultado
            //Se puede concatenar codigo de mostrar resulados con las variables

            Console.WriteLine("El resultado es: " + resultado);

        }
    }
}
