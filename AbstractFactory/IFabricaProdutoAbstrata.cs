
namespace Pdi.PadroesProjeto.AbstractFactory
{
    internal interface IFabricaProdutoAbstrata
    {
        IProdutoAbstrato CriarProduto(int id, string nome, List<string> skus, decimal preco);
    }
}
