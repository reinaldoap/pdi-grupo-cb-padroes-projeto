
namespace Pdi.PadroesProjeto.AbstractFactory
{
    internal interface IFabricaProdutoAbstrata
    {
        IProduto CriarProduto(int id, string nome, decimal preco);
        IProduto AdicionarSku(IProduto produto, string codigoSku, string rotulo);
    }
}
