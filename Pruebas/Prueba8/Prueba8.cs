using System;
namespace Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            double cPesos, eqDolar, uCambio;

            Console.Write(" Ingrese cantidad en pesos : ");
            cPesos = Double.Parse(Console.ReadLine());

            Console.Write("\n Ingrese unidad cambiaria a dólares : ");
            uCambio= Double.Parse(Console.ReadLine()); //Lee la unidad cambiaria...

            eqDolar = cPesos / uCambio; // Divide la cantidad en pesos para la unidad de cambio.

            Console.WriteLine("\n {0} pesos equivalen a {1:C2} dólares", cPesos, eqDolar);
        }
    }
}