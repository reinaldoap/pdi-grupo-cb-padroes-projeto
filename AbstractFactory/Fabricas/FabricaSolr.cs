
using Pdi.PadroesProjeto.AbstractFactory.Parceiros;

namespace Pdi.PadroesProjeto.AbstractFactory.Fabricas
{
    internal class FabricaSolr : IFabricaProdutoAbstrata
    {
        public IProduto AdicionarSku(IProduto produto, string codigoSku, string rotulo)
        {
            if (produto.Skus == null)
                produto.Skus = new List<ISku>();

            produto.Skus.Add(new SkuSolr(codigoSku, rotulo));
            return produto;
        }


        public IProduto CriarProduto(int id, string nome, decimal preco)
        {
            return new ProdutoSolr(id, nome, preco);
        }
    }
}
