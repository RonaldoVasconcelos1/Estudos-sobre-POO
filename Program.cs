using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
        

           System.Console.WriteLine("Entre com os dados do produto");
           System.Console.Write("Nome: ");
           string nome = Console.ReadLine();
           System.Console.Write("Preco: ");
           double preco = double.Parse(Console.ReadLine());
           System.Console.Write("Quantidade: ");
           int qtd = int.Parse(Console.ReadLine());

           var p = new Produto () {
               Nome = nome,
               Preco = preco,
               Quantidade = qtd
           };

           System.Console.WriteLine();
           System.Console.WriteLine($"Dados do produto: {p}");
        }
    }
}
