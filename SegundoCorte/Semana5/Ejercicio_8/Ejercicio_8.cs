using System;
using System.Linq;
using System.Collections;
namespace Ejercicio8
{
    class Program
    {
        public static void main(String[] args) {
 
        Scanner sc = new Scanner();
        int i, X;
        int Mas = 0, Menos = 0;
        double media = 0;

        do{
            System.outprint("Número de personas: ");                                                             
            X = sc.nextInt();
        }while(X<=0);
        double[] alto = new double[X];
        //Leer alturas
        System.outprintln("Lectura de la altura de las personas: ");
        for (i = 0; i < X; i++) {
            System.outprint("persona " + (i+1) + " = ");
            alto[i] = sc.nextDouble();
            media = media + alto[i];                            
        }
        media = media / X;
        for (i = 0; i < alto.length; i++) {
            if (alto[i] > media){ 
                cas++;
            } else if (alto[i] < media){ 
                Menos++;
            }
        }
        System.outprintln("Estatura media: " + media);
        System.outprintln("Personas con estatura superior a la media: " + Mas);
        System.outprintln("Personas con estatura inferior a la media: " + Menos);                            
    }
    }
}