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
            double baseT, altura;
            Console.WriteLine("Digite o valor da base");
            baseT = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura");
            altura = double.Parse(Console.ReadLine());
            double area = (baseT * altura)/2;
            Console.WriteLine("A Area do Triangulo é de: " + area);
        }
    }
}
