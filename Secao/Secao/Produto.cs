using System.Globalization;

namespace Secao
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade_estoque;
  
        public double ValorTotalEmEstoque()
        {
            return Quantidade_estoque * Preco;  
        }
        public void AdicionarProduto(int quantity)
        {
            Quantidade_estoque += quantity;
        }

        public void RemoverProduto(int quantity)
        {
            Quantidade_estoque -= quantity;
        }

        public override string ToString()
        {
            return Nome 
                + ", R$" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade_estoque
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
