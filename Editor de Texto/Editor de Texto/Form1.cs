namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        private Dicionario dicionario;

        public Form1()
        {
            InitializeComponent();
            dicionario = new Dicionario();
        }

        private void BotaoCarregar_Click(object sender, EventArgs e)
        {
            dialogoAbrirArquivo.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
            if (dialogoAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                dicionario.CarregarDeArquivo(dialogoAbrirArquivo.FileName);
            }
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            dialogoSalvarArquivo.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
            if (dialogoSalvarArquivo.ShowDialog() == DialogResult.OK)
            {
                dicionario.SalvarEmArquivo(dialogoSalvarArquivo.FileName);
            }
        }

        private void BotaoAdicionarPalavra_Click(object sender, EventArgs e)
        {
            string palavraSelecionada = caixaDeTexto.SelectedText.Trim();
            if (!string.IsNullOrEmpty(palavraSelecionada))
            {
                dicionario.AdicionarPalavra(palavraSelecionada);
                DestacarPalavras();
            }
        }

        private void CaixaDeTexto_TextChanged(object sender, EventArgs e)
        {
            DestacarPalavras();
        }

        private void DestacarPalavras()
        {
            int inicioSelecao = caixaDeTexto.SelectionStart;
            int tamanhoSelecao = caixaDeTexto.SelectionLength;

            caixaDeTexto.SelectAll();
            caixaDeTexto.SelectionBackColor = Color.White;
            caixaDeTexto.SelectionColor = Color.Black;
            caixaDeTexto.SelectionFont = new Font(caixaDeTexto.Font, FontStyle.Regular);
            caixaDeTexto.DeselectAll();

            string[] palavras = caixaDeTexto.Text.Split(new[] { ' ', '.', ',', '!', '?', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string palavra in palavras)
            {
                if (!dicionario.ContemPalavra(palavra))
                {
                    DestacarPalavra(palavra);
                }
            }

            caixaDeTexto.SelectionStart = inicioSelecao;
            caixaDeTexto.SelectionLength = tamanhoSelecao;
        }

        private void DestacarPalavra(string palavra)
        {
            int indiceInicio = 0;
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
