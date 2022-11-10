using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /* Fazer método que calcule o valor da área de um retângulo, a partir do
        valor da base e altura. */
        static void Main(string[] args)
        {
            double basee, altura;
            Console.WriteLine("Digite a base do retangulo: ");
            basee = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retangulo: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("A area do retangulo é: ");
            double multi = Multiplicar(basee, altura);
            Console.WriteLine(multi);

        }

        public static double Multiplicar(double x, double y)
        {
            double multi = x * y;
            return multi;
        }
    }
}
