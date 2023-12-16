using System;
using System.ComponentModel.DataAnnotations;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
                //-El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
                //-Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

                int n, con, conImp, porcentaje, mayor = -1, grupoMayor = 0, min = 0, conOrd=0;
                bool banOrd;

                for (int x = 0; x < 5; x++){
                    
                    con = 0;
                    conImp = 0;
                    banOrd = true;
                    Console.WriteLine("Ingrese un número");
                    n = int.Parse(Console.ReadLine());

                    n = min;
                        
                    while (n != 0){
                        con++;
                        {
                            if (n % 2 !=0) {
                                conImp++;
                            }

                            if(n <= min) {
                                min = n;
                            } else {
                                banOrd = false;
                            }
                    Console.WriteLine("Ingrese un número");
                    n = int.Parse(Console.ReadLine());
                        }
                     }
                     porcentaje = conImp*100/con;

                     if(porcentaje > mayor){
                        mayor = porcentaje;
                        grupoMayor = x + 1;

                     }

                     if(banOrd){
                        conOrd++;
                     }
        }
        Console.WriteLine("El grupo con mayor número de impares es " + grupoMayor);
        Console.WriteLine("El grupo con mas números ordenados es " + conOrd);
        }
    }
}
