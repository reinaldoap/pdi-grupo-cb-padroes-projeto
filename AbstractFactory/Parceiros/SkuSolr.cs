namespace Pdi.PadroesProjeto.AbstractFactory.Parceiros
{
    internal class SkuSolr : ISku
    {
        public SkuSolr(string id, string rotulo)
        {
            Id = id;
            Rotulo = rotulo;
        }

        public string Id { get; set; } = string.Empty;
        public string Rotulo { get; set; } = string.Empty;
    }
}
