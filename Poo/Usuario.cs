using System;

namespace Poo
{
    class Usuario
    {
        public string Login { get; set;}
        public string Senha { get; set;}
        public int Idade { get; set;}
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Login: {Login} | Senha: {Senha} | Idade: {Idade} | Email: {Email}";
        }
    }
}