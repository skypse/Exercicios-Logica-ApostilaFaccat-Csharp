using System;

namespace FaccatLogica_08
{
    class Exercicio_08
    {
        public static void Main(string[] args)
        {
            Console.Write("Escreva o total dos eleitores: ");
            int totalEleitores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o total de votos validos: ");
            int votosValidos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o total de votos nulos: ");
            int votosNulos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o total de votos brancos: ");
            int votosBranco = Convert.ToInt32(Console.ReadLine());

            double porcentagemVotosValidos = (double)votosValidos / totalEleitores * 100;
            double porcentagemVotosBrancos = (double)votosBranco / totalEleitores * 100;
            double porcentagemVotosNulos = (double)votosNulos / totalEleitores * 100;

            Console.WriteLine($"Porcentagem de votos válidos: {porcentagemVotosValidos}%");
            Console.WriteLine($"Porcentagem de votos brancos: {porcentagemVotosBrancos}%");
            Console.WriteLine($"Porcentagem de votos nulos: {porcentagemVotosNulos}%");
        }
    }
}
