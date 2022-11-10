using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Apresentar os quadrados dos números inteiros de 15 a 200.
    class Program
    {
        static void Main(string[] args)
        {
            int i = 15;
            int num;
            while (i <= 200)
            {
                num = i * i;
                Console.WriteLine(num);
                i++;
            }
        }
    }
}
