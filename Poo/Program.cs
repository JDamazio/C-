using System;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.SetNome("Arroz");
            Console.WriteLine(produto.GetNome());

            Usuario usuario = new Usuario();
            usuario.Login = "batatinhaComPimenta";
            usuario.Senha = "batata123";
            usuario.Idade = 12;
            usuario.Email = "b@gmail.com";

            Console.WriteLine(usuario);

            Usuario u = new Usuario
            {
                Login = "Teste",
                Email = "a@a.com",
                Senha = "1234",
                Idade = 25
            };
            Console.WriteLine(u);
        }
    }
}
