
using MinhaLista;

Lista<int> listaDeInt = new Lista<int>();

listaDeInt.Adicionar(2);
listaDeInt.Adicionar(5);
listaDeInt.AdicionarVarios(6, 10, 15);
listaDeInt.AdicionarVarios(4, 8, 12);

listaDeInt.EscreverListaNaTela();

listaDeInt.Remover(10);

listaDeInt.EscreverListaNaTela();

Console.WriteLine("Item na posição 3: " + listaDeInt[3]);

listaDeInt.AdicionarVarios(20, 31, 54, 40, 64);
listaDeInt.EscreverListaNaTela();
