namespace Editor_de_Texto
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.caixaDeTexto = new System.Windows.Forms.RichTextBox();
            this.botaoAdicionarPalavra = new System.Windows.Forms.Button();
            this.botaoCarregar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.dialogoAbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.dialogoSalvarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // caixaDeTexto
            // 
            this.caixaDeTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caixaDeTexto.Location = new System.Drawing.Point(12, 50);
            this.caixaDeTexto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.caixaDeTexto.Name = "caixaDeTexto";
            this.caixaDeTexto.Size = new System.Drawing.Size(776, 388);
            this.caixaDeTexto.TabIndex = 0;
            this.caixaDeTexto.Text = "";
            this.caixaDeTexto.TextChanged += new System.EventHandler(this.CaixaDeTexto_TextChanged);
            // 
            // botaoAdicionarPalavra
            // 
            this.botaoAdicionarPalavra.Location = new System.Drawing.Point(12, 12);
            this.botaoAdicionarPalavra.Margin = new System.Windows.Forms.Padding(0);
            this.botaoAdicionarPalavra.Name = "botaoAdicionarPalavra";
            this.botaoAdicionarPalavra.Size = new System.Drawing.Size(150, 32);
            this.botaoAdicionarPalavra.TabIndex = 1;
            this.botaoAdicionarPalavra.Text = "Adicionar Palavra";
            this.botaoAdicionarPalavra.UseVisualStyleBackColor = true;
            this.botaoAdicionarPalavra.Click += new System.EventHandler(this.BotaoAdicionarPalavra_Click);
            // 
            // botaoCarregar
            // 
            this.botaoCarregar.Location = new System.Drawing.Point(170, 12);
            this.botaoCarregar.Margin = new System.Windows.Forms.Padding(0);
            this.botaoCarregar.Name = "botaoCarregar";
            this.botaoCarregar.Size = new System.Drawing.Size(150, 32);
            this.botaoCarregar.TabIndex = 2;
            this.botaoCarregar.Text = "Carregar Dicionário";
            this.botaoCarregar.UseVisualStyleBackColor = true;
            this.botaoCarregar.Click += new System.EventHandler(this.BotaoCarregar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(330, 12);
            this.botaoSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(150, 32);
            this.botaoSalvar.TabIndex = 3;
            this.botaoSalvar.Text = "Salvar Dicionário";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.botaoCarregar);
            this.Controls.Add(this.botaoAdicionarPalavra);
            this.Controls.Add(this.caixaDeTexto);
            this.Name = "Form1";
            this.Text = "Editor de Texto com Dicionário";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox caixaDeTexto;
        private System.Windows.Forms.Button botaoAdicionarPalavra;
        private System.Windows.Forms.Button botaoCarregar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.OpenFileDialog dialogoAbrirArquivo;
        private System.Windows.Forms.SaveFileDialog dialogoSalvarArquivo;
    }
}
