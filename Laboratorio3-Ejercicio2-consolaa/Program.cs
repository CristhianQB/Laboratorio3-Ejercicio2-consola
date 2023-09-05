using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Ejercicio2_consolaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qué categoría prefiere");
            Console.WriteLine("(0)Tres estrellas");
            Console.WriteLine("(1)Cinco estrellas");
            string estrellasTexto = Console.ReadLine();

            Console.WriteLine("Cuántos días estará");
            string diasTexto = Console.ReadLine();

            int estrellas = int.Parse(estrellasTexto);
            int dias = int.Parse(diasTexto);

            switch (estrellas)
            {
                case 0:
                    if (dias > 0 && dias < 6)
                    {
                        int costo = dias * 100;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    else if (dias > 5 && dias < 11)
                    {
                        int costo = dias * 85;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    else if (dias > 11)
                    {
                        int costo = dias * 70;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    break;

                case 1:
                    if (dias > 0 && dias < 6)
                    {
                        int costo = dias * 300;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    else if (dias > 5 && dias < 11)
                    {
                        int costo = dias * 270;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    else if (dias > 11)
                    {
                        int costo = dias * 250;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
