using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Digite o Primeiro Numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A Multiplicaçao dos numeros é de: ");
            double multi = Multiplicar(num1, num2);
            Console.WriteLine(multi);

        }

        public static double Multiplicar(double x, double y)
        {
            double multi = x * y;
            return multi;
        }
    }
}
