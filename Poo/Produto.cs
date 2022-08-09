using System;

namespace Poo
{
    class Produto
    {
        private string Nome;
        private int Quantidade;
        private double Preco;

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(String nome)
        {
            this.Nome = nome;
        }

    }
}