using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdi.PadroesProjeto.AbstractFactory.Parceiros
{
    internal class ProdutoElastic : IProdutoAbstrato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<string> Skus { get; set; }
        public decimal Preco { get; set; }
        public ProdutoElastic(int id, string nome, List<string> skus, decimal preco)
        {
            Id = id;
            Nome = nome;
            Skus = skus;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"ProdutoElastic: Id={Id}, Nome={Nome}, Skus={string.Join(", ", Skus)}, Preco={Preco}, Index=idx-produtos, Host:http//elastic-search:9092/idx-produtos";
        }
    }
}
