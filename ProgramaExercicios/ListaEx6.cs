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

            if (num > 200 && num < 300)
            {
                Console.WriteLine("O numero {0} esta entre 200 e 300", num);
            }
            else
            {
                Console.WriteLine("O numero {0} NAO esta entre 200 e 300", num);
            }
        }
    }
}
