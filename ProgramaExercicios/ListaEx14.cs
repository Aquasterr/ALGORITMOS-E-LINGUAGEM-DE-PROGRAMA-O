using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double tempC = double.Parse(Console.ReadLine());

            double tempF = (9 * tempC + 160) / 5;

            Console.WriteLine("A temperatura é de: {0}ºF", tempF);
        }
    }
}
