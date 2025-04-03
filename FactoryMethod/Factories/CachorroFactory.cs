using Pdi.PadroesProjeto.FactoryMethod.Mamiferos;

namespace Pdi.PadroesProjeto.FactoryMethod.Factories
{
    internal class CachorroFactory : IMamiferoFactory
    {
        public IMamifero CriarMamifero()
        {
            return new Cachorro();
        }
    }
}
