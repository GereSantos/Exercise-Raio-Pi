using System;
using System.Globalization;

namespace Exercicio_Raio_Pi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa para mostrar a área de um circulo!

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double total = pi * raio * raio;

            Console.WriteLine("Resultado " + total.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
