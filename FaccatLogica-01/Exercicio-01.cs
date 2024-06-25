using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaccatLogica_01
{
    class Exercicio_01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int numero01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int numero02 = Convert.ToInt32(Console.ReadLine());

            int soma = numero01 + numero02;
            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
