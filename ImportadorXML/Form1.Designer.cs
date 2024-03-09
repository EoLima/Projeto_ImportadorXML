namespace ImportadorXML
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.procurarArquivo = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.caminhoArquivo = new System.Windows.Forms.TextBox();
            this.abrirXml = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.visualizarXml = new System.Windows.Forms.DataGridView();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chNFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nProt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmacao = new System.Windows.Forms.Label();
            this.caminhoBanco = new System.Windows.Forms.TextBox();
            this.ipBanco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.procurarBanco = new System.Windows.Forms.Button();
            this.abrirBanco = new System.Windows.Forms.FolderBrowserDialog();
            this.testarConexao = new System.Windows.Forms.Button();
            this.listaEmpresas = new System.Windows.Forms.ListBox();
            this.versao = new System.Windows.Forms.Label();
            this.selecionarEmpresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visualizarXml)).BeginInit();
            this.SuspendLayout();
            // 
            // procurarArquivo
            // 
            this.procurarArquivo.Location = new System.Drawing.Point(10, 233);
            this.procurarArquivo.Name = "procurarArquivo";
            this.procurarArquivo.Size = new System.Drawing.Size(130, 26);
            this.procurarArquivo.TabIndex = 0;
            this.procurarArquivo.Text = "Procurar Arquivo XML";
            this.procurarArquivo.UseVisualStyleBackColor = true;
            this.procurarArquivo.Click += new System.EventHandler(this.procurarArquivo_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(197, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(244, 31);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Importador de XML";
            // 
            // caminhoArquivo
            // 
            this.caminhoArquivo.Location = new System.Drawing.Point(146, 237);
            this.caminhoArquivo.Name = "caminhoArquivo";
            this.caminhoArquivo.ReadOnly = true;
            this.caminhoArquivo.Size = new System.Drawing.Size(396, 20);
            this.caminhoArquivo.TabIndex = 2;
            // 
            // abrirXml
            // 
            this.abrirXml.FileName = "abrirXml";
            this.abrirXml.Filter = "\"XML Files|*.xml\"";
            this.abrirXml.InitialDirectory = "@\"C:\\\"";
            this.abrirXml.Title = "Loclizar Arquivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CONFIGURAR ACESSO AO BANCO DE DADOS";
            // 
            // visualizarXml
            // 
            this.visualizarXml.AllowUserToAddRows = false;
            this.visualizarXml.AllowUserToDeleteRows = false;
            this.visualizarXml.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.visualizarXml.BackgroundColor = System.Drawing.Color.White;
            this.visualizarXml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visualizarXml.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.visualizarXml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visualizarXml.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empresa,
            this.cNF,
            this.chNFe,
            this.nProt});
            this.visualizarXml.Location = new System.Drawing.Point(12, 263);
            this.visualizarXml.Name = "visualizarXml";
            this.visualizarXml.ReadOnly = true;
            this.visualizarXml.Size = new System.Drawing.Size(629, 105);
            this.visualizarXml.TabIndex = 6;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // cNF
            // 
            this.cNF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cNF.FillWeight = 76.14214F;
            this.cNF.HeaderText = "Número NF";
            this.cNF.Name = "cNF";
            this.cNF.ReadOnly = true;
            this.cNF.Width = 90;
            // 
            // chNFe
            // 
            this.chNFe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.chNFe.FillWeight = 155.2927F;
            this.chNFe.HeaderText = "Chave NF";
            this.chNFe.Name = "chNFe";
            this.chNFe.ReadOnly = true;
            this.chNFe.Width = 280;
            // 
            // nProt
            // 
            this.nProt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nProt.FillWeight = 68.56519F;
            this.nProt.HeaderText = "Número Protocolo";
            this.nProt.Name = "nProt";
            this.nProt.ReadOnly = true;
            this.nProt.Width = 120;
            // 
            // confirmacao
            // 
            this.confirmacao.AutoSize = true;
            this.confirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmacao.ForeColor = System.Drawing.Color.Green;
            this.confirmacao.Location = new System.Drawing.Point(235, 371);
            this.confirmacao.Name = "confirmacao";
            this.confirmacao.Size = new System.Drawing.Size(0, 26);
            this.confirmacao.TabIndex = 7;
            this.confirmacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caminhoBanco
            // 
            this.caminhoBanco.Location = new System.Drawing.Point(146, 104);
            this.caminhoBanco.Name = "caminhoBanco";
            this.caminhoBanco.ReadOnly = true;
            this.caminhoBanco.Size = new System.Drawing.Size(343, 20);
            this.caminhoBanco.TabIndex = 9;
            // 
            // ipBanco
            // 
            this.ipBanco.Location = new System.Drawing.Point(146, 130);
            this.ipBanco.Name = "ipBanco";
            this.ipBanco.Size = new System.Drawing.Size(189, 20);
            this.ipBanco.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Local do Banco de Dados:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "IP do Banco de Dados:";
            // 
            // procurarBanco
            // 
            this.procurarBanco.Location = new System.Drawing.Point(495, 104);
            this.procurarBanco.Name = "procurarBanco";
            this.procurarBanco.Size = new System.Drawing.Size(55, 22);
            this.procurarBanco.TabIndex = 13;
            this.procurarBanco.Text = "Procurar";
            this.procurarBanco.UseVisualStyleBackColor = true;
            this.procurarBanco.Click += new System.EventHandler(this.procurarBanco_Click);
            // 
            // testarConexao
            // 
            this.testarConexao.Location = new System.Drawing.Point(355, 129);
            this.testarConexao.Name = "testarConexao";
            this.testarConexao.Size = new System.Drawing.Size(98, 21);
            this.testarConexao.TabIndex = 14;
            this.testarConexao.Text = "Testar Conexão";
            this.testarConexao.UseVisualStyleBackColor = true;
            this.testarConexao.Click += new System.EventHandler(this.testarConexao_Click);
            // 
            // listaEmpresas
            // 
            this.listaEmpresas.FormattingEnabled = true;
            this.listaEmpresas.Location = new System.Drawing.Point(146, 156);
            this.listaEmpresas.Name = "listaEmpresas";
            this.listaEmpresas.Size = new System.Drawing.Size(189, 43);
            this.listaEmpresas.TabIndex = 15;
            // 
            // versao
            // 
            this.versao.AutoSize = true;
            this.versao.Location = new System.Drawing.Point(580, 384);
            this.versao.Name = "versao";
            this.versao.Size = new System.Drawing.Size(61, 13);
            this.versao.TabIndex = 16;
            this.versao.Text = "Versão: 0.2";
            // 
            // selecionarEmpresa
            // 
            this.selecionarEmpresa.AutoSize = true;
            this.selecionarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionarEmpresa.Location = new System.Drawing.Point(28, 170);
            this.selecionarEmpresa.Name = "selecionarEmpresa";
            this.selecionarEmpresa.Size = new System.Drawing.Size(110, 13);
            this.selecionarEmpresa.TabIndex = 17;
            this.selecionarEmpresa.Text = "Selecione a Empresa:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(653, 406);
            this.Controls.Add(this.selecionarEmpresa);
            this.Controls.Add(this.versao);
            this.Controls.Add(this.listaEmpresas);
            this.Controls.Add(this.testarConexao);
            this.Controls.Add(this.procurarBanco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ipBanco);
            this.Controls.Add(this.caminhoBanco);
            this.Controls.Add(this.confirmacao);
            this.Controls.Add(this.visualizarXml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caminhoArquivo);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.procurarArquivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Importador de XML";
            ((System.ComponentModel.ISupportInitialize)(this.visualizarXml)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button procurarArquivo;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox caminhoArquivo;
        private System.Windows.Forms.OpenFileDialog abrirXml;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView visualizarXml;
        private System.Windows.Forms.Label confirmacao;
        private System.Windows.Forms.TextBox caminhoBanco;
        private System.Windows.Forms.TextBox ipBanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button procurarBanco;
        private System.Windows.Forms.FolderBrowserDialog abrirBanco;
        private System.Windows.Forms.Button testarConexao;
        private System.Windows.Forms.ListBox listaEmpresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn chNFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nProt;
        private System.Windows.Forms.Label versao;
        private System.Windows.Forms.Label selecionarEmpresa;
    }
}

