using Pdi.PadroesProjeto.FactoryMethod.Factories;

namespace Pdi.PadroesProjeto.FactoryMethod
{
    internal class ExemploFactoryMethod
    {
        public void Executar()
        {
            IMamiferoFactory vacafactory = new VacaFactory();
            IMamiferoFactory gatorfactory = new GatoFactory();
            IMamiferoFactory cachorrofactory = new CachorroFactory();

            List<IMamifero> mamiferos = new List<IMamifero>
            {
                vacafactory.CriarMamifero(),
                gatorfactory.CriarMamifero(),
                cachorrofactory.CriarMamifero()
            };


            foreach (IMamifero mamifero in mamiferos)
            {
                Console.WriteLine($"Olá eu sou um(a) {mamifero.GetType().Name} e produzo o seguinte som: ");
                mamifero.EmitirSom();
            }
        }
    }
}
