using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            abrirXml.Multiselect = true;

            List<string> listaInseridos = new List<string>();
            List<string> listaNaoInseridos = new List<string>();

            if (abrirXml.ShowDialog() == DialogResult.OK)
            {
                foreach (string Arquivos in abrirXml.FileNames)
                {
                    Xml notaFiscal = new Xml();
                    caminhoArquivo.Text += $" {Arquivos}";

                    string denegada = (denegadaS.Checked == true) ? "S" : "N";

                    try
                    {
                        string selecionado = listaEmpresas.SelectedItem.ToString();

                        selecionado = String.Join("", System.Text.RegularExpressions.Regex.Split(selecionado, @"[^\d]"));
                        int idEmpresa = int.Parse(selecionado);

                        if (notaFiscal.LerArquivo(Arquivos, denegada) == true)
                        {
                            BancoDados bancoDados = new BancoDados(caminhoBanco.Text, ipBanco.Text);
                            var inserir = bancoDados.InsirirDados(idEmpresa, notaFiscal.NNf, notaFiscal.ChNFe, notaFiscal.NfeDenegada, notaFiscal.NProt, notaFiscal.XmlString);
                            visualizarXml.Rows.Add(selecionado, notaFiscal.NNf, notaFiscal.ChNFe, notaFiscal.NProt, bancoDados.Lote, notaFiscal.XmlString);

                            switch (inserir)
                            {
                                case true:
                                    listaInseridos.Add($"{notaFiscal.NNf}");
                                    break;

                                case false:
                                    listaNaoInseridos.Add($"{notaFiscal.NNf}");
                                    break;
                            }
                        }
                    }
                    // tem que arrumar para o denegado ?
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

                denegadaS.Checked = false;

                string resultoInseridos = String.Join(", ", listaInseridos);
                string resultoNaoInseridos = String.Join(", ", listaNaoInseridos);
                MessageBox.Show($"Notas Inseridas: {resultoInseridos} \nNotas Não Inseridas ou Repitidas: {resultoNaoInseridos}", "Informções", MessageBoxButtons.OK, MessageBoxIcon.Information);
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