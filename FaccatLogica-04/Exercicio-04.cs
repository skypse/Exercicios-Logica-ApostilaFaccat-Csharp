using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaccatLogica_04
{
    class Exercicio_04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int numero01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int numero02 = Convert.ToInt32(Console.ReadLine());

            int divisao = numero01 / numero02;
            Console.WriteLine($"A divisao dos números é: {divisao}");
        }
    }
}
