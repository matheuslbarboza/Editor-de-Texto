using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_de_Texto
{
    public class Dicionario
    {
        private ListaDuplamenteEncadeada[] tabelaHash;
        private const int TAMANHO_TABELA = 100;

        public Dicionario()
        {
            tabelaHash = new ListaDuplamenteEncadeada[TAMANHO_TABELA];
            for (int i = 0; i < TAMANHO_TABELA; i++)
            {
                tabelaHash[i] = new ListaDuplamenteEncadeada();
            }
        }

        private int ObterHash(string palavra)
        {
            return Math.Abs(palavra.GetHashCode() % TAMANHO_TABELA);
        }

        public void AdicionarPalavra(string palavra)
        {
            int hash = ObterHash(palavra);
            if (!tabelaHash[hash].Contem(palavra))
            {
                tabelaHash[hash].Adicionar(palavra);
            }
        }

        public bool ContemPalavra(string palavra)
        {
            int hash = ObterHash(palavra);
            return tabelaHash[hash].Contem(palavra);
        }

        public void RemoverPalavra(string palavra)
        {
            int hash = ObterHash(palavra);
            tabelaHash[hash].Remover(palavra);
        }

        public void CarregarDeArquivo(string caminho)
        {
            foreach (string linha in File.ReadLines(caminho))
            {
                AdicionarPalavra(linha.Trim());
            }
        }

        public void SalvarEmArquivo(string caminho)
        {
            using (StreamWriter escritor = new StreamWriter(caminho))
            {
                for (int i = 0; i < TAMANHO_TABELA; i++)
                {
                    foreach (var palavra in tabelaHash[i].ObterTodos())
                    {
                        escritor.WriteLine(palavra);
                    }
                }
            }
        }
    }

}
