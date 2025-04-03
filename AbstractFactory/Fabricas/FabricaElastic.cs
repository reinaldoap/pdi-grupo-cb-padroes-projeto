using Pdi.PadroesProjeto.AbstractFactory.Parceiros;
namespace Pdi.PadroesProjeto.AbstractFactory.Fabricas
{
    internal class FabricaElastic : IFabricaProdutoAbstrata
    {
        public IProdutoAbstrato CriarProduto(int id, string nome, List<string> skus, decimal preco)
        {
            return new ProdutoElastic(id, nome, skus, preco);
        }
    }
}
