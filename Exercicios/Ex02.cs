using System;

namespace Exercicios
{
    class Ex02
    {
        public static void Renderizar()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\n==Maior e Menor==\n");

            Console.WriteLine("Digite um número inteiro: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if(n1>n2){
                Console.WriteLine($"O maior número é o {n1} o primeiro número informado");
            } else {
                Console.WriteLine($"O maior número é o {n2} o segundo número informado");
            }
        }

    }
}