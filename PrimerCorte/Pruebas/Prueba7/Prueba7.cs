using System;
namespace Problema01
{
    class Program
    {
        static void Main(string[] args)
        {
            double Lun, Mar, Mi, total;
            Console.WriteLine("Ingrese los tiempos de recorrido en minutos");
            Console.Write("Tiempo recorrido el Lunes    : ");
            Lun = Double.Parse(Console.ReadLine());
            Console.Write("Tiempo recorrido el Martes   : ");
            Mar = Double.Parse(Console.ReadLine());
            Console.Write("Tiempo recorrido el Miércoles: ");
            Mi = Double.Parse(Console.ReadLine());
            Console.WriteLine("El promedio de tiempo es : {0}", total = (Lun + Mar + Mi) / 3);
        }
    }
}