using System;

namespace Exercicios
{
    class Ex03
    {
        public static void Renderizar()
        {
            Console.WriteLine("\n==Idade==\n");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Informe a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if(idade <= 13){
                Console.WriteLine("Você é uma criança chata!!");
            }else if(idade <= 18){
                Console.WriteLine("Você é um adolescente chato!");
            }else if(idade <=60){
                Console.WriteLine("Você é um coroa chato!!");
            } else{
                Console.WriteLine("Tá de morrer!!");
            }
        }
    }
}