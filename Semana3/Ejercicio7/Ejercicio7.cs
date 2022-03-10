using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio7
{
    class program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;
            int n;
            string letra;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(System.Console.ReadLine());

            Console.Write("Escoge una de las dos opciones (p / i): ");
            letra = Console.ReadLine();

            for (int i = 1; i <= n; i++)
            {
                if (i%2 == 0 && letra == "p")
                {
                    Console.Write("{0}", i);
                }
                if (i%2 != 0 && letra == "i")
                {
                    Console.Write("{0}", i);
                }
            }
        }
    }
}