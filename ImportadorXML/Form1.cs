using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImportadorXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void procurarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirXml = new OpenFileDialog();

            //Filtros para ler apenas arquivos XML
            abrirXml.Filter = "XML Files|*.xml";
            abrirXml.FilterIndex = 0;
            abrirXml.DefaultExt = "xml";

            if (abrirXml.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = abrirXml.FileName;
                Xml notaFiscal = new Xml();

                this.caminhoArquivo.Text = caminhoArquivo;

                try
                {
                    string selecionado = listaEmpresas.SelectedItem.ToString();

                    selecionado = String.Join("", System.Text.RegularExpressions.Regex.Split(selecionado, @"[^\d]"));
                    int idEmpresa = int.Parse(selecionado);

                    if (notaFiscal.LerArquivo(caminhoArquivo) == true)
                    {
                        visualizarXml.Rows.Add(selecionado, notaFiscal.NNf, notaFiscal.ChNFe, notaFiscal.NProt);
                        BancoDados bancoDados = new BancoDados(caminhoBanco.Text, ipBanco.Text);
                        var inserir = bancoDados.InsirirDados(idEmpresa, notaFiscal.NNf, notaFiscal.ChNFe, notaFiscal.NfeDenegada, notaFiscal.NProt);

                        switch (inserir)
                        {
                            case true:
                                confirmacao.ForeColor = Color.Green;
                                confirmacao.Text = "INSERIDO!";
                                break;

                            case false:
                                confirmacao.ForeColor = Color.Red;
                                confirmacao.Text = "XML JÁ IMPORTADO.";
                                break;
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    if (string.IsNullOrEmpty(caminhoBanco.Text))
                    {
                        MessageBox.Show($"Selecione a pasta do Banco de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(ipBanco.Text) && listaEmpresas.SelectedItem == null && !string.IsNullOrEmpty(caminhoBanco.Text))
                    {
                        MessageBox.Show($"Verifique o Ip do Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (listaEmpresas.SelectedItem == null && !string.IsNullOrEmpty(ipBanco.Text) && !string.IsNullOrEmpty(caminhoBanco.Text))
                    {
                        MessageBox.Show($"Selecione Uma Empresa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void procurarBanco_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog abrirBanco = new FolderBrowserDialog();

            if (abrirBanco.ShowDialog() == DialogResult.OK)
            {
                caminhoBanco.Text = abrirBanco.SelectedPath;
            }
        }

        private void testarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                listaEmpresas.Items.Clear();
                BancoDados bancoDados = new BancoDados(caminhoBanco.Text, ipBanco.Text);

                if (bancoDados.ConexaoBanco() == true)
                {
                    bancoDados.ConsultarEmpresas(listaEmpresas);
                }
            }
            catch (ArgumentException)
            {
                if (string.IsNullOrEmpty(caminhoBanco.Text))
                {
                    MessageBox.Show($"Selecione a pasta do Banco de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(ipBanco.Text) && listaEmpresas.SelectedItem == null && !string.IsNullOrEmpty(caminhoBanco.Text))
                {
                    MessageBox.Show($"Verifique o Ip do Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (listaEmpresas.SelectedItem == null && !string.IsNullOrEmpty(ipBanco.Text) && !string.IsNullOrEmpty(caminhoBanco.Text))
                {
                    MessageBox.Show($"Selecione Uma Empresa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}