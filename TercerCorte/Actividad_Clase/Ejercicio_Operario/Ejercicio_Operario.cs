using System;
using System.Collections;

//Programa que permita registrar un operario con 3 datos: Nombre, teléfono y correo electrónico.

namespace Operario
{
    public class Operario
    {
        protected string nombrec;
        protected string correo;
        protected int telefono;

        public string Nombre
        {
            set
            {
                nombrec = value;
            }
            get
            {
                return nombrec;
            }
        }

        public string Correo
        {
            set
            {
                correo = value;
            }
            get
            {
                return correo;
            }
        }

        public int Contacto
        {
            set
            {
                telefono = value;
            }
            get
            {
                return telefono;
            }
        }

        public void Imprimir()
        {

            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Correo: " + Correo);
            Console.WriteLine("Telefono: " + Contacto);
        }
    }

    class program
    {
        static void Main(String[] args)
        {
            Operario persona1 = new Operario();
            persona1.Nombre = "Carolina Pulido";
            persona1.Correo = "caro3@gmail.com";
            persona1.Contacto = 10138658;
            Console.WriteLine("Los datos del opeario son:");
            persona1.Imprimir();
            Console.WriteLine("");

            Operario persona2 = new Operario();
            persona2.Nombre = "Juan Esteban Gamez";
            persona2.Correo = "jesteban@hotmail.com";
            persona2.Contacto = 32049667;
            Console.WriteLine("Los datos del operario son:");
            persona2.Imprimir();
            Console.WriteLine("");

            Operario persona3 = new Operario();
            persona3.Nombre = "Mateo Fonseca";
            persona3.Correo = "mateof@gmail.com";
            persona3.Contacto = 315578234;
            Console.WriteLine("Los datos del operario son:");
            persona3.Imprimir();
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}