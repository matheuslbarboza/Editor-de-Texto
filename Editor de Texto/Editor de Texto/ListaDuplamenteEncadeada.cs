using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_de_Texto
{
    // Classe que representa uma lista duplamente encadeada
    internal class ListaDuplamenteEncadeada
    {
        // Nó cabeça da lista
        private No cabeca;
        // Nó cauda da lista
        private No cauda;

        // Construtor que inicializa a lista vazia
        public ListaDuplamenteEncadeada()
        {
            cabeca = null;
            cauda = null;
        }

        // Método para adicionar um novo nó com um valor à lista
        public void Adicionar(string valor)
        {
            var novoNo = new No(valor);
            // Se a lista estiver vazia, o novo nó é a cabeça e a cauda
            if (cabeca == null)
            {
                cabeca = novoNo;
                cauda = novoNo;
            }
            // Caso contrário, adiciona o novo nó ao final da lista
            else
            {
                cauda.Proximo = novoNo;
                novoNo.Anterior = cauda;
                cauda = novoNo;
            }
        }

        // Método para verificar se a lista contém um determinado valor
        public bool Contem(string valor)
        {
            var atual = cabeca;
            // Percorre a lista e verifica se algum nó contém o valor procurado
            while (atual != null)
            {
                if (atual.Valor.Equals(valor))
                {
                    return true;
                }
                atual = atual.Proximo;
            }
            return false;
        }

        // Método para remover um nó com um determinado valor da lista
        public void Remover(string valor)
        {
            var atual = cabeca;
            // Percorre a lista e procura o nó com o valor a ser removido
            while (atual != null)
            {
                if (atual.Valor.Equals(valor))
                {
                    // Ajusta as referências dos nós anterior e próximo para remover o nó atual
                    if (atual.Anterior != null)
                    {
                        atual.Anterior.Proximo = atual.Proximo;
                    }
                    else
                    {
                        cabeca = atual.Proximo;
                    }

                    if (atual.Proximo != null)
                    {
                        atual.Proximo.Anterior = atual.Anterior;
                    }
                    else
                    {
                        cauda = atual.Anterior;
                    }

                    break;
                }
                atual = atual.Proximo;
            }
        }

        // Método para obter todos os valores da lista
        public IEnumerable<string> ObterTodos()
        {
            var atual = cabeca;
            // Percorre a lista e retorna cada valor
            while (atual != null)
            {
                yield return atual.Valor;
                atual = atual.Proximo;
            }
        }

        // Classe interna que representa um nó da lista duplamente encadeada
        private class No
        {
            public string Valor { get; set; }
            public No Proximo { get; set; }
            public No Anterior { get; set; }

            // Construtor do nó que inicializa com um valor
            public No(string valor)
            {
                Valor = valor;
                Proximo = null;
                Anterior = null;
            }
        }
    }
}
