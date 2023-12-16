using System;

namespace punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
            //Que analice el número y escriba variable recibida por referencia con:
                //a. 1 si el número es positivo.
                //b. -1 si el número es negativo.
                //c. 0 si el número es cero.
                
                int n1, state = 0;
                Console.WriteLine("Ingrese un número por valor");
                n1 = int.Parse(Console.ReadLine());

                positivoNegativoCero(n1, ref state);

                Console.WriteLine("el estado es " + state);

        }

        static void positivoNegativoCero (int numero, ref int estado){

                if (numero > 0)
                    estado = 1;
                else if (numero < 0)
                    estado = -1;
                else (numero == 0)
                    estado = 0;
        }
        
    }
}
