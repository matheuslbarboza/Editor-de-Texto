using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Importando System.IO para usar operações relacionadas a arquivos

namespace Editor_de_Texto
{
    // Definição da classe Dicionario
    public class Dicionario
    {
        // Campo privado que armazena um array de objetos ListaDuplamenteEncadeada, representando a tabela hash
        private ListaDuplamenteEncadeada[] tabelaHash;
        // Constante que define o tamanho da tabela hash
        private const int TAMANHO_TABELA = 100;

        // Construtor que inicializa a tabela hash
        public Dicionario()
        {
            tabelaHash = new ListaDuplamenteEncadeada[TAMANHO_TABELA];
            // Inicializa cada entrada na tabela hash com um novo objeto ListaDuplamenteEncadeada
            for (int i = 0; i < TAMANHO_TABELA; i++)
            {
                tabelaHash[i] = new ListaDuplamenteEncadeada();
            }
        }

        // Método para obter o código hash para uma determinada palavra
        private int ObterHash(string palavra)
        {
            return Math.Abs(palavra.GetHashCode() % TAMANHO_TABELA);
        }

        // Método para adicionar uma palavra ao dicionário
        public void AdicionarPalavra(string palavra)
        {
            int hash = ObterHash(palavra);
            // Adiciona a palavra à lista correspondente no hash, se ela ainda não estiver presente
            if (!tabelaHash[hash].Contem(palavra))
            {
                tabelaHash[hash].Adicionar(palavra);
            }
        }

        // Método para verificar se uma palavra está no dicionário
        public bool ContemPalavra(string palavra)
        {
            int hash = ObterHash(palavra);
            return tabelaHash[hash].Contem(palavra);
        }

        // Método para remover uma palavra do dicionário
        public void RemoverPalavra(string palavra)
        {
            int hash = ObterHash(palavra);
            tabelaHash[hash].Remover(palavra);
        }

        // Método para carregar palavras de um arquivo
        public void CarregarDeArquivo(string caminho)
        {
            foreach (string linha in File.ReadLines(caminho))
            {
                AdicionarPalavra(linha.Trim());
            }
        }

        // Método para salvar as palavras do dicionário em um arquivo
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
