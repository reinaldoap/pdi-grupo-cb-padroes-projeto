

namespace Pdi.PadroesProjeto.AbstractFactory
{
    internal interface IProduto
    {
        int Id { get; }
        string Nome { get; }
        List<ISku> Skus { get; set; }
        decimal Preco { get; }

        void EnviarParaIndexacao();
    }
}
