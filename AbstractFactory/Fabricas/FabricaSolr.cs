

using Pdi.PadroesProjeto.AbstractFactory.Parceiros;

namespace Pdi.PadroesProjeto.AbstractFactory.Fabricas
{
    internal class FabricaSolr : IFabricaProdutoAbstrata
    {
        public IProdutoAbstrato CriarProduto(int id, string nome, List<string> skus, decimal preco)
        {
            return new ProdutoSolr(id, nome, skus, preco);
        }
    }
}
