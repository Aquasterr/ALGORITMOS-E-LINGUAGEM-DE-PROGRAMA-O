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
            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("A diferença entre os numeros é: {0}", (n1 - n2));
            }
            else
            {
                Console.WriteLine("A diferença entre os numeros é: {0}", (n2 - n1));
            }
        }
    }
}
