using System;
using System.Collections;

//Programa que permita registrar un operario con 3 datos: Nombre, teléfono y correo electrónico.

namespace Productos
{
    public class Productos
    {
        protected string nombre;
        protected string marca;
        protected int costo;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public string Descripcion
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }

        public int Precio
        {
            set
            {
                costo = value;
            }
            get
            {
                return costo;
            }
        }

        public void Imprimir()
        {

            Console.WriteLine("Nombre : " + Nombre);
            Console.WriteLine("Producto: " + Descripcion);
            Console.WriteLine("Precio : " + Precio);
        }
    }

    class program
    {
        static void Main(String[] args)
        {
            Productos cliente1 = new Productos();
            cliente1.Nombre = "Coca-Cola";
            cliente1.Descripcion = "Gaseosa personal de 1.5lt";
            cliente1.Precio = 5000;
            Console.WriteLine("Los datos de la compra son:");
            cliente1.Imprimir();
            Console.WriteLine("");

            Productos cliente2 = new Productos();
            cliente2.Nombre = "De Todito";
            cliente2.Descripcion = "Paquete de papas tamaño familiar de 400g";
            cliente2.Precio = 11500;
            Console.WriteLine("Los datos de la compra son:");
            cliente2.Imprimir();
            Console.WriteLine("");

            Productos cliente3 = new Productos();
            cliente3.Nombre = "Gomitas";
            cliente3.Descripcion = "1 caja de Trululu sabores de $10.300 y un paquete de gomitas Trululu aros de $1.800 ";
            cliente3.Precio = 12100;
            Console.WriteLine("Los datos de la compra son:");
            cliente3.Imprimir();
            Console.WriteLine("");

            Productos cliente4 = new Productos();
            cliente4.Nombre = "1 caja grande de cereal Zucaritas de $17.500 y 1 bolsa de leche Alqueria supermegalitro de $6.000";
            cliente4.Descripcion = "Gaseosa personal de 1.5lt";
            cliente4.Precio = 23500;
            Console.WriteLine("Los datos de la compra son:");
            cliente4.Imprimir();
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
