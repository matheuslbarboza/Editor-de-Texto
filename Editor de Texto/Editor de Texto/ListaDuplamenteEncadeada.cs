using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_de_Texto
{
    internal class ListaDuplamenteEncadeada
    {
        private No cabeca;
        private No cauda;

        public ListaDuplamenteEncadeada()
        {
            cabeca = null;
            cauda = null;
        }

        public void Adicionar(string valor)
        {
            var novoNo = new No(valor);
            if (cabeca == null)
            {
                cabeca = novoNo;
                cauda = novoNo;
            }
            else
            {
                cauda.Proximo = novoNo;
                novoNo.Anterior = cauda;
                cauda = novoNo;
            }
        }

        public bool Contem(string valor)
        {
            var atual = cabeca;
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

        public void Remover(string valor)
        {
            var atual = cabeca;
            while (atual != null)
            {
                if (atual.Valor.Equals(valor))
                {
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

        public IEnumerable<string> ObterTodos()
        {
            var atual = cabeca;
            while (atual != null)
            {
                yield return atual.Valor;
                atual = atual.Proximo;
            }
        }
    }
}
