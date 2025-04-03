# pdi-grupo-cb-padroes-projeto

## Exmplos de padroes de projeto
### 1. Abstract Factory
<p>
Está no diretório `AbstractFactory`, contém um exemplo de produtos que podem ser armazenados em diferentes ferramentas de busca full-text (elasticsearch e solr).
</p>
<p>
A interface `IFabricaProdutoAbstrata` define os métodos que devem ser implementados pelas fábricas concretas, dentro do diretório `Fabricas` estão as classes concretas que geram os objetos 
nos respectivos formatos.
</p>