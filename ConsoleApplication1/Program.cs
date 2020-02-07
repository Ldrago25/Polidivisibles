using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void recursividad(int contador,int aux)
        {

            Console.WriteLine(aux);
            
            
            if (aux % contador == 0 )
            {
                if (contador == 1)
                {
                    Console.WriteLine("ES POLIDIVISIBLE");
                }
                else
                {
                    recursividad(contador - 1, aux / 10);
                }
            }
            else
            {
                Console.WriteLine("NO POLIDIVISIBLE");
            }

        }

        static void poli(string a)
        {

            int aux = int.Parse(a);
            int b;
            int conta = a.Length;

            recursividad(conta, aux);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string numero_p;

            bool flag;


            do
            {
                flag = false;


                Console.WriteLine("Introduce un numero para saber si es polidivisible ");
                numero_p = Console.ReadLine();
                
                if(int.Parse(numero_p)<0 || int.Parse(numero_p)>1000000000000000000)
                {
                    Console.WriteLine("Numero de entrada incorrecto");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Numero de entreda valido");
                }
                

            }while (flag);

            poli(numero_p);

        }
    }
}
