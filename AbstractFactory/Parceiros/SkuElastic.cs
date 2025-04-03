namespace Pdi.PadroesProjeto.AbstractFactory.Parceiros
{
    internal class SkuElastic : ISku
    {
        public SkuElastic(string id, string rotulo)
        {
            Id = id;
            Rotulo = rotulo;
        }

        public string Id { get; set; } = string.Empty;
        public string Rotulo { get; set; } = string.Empty;
    }
}
