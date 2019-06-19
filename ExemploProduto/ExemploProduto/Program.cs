using System;

using System.Globalization;
namespace ExemploProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do Produtos: " + p);
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
            int qtd = int.Parse(Console.ReadLine());
            p.EntradaEstoque(qtd);
            Console.WriteLine("Dados do Produtos: " + p);

            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutoEstoque(qtd);
            Console.WriteLine("Dados do Produtos: " + p);
        }
    }
}
