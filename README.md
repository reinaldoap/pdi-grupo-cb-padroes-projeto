# pdi-grupo-cb-padroes-projeto

## Exemplos de padroes de projeto

### 1. Factory Method (Criacional)
<p>
O Factory Method separa o código de construção do produto do código que realmente usa o produto. Portanto, é mais fácil estender o código de construção do produto independentemente do restante do código
</p>


### 2. Abstract Factory (Criacional)
<p>
Está no diretório `AbstractFactory`, contém um exemplo de produtos que podem ser armazenados em diferentes ferramentas de busca full-text (elasticsearch e solr).
</p>
<p>
A interface `IFabricaProdutoAbstrata` define os métodos que devem ser implementados pelas fábricas concretas, dentro do diretório `Fabricas` estão as classes concretas que geram os objetos 
nos respectivos formatos.
</p>