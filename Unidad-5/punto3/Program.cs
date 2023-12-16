using System;

namespace punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

                int n, acu = 0, con= 0, promedio;
                
                for(int x = 0; x < 20; x++) {

                    Console.WriteLine("Por favor, ingrese una edad");
                    n = int.Parse(Console.ReadLine());

                if(n > 18){
                    acu+=n;
                    con++;
                }
                }
                promedio = (acu/con);

                Console.WriteLine("El promedio de edades es " + promedio);
        }
    }
}
