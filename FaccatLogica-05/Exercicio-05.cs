using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu antecessor*/

namespace FaccatLogica_05
{
    class Exercicio_05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            string? input = Console.ReadLine();
            int numero;

            if (int.TryParse(input, out numero))
            {
                int antecessor = numero - 1;
                int sucessor = numero + 1;

                Console.WriteLine($"O sucessor do número {numero} é: {sucessor}");
                Console.WriteLine($"O antecessor do número {numero} é: {antecessor}");
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
    }
}
