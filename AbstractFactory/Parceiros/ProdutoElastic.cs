
namespace Pdi.PadroesProjeto.AbstractFactory.Parceiros
{
    internal class ProdutoElastic : IProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<ISku> Skus { get; set; } = new List<ISku>();
        public decimal Preco { get; set; }

        public ProdutoElastic(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public void EnviarParaIndexacao()
        {
            Console.WriteLine($"Enviando produto {this} para indexação no ElasticSearch.");
        }

        public override string ToString()
        {
            return $"ProdutoElastic: Id={Id}, Nome={Nome}, Preco={Preco}, Skus=[{string.Join(", ", Skus.Select(s => s.Id))}]";
        }
    }
}
