namespace Editor_de_Texto
{
    partial class Form1
    {
        // Componente para gerenciar recursos
        private System.ComponentModel.IContainer components = null;

        // Método para liberar os recursos usados pelo formulário
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Método para inicializar os componentes do formulário
        private void InitializeComponent()
        {
            this.caixaDeTexto = new System.Windows.Forms.RichTextBox(); // Caixa de texto rica
            this.botaoAdicionarPalavra = new System.Windows.Forms.Button(); // Botão para adicionar palavra
            this.botaoCarregar = new System.Windows.Forms.Button(); // Botão para carregar dicionário
            this.botaoSalvar = new System.Windows.Forms.Button(); // Botão para salvar dicionário
            this.dialogoAbrirArquivo = new System.Windows.Forms.OpenFileDialog(); // Diálogo para abrir arquivo
            this.dialogoSalvarArquivo = new System.Windows.Forms.SaveFileDialog(); // Diálogo para salvar arquivo
            this.SuspendLayout();
            // 
            // caixaDeTexto
            // 
            this.caixaDeTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))); // Ancoragem da caixa de texto
            this.caixaDeTexto.Location = new System.Drawing.Point(12, 50); // Localização da caixa de texto
            this.caixaDeTexto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0); // Margem da caixa de texto
            this.caixaDeTexto.Name = "caixaDeTexto"; // Nome da caixa de texto
            this.caixaDeTexto.Size = new System.Drawing.Size(776, 388); // Tamanho da caixa de texto
            this.caixaDeTexto.TabIndex = 0; // Índice da tabulação
            this.caixaDeTexto.Text = ""; // Texto inicial vazio
            this.caixaDeTexto.TextChanged += new System.EventHandler(this.CaixaDeTexto_TextChanged); // Evento de mudança de texto
            // 
            // botaoAdicionarPalavra
            // 
            this.botaoAdicionarPalavra.Location = new System.Drawing.Point(12, 12); // Localização do botão
            this.botaoAdicionarPalavra.Margin = new System.Windows.Forms.Padding(0); // Margem do botão
            this.botaoAdicionarPalavra.Name = "botaoAdicionarPalavra"; // Nome do botão
            this.botaoAdicionarPalavra.Size = new System.Drawing.Size(150, 32); // Tamanho do botão
            this.botaoAdicionarPalavra.TabIndex = 1; // Índice da tabulação
            this.botaoAdicionarPalavra.Text = "Adicionar Palavra"; // Texto do botão
            this.botaoAdicionarPalavra.UseVisualStyleBackColor = true; // Usar estilo visual do botão
            this.botaoAdicionarPalavra.Click += new System.EventHandler(this.BotaoAdicionarPalavra_Click); // Evento de clique do botão
            // 
            // botaoCarregar
            // 
            this.botaoCarregar.Location = new System.Drawing.Point(170, 12); // Localização do botão
            this.botaoCarregar.Margin = new System.Windows.Forms.Padding(0); // Margem do botão
            this.botaoCarregar.Name = "botaoCarregar"; // Nome do botão
            this.botaoCarregar.Size = new System.Drawing.Size(150, 32); // Tamanho do botão
            this.botaoCarregar.TabIndex = 2; // Índice da tabulação
            this.botaoCarregar.Text = "Carregar Dicionário"; // Texto do botão
            this.botaoCarregar.UseVisualStyleBackColor = true; // Usar estilo visual do botão
            this.botaoCarregar.Click += new System.EventHandler(this.BotaoCarregar_Click); // Evento de clique do botão
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(330, 12); // Localização do botão
            this.botaoSalvar.Margin = new System.Windows.Forms.Padding(0); // Margem do botão
            this.botaoSalvar.Name = "botaoSalvar"; // Nome do botão
            this.botaoSalvar.Size = new System.Drawing.Size(150, 32); // Tamanho do botão
            this.botaoSalvar.TabIndex = 3; // Índice da tabulação
            this.botaoSalvar.Text = "Salvar Dicionário"; // Texto do botão
            this.botaoSalvar.UseVisualStyleBackColor = true; // Usar estilo visual do botão
            this.botaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click); // Evento de clique do botão
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F); // Dimensões de autoescalonamento
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Modo de autoescalonamento
            this.ClientSize = new System.Drawing.Size(800, 450); // Tamanho do formulário
            this.Controls.Add(this.botaoSalvar); // Adiciona o botão salvar ao formulário
            this.Controls.Add(this.botaoCarregar); // Adiciona o botão carregar ao formulário
            this.Controls.Add(this.botaoAdicionarPalavra); // Adiciona o botão adicionar palavra ao formulário
            this.Controls.Add(this.caixaDeTexto); // Adiciona a caixa de texto ao formulário
            this.Name = "Form1"; // Nome do formulário
            this.Text = "Editor de Texto com Dicionário"; // Texto do título do formulário
            this.ResumeLayout(false); // Finaliza a configuração do layout do formulário
        }

        // Componentes do formulário
        private System.Windows.Forms.RichTextBox caixaDeTexto;
        private System.Windows.Forms.Button botaoAdicionarPalavra;
        private System.Windows.Forms.Button botaoCarregar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.OpenFileDialog dialogoAbrirArquivo;
        private System.Windows.Forms.SaveFileDialog dialogoSalvarArquivo;
    }
}
