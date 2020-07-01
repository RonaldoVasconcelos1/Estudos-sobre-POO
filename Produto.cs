using System.Globalization;
namespace POO
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Constructor
        public Produto() {

        }
         public Produto(string nome, double preco, int quantidade) {
             Nome = nome;
             Preco = preco;
             Quantidade = quantidade;
         }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }
        public double ValorTotalEmEstoque() {
                return Preco * Quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return Nome
            + ", $"
            + Preco.ToString("F2", CultureInfo.InstalledUICulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}