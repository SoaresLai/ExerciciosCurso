using Estoque;
using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Valor: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, valor, quantidade);

            Console.WriteLine("\nDados do produto:" + p1);

            Console.Write("\nDigite a quantidade a ser adicionada: ");
            int qtd = int.Parse(Console.ReadLine());
            p1.Adicionar(qtd);

            Console.WriteLine("\nDados atualizados: " + p1);

            Console.Write("\nDigite a quantidade a ser removida: ");
            qtd = int.Parse(Console.ReadLine());
            p1.Remover(qtd);

            Console.WriteLine("\nDados atualizados:" + p1);

        }
    }
}
