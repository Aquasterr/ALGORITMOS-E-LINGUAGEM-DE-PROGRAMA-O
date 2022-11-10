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
            int num;
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 100 && num < 200)
            {
                Console.WriteLine("O numero {0} esta entre 100 e 200", num);
            }
            else
            {
                Console.WriteLine("O numero {0} NAO esta entre 100 e 200", num);
            }
        }
    }
}
