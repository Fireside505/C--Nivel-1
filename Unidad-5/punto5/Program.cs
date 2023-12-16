using System;

namespace punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

        int n, max = 0, min = 0;
        bool tengoBanPar = false, tengoBanImpar = false; 

        for(int x = 0; x < 20; x++){
            Console.WriteLine("Ingrese un número, por favor.");
            n = int.Parse(Console.ReadLine());

            if(n % 2 == 0) {
                if(tengoBanPar == false){
                max = n;
                tengoBanPar = true;
                }
                else if(n > max) 
                max = n;
            }
            else {
                if(tengoBanImpar == false) {
                min = n;
                tengoBanImpar = true;
                }
                else if(n < min) 
                min = n;
            }
        }
        Console.WriteLine("El maximo número par es " + max);
        Console.WriteLine("El minimo número impar es " + min);
        }
    }
}
