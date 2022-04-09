using System;
using System.Globalization;

namespace Secao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados dos produtos: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade_estoque = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: " + produto);

            Console.WriteLine("Deseja adicionar algum dado então digite 1 caso deseje remover um produto digite 2: ");
            int opcao = int.Parse(Console.ReadLine());

            int qte = 0;

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o número de produtos para ser adicionado: ");
                    qte = int.Parse(Console.ReadLine());
                    produto.AdicionarProduto(qte);
                    break;
                case 2:
                    Console.WriteLine("Digite a quantidade de produtos que deseja remover: ");
                    qte = int.Parse(Console.ReadLine());
                    produto.RemoverProduto(qte);
                    break;
                default:
                    Console.WriteLine("Código inválido.");
                    break;
            }
            
                

            Console.WriteLine("Dados atualizados: " + produto);


        }
    }
}
