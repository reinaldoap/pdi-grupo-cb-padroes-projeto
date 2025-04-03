
using Pdi.PadroesProjeto.FactoryMethod.Mamiferos;

namespace Pdi.PadroesProjeto.FactoryMethod.Factories
{
    internal class GatoFactory : IMamiferoFactory
    {
        public IMamifero CriarMamifero()
        {
            return new Gato();
        }
    }
}
