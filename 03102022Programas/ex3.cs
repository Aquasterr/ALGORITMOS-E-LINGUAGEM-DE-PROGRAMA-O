using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /* Fazer método C# que recebe 1 número double e retorna a raiz quadrada
        do numero */
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Digite um numero: ");
            num = double.Parse(Console.ReadLine());

            Console.WriteLine("A raiz quadrada de {0} é: ", num);
            double multi = Multiplicar(num, num);
            Console.WriteLine(multi);

        }

        public static double Multiplicar(double x, double y)
        {
            double multi = x * y;
            return multi;
        }
    }
}
