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
            double num1, num2;
            Console.WriteLine("Digite o Primeiro Numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero");
            num2 = double.Parse(Console.ReadLine());
            double soma = num1 + num2;
            double subtracao = num1 - num2;
            double vezes = num1 * num2;
            double divisao = num1 / num2;
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Vezes: " + vezes);
            Console.WriteLine("Divisão: " + divisao);
        }
    }
}
