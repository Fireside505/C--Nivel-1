using System;

namespace punto3
{
    class Program
    {
        static void Main(string[] args)
        {
        //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter
        // dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
        //CADENA FUENTE: “La mar estaba serena"
        //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //CADENA RESULTADO: “Li mir estibi sereni"

        char[] cadena = new char[30];
        char letra, letra1, letra2;
        int indice = 0;

        Console.WriteLine("Ingrese una letra: ");
        letra = char.Parse(Console.ReadLine());

        while (letra != '0' && indice < 30)
        {
            cadena[indice] = letra;
            Console.WriteLine("Ingrese otra letra: ");
            letra = char.Parse(Console.ReadLine());
            indice++;
        }
        cadena[indice] = '\0';

        Console.WriteLine("La frase completa es ");

        indice = 0;
            while (cadena[indice] != '\0')
                {
                    Console.Write(cadena[indice]);
                    indice++;
                }

        Console.WriteLine("Ingrese letra a reemplazar");
        letra1 = char.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese letra reemplazante");
        letra2 = char.Parse(Console.ReadLine());

        indice=0;

        while (cadena[indice] != '\0')
        {
            if (cadena[indice] == letra1)
            {
                cadena[indice] = letra2;
            
            }
            
            indice++;
        }
        
        Console.WriteLine("La frase nueva es ");

        indice = 0;
            while (cadena[indice] != '\0')
                {
                    Console.Write(cadena[indice]);
                    indice++;
                }
        }
    }
}
