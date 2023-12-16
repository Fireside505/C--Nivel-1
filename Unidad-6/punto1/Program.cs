using System;

namespace punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
                
                int n, con, conPrimo = 0;

                for (int x = 0; x < 10; x++) {
                    
                    Console.WriteLine("Ingrese un numero");
                    n = int.Parse(Console.ReadLine());
                    con = 0;
                    for (int y = 1; y <= n; y++) {
                        if (n % y == 0) {
                        con++;
                        }
                        if (con == 2) {
                         conPrimo++;
                        }
                    }
                }
                Console.WriteLine("La cantidad de números primos es de " + conPrimo);
        }
    }
}
