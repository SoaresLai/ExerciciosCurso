using System;
using System.Globalization;

namespace Estoque
{
    internal class Produto
    {
        private string _nome;
        public double Valor { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double valor, int quantidade)
        {
            _nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public string GetNome () 
        { 
            return _nome; 
        }

        public double Total ()
        {
            return Quantidade * Valor;
        }

        public void Adicionar(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void Remover(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $" + Valor.ToString("F2") + ", " + Quantidade + " unidades, Total: R$ " + Total().ToString("F2") ;
        }

    }
}
