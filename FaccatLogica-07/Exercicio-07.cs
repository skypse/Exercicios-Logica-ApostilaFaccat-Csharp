using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaccatLogica_07
/*Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade 
dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias. */
{
    class Exercicio_07
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite quantos anos completos você tem: ");
            int anos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite quantos meses se passaram apos o seu ultimo aniversario: ");
            int meses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva quantidade de dias que passou apos seu ultimo aniversario: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            int idade = (anos * 365 + meses * 30 + dias);
            Console.WriteLine($"Você tem {idade} dias de vida");
        }
    }
}
