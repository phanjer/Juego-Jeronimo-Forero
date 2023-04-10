using System;

namespace Aplicacion_Jeronimo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("el barco va a estar horizontal o vertical? 0 = h, 1 = v");
            int horizontal = 0, vertical = 1;
            int posicion1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Que longitud va a tener el barco?");
            int longitudbarco = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("donde empezara el barco? ingrese la coordenada de la siguiente forma --> x,y:");
            string posicionfinal = Console.ReadLine();
            string[] coordenadas = posicionfinal.Split(',');

            var filas = 10;
            var columnas = 10;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(" ~");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese las coordenas para atacar al barco ");
            string ataquebarco = (Console.ReadLine());

            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(" ~");
                    }
                    Console.WriteLine();

                }
                Console.WriteLine();
            }

        }
    }
}