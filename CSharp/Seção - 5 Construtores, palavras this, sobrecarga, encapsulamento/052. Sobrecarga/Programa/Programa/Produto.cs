using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()// sobrecarga com este nao precisa colocar nenhum parametro no MAIN
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }      //construtor tem o mesmo nome da classe.

        public Produto(string nome,double preco) // segundo construtor utilizado, nao precisa informar a quantidade
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //para fins ditadicos, porem posso deixar sem o value.
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome.ToUpper()
            + ", valor Unidade: $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}