
using Pdi.PadroesProjeto.FactoryMethod.Mamiferos;

namespace Pdi.PadroesProjeto.FactoryMethod.Factories
{
    internal class VacaFactory : IMamiferoFactory
    {
        public IMamifero CriarMamifero()
        {
            return new Vaca();
        }
    }
}
