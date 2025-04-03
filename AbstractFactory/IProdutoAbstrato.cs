

namespace Pdi.PadroesProjeto.AbstractFactory
{
    internal interface IProdutoAbstrato
    {
        int Id { get; }
        string Nome { get; }
        List<string> Skus { get; }
        decimal Preco { get; }
    }
}
