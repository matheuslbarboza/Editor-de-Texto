namespace Editor_de_Texto
{
    // Definição parcial da classe Form1, que herda de Form
    public partial class Form1 : Form
    {
        // Campo privado para armazenar a instância do dicionário
        private Dicionario dicionario;

        // Construtor da classe Form1
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            dicionario = new Dicionario(); // Inicializa a instância do dicionário
        }

        // Método de evento acionado quando o botão "Carregar" é clicado
        private void BotaoCarregar_Click(object sender, EventArgs e)
        {
            // Define o filtro do diálogo para abrir arquivo
            dialogoAbrirArquivo.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
            if (dialogoAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                // Carrega as palavras do arquivo selecionado para o dicionário
                dicionario.CarregarDeArquivo(dialogoAbrirArquivo.FileName);
            }
        }

        // Método de evento acionado quando o botão "Salvar" é clicado
        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            // Define o filtro do diálogo para salvar arquivo
            dialogoSalvarArquivo.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
            if (dialogoSalvarArquivo.ShowDialog() == DialogResult.OK)
            {
                // Salva as palavras do dicionário no arquivo selecionado
                dicionario.SalvarEmArquivo(dialogoSalvarArquivo.FileName);
            }
        }

        // Método de evento acionado quando o botão "Adicionar Palavra" é clicado
        private void BotaoAdicionarPalavra_Click(object sender, EventArgs e)
        {
            // Obtém a palavra selecionada na caixa de texto e remove espaços em branco
            string palavraSelecionada = caixaDeTexto.SelectedText.Trim();
            if (!string.IsNullOrEmpty(palavraSelecionada))
            {
                // Adiciona a palavra ao dicionário e destaca as palavras no texto
                dicionario.AdicionarPalavra(palavraSelecionada);
                DestacarPalavras();
            }
        }

        // Método de evento acionado quando o texto na caixa de texto é alterado
        private void CaixaDeTexto_TextChanged(object sender, EventArgs e)
        {
            // Destaca as palavras no texto
            DestacarPalavras();
        }

        // Método para destacar as palavras no texto que não estão no dicionário
        private void DestacarPalavras()
        {
            // Salva a posição e o tamanho da seleção atual
            int inicioSelecao = caixaDeTexto.SelectionStart;
            int tamanhoSelecao = caixaDeTexto.SelectionLength;

            // Remove os destaques existentes
            caixaDeTexto.SelectAll();
            caixaDeTexto.SelectionBackColor = Color.White;
            caixaDeTexto.SelectionColor = Color.Black;
            caixaDeTexto.SelectionFont = new Font(caixaDeTexto.Font, FontStyle.Regular);
            caixaDeTexto.DeselectAll();

            // Divide o texto em palavras
            string[] palavras = caixaDeTexto.Text.Split(new[] { ' ', '.', ',', '!', '?', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string palavra in palavras)
            {
                // Se a palavra não está no dicionário, destaca-a
                if (!dicionario.ContemPalavra(palavra))
                {
                    DestacarPalavra(palavra);
                }
            }

            // Restaura a posição e o tamanho da seleção
            caixaDeTexto.SelectionStart = inicioSelecao;
            caixaDeTexto.SelectionLength = tamanhoSelecao;
        }

        // Método para destacar uma palavra específica no texto
        private void DestacarPalavra(string palavra)
        {
            int indiceInicio = 0;
            // Procura a palavra no texto e a destaca
            while ((indiceInicio = caixaDeTexto.Text.IndexOf(palavra, indiceInicio, StringComparison.Ordinal)) != -1)
            {
                caixaDeTexto.Select(indiceInicio, palavra.Length);
                caixaDeTexto.SelectionColor = Color.Red;
                caixaDeTexto.SelectionFont = new Font(caixaDeTexto.Font, FontStyle.Underline);
                indiceInicio += palavra.Length;
            }
            caixaDeTexto.DeselectAll();
        }
    }
}
