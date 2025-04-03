using Pdi.PadroesProjeto.AbstractFactory.Fabricas;

namespace Pdi.PadroesProjeto.AbstractFactory
{
    internal class ExemploAbstractFactory
    {
        private void ExecutarExemploFabricaElastic() 
        {
            Console.WriteLine("Exemplo de criação de um produto para ser armazendo no elastic search");
            IFabricaProdutoAbstrata fabricaProduto = new FabricaElastic();
            IProduto produto = fabricaProduto.CriarProduto(1, "Geladeira Brastemp", 2687.99m);
            produto = fabricaProduto.AdicionarSku(produto, "9584", "Branca");
            produto = fabricaProduto.AdicionarSku(produto, "9648", "Preta");
            produto.EnviarParaIndexacao();
            Console.WriteLine("--------------------------");
        }

        private void ExecutarExemploFabricaSolr()
        {
            Console.WriteLine("Exemplo de criação de um produto para ser armazendo no Solr");
            IFabricaProdutoAbstrata fabricaProduto = new FabricaSolr();
            IProduto produto = fabricaProduto.CriarProduto(1, "Fogão 4 Bocas", 3987.50m);
            produto = fabricaProduto.AdicionarSku(produto, "14572", "240V");
            produto = fabricaProduto.AdicionarSku(produto, "981477", "120V");
            produto.EnviarParaIndexacao();
            Console.WriteLine("--------------------------");
        }

        public void Executar()
        {
            ExecutarExemploFabricaElastic();
            ExecutarExemploFabricaSolr();
        }
    }
}
