// See https://aka.ms/new-console-template for more information
using Pdi.PadroesProjeto.AbstractFactory;
using Pdi.PadroesProjeto.FactoryMethod;


//-- Factory Method
Console.WriteLine("1: Exemplo de Factory Method");
new ExemploFactoryMethod().Executar();

Console.WriteLine("-------------------------");

Console.WriteLine("2: Exemplo de Abstract Factory");
ExemploAbstractFactory exemplo = new ExemploAbstractFactory();
exemplo.ExecutarExemploFabricaElastic();
exemplo.ExecutarExemploFabricaSolr();
