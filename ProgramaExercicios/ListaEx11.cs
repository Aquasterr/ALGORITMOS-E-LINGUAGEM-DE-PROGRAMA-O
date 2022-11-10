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
            int n;
            Console.WriteLine("Digite o Numero");
            n = int.Parse(Console.ReadLine());
            if (n%2 == 0)
            {
                Console.WriteLine("{0} é par", n);
            }
            else
            {
                Console.WriteLine("{0} é impar", n);
            }
        }
    }
}
