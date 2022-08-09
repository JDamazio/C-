using System;

namespace Exercicios
{
    class Ex01
    {
        public static void Renderizar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n==Área de retângulo==\n");

            //Imprimir mensagens no terminal 
            Console.WriteLine("Digite a altura: ");
            //Conversão
            int altura = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura: ");
            //Conversão
            int largura = Convert.ToInt32(Console.ReadLine());

            int area = altura * largura;

            //Console.WriteLine("Área: " + area);
            Console.WriteLine($"Área: {area}");
            
        }
    }
}