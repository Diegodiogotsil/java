// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace GeradorNumerosLoteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Gerador de Números de Loteria!");

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Mega-Sena");
                Console.WriteLine("2 - Quina");
                Console.WriteLine("3 - Timemania");
                Console.WriteLine("4 - Dia de Sorte");
                Console.WriteLine("5 - Lotomania");
                Console.WriteLine("6 - Lotofacil");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }

                switch (opcao)
                {
                    case 1:
                        GerarNumeros("Mega-Sena", 6, 60);
                        break;
                    case 2:
                        GerarNumeros("Quina", 5, 80);
                        break;
                    case 3:
                        GerarNumeros("Timemania", 10, 80);
                        break;
                    case 4:
                        GerarNumeros("Dia de Sorte", 7, 31);
                        break;
                    case 5:
                        GerarNumeros("Lotomania", 50, 100);
                        break;
                    case 6:
                        GerarNumeros("Lotofacil", 15, 25);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Escolha novamente.");
                        break;
                }
            }
        }

        static void GerarNumeros(string jogo, int quantidadeNumeros, int intervalo)
        {
            Random random = new Random();
            HashSet<int> numerosGerados = new HashSet<int>();

            while (numerosGerados.Count < quantidadeNumeros)
            {
                int numero = random.Next(1, intervalo + 1);
                numerosGerados.Add(numero);
            }

            Console.Write($"\nNúmeros gerados para {jogo}: ");
            foreach (int numero in numerosGerados)
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("Esses são os numeros sorteados");
        }
    }
}

