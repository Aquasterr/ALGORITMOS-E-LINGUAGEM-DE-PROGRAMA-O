using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            double sAtual, sAumento;
            Console.WriteLine("Digite o Salario atual: ");
            sAtual = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual do aumento salarial");
            sAumento = double.Parse(Console.ReadLine());
            double percentual = sAumento / 100;
            Console.WriteLine("Seu novo salario é: ");
            double valorfinal = (sAtual + (sAtual * percentual));
            Console.Write("Seu salario atual é de: ");
            Console.WriteLine(valorfinal);

        }
    }
}
