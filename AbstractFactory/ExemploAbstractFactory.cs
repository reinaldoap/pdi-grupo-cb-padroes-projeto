using Pdi.PadroesProjeto.AbstractFactory.Fabricas;

namespace Pdi.PadroesProjeto.AbstractFactory
{
    internal class ExemploAbstractFactory
    {
        public void ExecutarExemploFabricaElastic() 
        {
            Console.WriteLine("Exemplo de criação de um produto para ser armazendo no elastic search");
            IFabricaProdutoAbstrata fabricaProduto = new FabricaElastic();
            IProdutoAbstrato produto = fabricaProduto.CriarProduto(1, "Geladeira Brastemp", new List<string> { "123456", "7857" }, 2687.99m);
            Console.WriteLine(produto.ToString());
            Console.WriteLine("--------------------------");
        }

        public void ExecutarExemploFabricaSolr()
        {
            Console.WriteLine("Exemplo de criação de um produto para ser armazendo no Solr");
            IFabricaProdutoAbstrata fabricaProduto = new FabricaSolr();
            IProdutoAbstrato produto = fabricaProduto.CriarProduto(1, "Fogão 4 Bocas", new List<string> { "9584", "9648" }, 3987.50m);
            Console.WriteLine(produto.ToString());
            Console.WriteLine("--------------------------");
        }
    }
}
