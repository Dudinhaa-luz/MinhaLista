using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLista
{
    public class Lista<T>
    {
        private int _proximaPosicaoDisponivel;
        private int _capacidade;
        private T[] _lista = new T[0];

        public T this[int indice]
        {
            get { return GetItemNoIndice(indice); }
        }

        public Lista(int capacidade = 5)
        {
            Console.WriteLine("Criando lista com capacidade = " + capacidade);

            _lista = new T[capacidade];
            _proximaPosicaoDisponivel = 0;
            _capacidade = capacidade;
        }

        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicaoDisponivel +1);

            Console.WriteLine("Adicionando novo item na posição: " + _proximaPosicaoDisponivel + " - " + item);

            _lista[_proximaPosicaoDisponivel] = item;
            _proximaPosicaoDisponivel++;
        }

        public void AdicionarVarios(params T[] itens)
        {
            foreach(T item in itens)
            {
                Adicionar(item);
            }
        }

        public void VerificarCapacidade(int tamanhoNecessario)
        {
            if (tamanhoNecessario >= _capacidade)
            {
                int novoTamanho = _capacidade * 2;

                if (novoTamanho < tamanhoNecessario)
                {
                    novoTamanho = tamanhoNecessario;
                }

                T[] novoArray = new T[novoTamanho];
                Array.Copy(_lista, novoArray, _lista.Length);

                Console.WriteLine("Capacidade da lista aumentada para: " + novoTamanho);

                _capacidade = novoTamanho;
                _lista = novoArray;
            }
        }

        public void Remover(T item)
        {
            int indice = -1;

            for(int i = 0; i < _lista.Length; i++)
            {
                T itemAtual = _lista[i];

                if (itemAtual.Equals(item))
                {
                    indice = i;
                    break;
                }
            }

            for(int i = indice; i < _lista.Length - 1; i++)
            {
                _lista[i] = _lista[i + 1];
            }

            Console.WriteLine("Removido item da posição " + indice);

            _proximaPosicaoDisponivel--;
        }

        public void EscreverListaNaTela()
        {
            for(int i=0; i < _proximaPosicaoDisponivel; i++)
            {
                Console.WriteLine("Item na posição: " + i + " - " + _lista[i]);
            }
        }

        private T GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicaoDisponivel)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _lista[indice];
        }
    }
}
