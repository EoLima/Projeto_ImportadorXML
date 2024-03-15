using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Windows.Forms;

namespace ImportadorXML
{
    internal class BancoDados
    {
        private string Conexao;
        private string CaminhoBanco;
        private string Ip;
        public string Lote { get; private set; }

        public BancoDados(string caminhoBanco, string ip)
        {
            CaminhoBanco = caminhoBanco;
            Ip = ip;
            Conexao = $"User=SYSDBA;Password=masterkey;Database={CaminhoBanco}\\nfe.fdb;DataSource={Ip};Port=3050;Dialect=3;";
            Lote = "LOTE_IMP_USU_00.00.00_00000000000000_0-.xml";
        }

        public bool ConexaoBanco()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(Conexao))
                {
                    conexao.Open();
                    // Se a conexão for bem-sucedida, retorna true
                    MessageBox.Show("Conexão foi um sucesso!", "Conexão Estabelecida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (FileNotFoundException)
            {
                // Se houver uma exceção ao abrir a conexão, retorna false
                MessageBox.Show($"Não foi localizado um arquivo de Banco de Dados, confira pasta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (FbException)
            {
                // Se houver uma exceção ao abrir a conexão, retorna false
                MessageBox.Show($"Conexão deu errado, conserte os parâmetros de entrada ao Banco de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool InsirirDados(int idEmpresa, int nNf, string chNFe, string nfeDenegada, string nProt, string xml)
        {
            try
            {
                string consultaInsercao = "INSERT INTO PEDIDO_FAT_NFE (PEDF_PEDF_EMP_ID, PEDF_PEDF_ID, PEDF_NFE_CHAVE, PEDF_NFE_DENEGADA, PEDF_NFE_PROT_AUT_NFE, PEDF_NFE_NOME_LOTE, PEDF_NFE) VALUES (@PEDF_PEDF_EMP_ID, @PEDF_PEDF_ID, @PEDF_NFE_CHAVE, @PEDF_NFE_DENEGADA, @PEDF_NFE_PROT_AUT_NFE, @PEDF_NFE_NOME_LOTE, @PEDF_NFE)";

                using (FbConnection conexao = new FbConnection(Conexao))
                {
                    conexao.Open();

                    using (FbCommand comando = new FbCommand(consultaInsercao, conexao))
                    {
                        // Adicione parâmetros para evitar injeção de SQL
                        comando.Parameters.AddWithValue("@PEDF_PEDF_EMP_ID", idEmpresa);
                        comando.Parameters.AddWithValue("@PEDF_PEDF_ID", nNf);
                        comando.Parameters.AddWithValue("@PEDF_NFE_CHAVE", chNFe);
                        comando.Parameters.AddWithValue("@PEDF_NFE_DENEGADA", nfeDenegada);
                        comando.Parameters.AddWithValue("@PEDF_NFE_PROT_AUT_NFE", nProt);
                        comando.Parameters.AddWithValue("@PEDF_NFE_NOME_LOTE", Lote);
                        comando.Parameters.AddWithValue("@PEDF_NFE", xml);

                        comando.ExecuteNonQuery();
                        conexao.Close();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public void ConsultarEmpresas(ListBox listaEmpresa)
        {
            using (FbConnection conexao = new FbConnection(Conexao))
            {
                conexao.Open();

                using (FbCommand comando = new FbCommand("SELECT EMP_ID, EMP_NOME FROM EMPRESA", conexao))
                {
                    using (FbDataReader ler = comando.ExecuteReader())
                    {
                        listaEmpresa.Items.Clear();

                        while (ler.Read())
                        {
                            // Ler os dados do resultado da consulta
                            int idEmpresa = ler.GetInt32(ler.GetOrdinal("EMP_ID"));
                            string nomeEmpresa = ler.GetString(ler.GetOrdinal("EMP_NOME"));
                            listaEmpresa.Items.Add($"{idEmpresa} - {nomeEmpresa}");
                        }
                    }
                }
            }
        }
    }
}