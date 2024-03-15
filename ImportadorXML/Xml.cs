using System;
using System.Windows.Forms;
using System.Xml;

namespace ImportadorXML
{
    public class Xml
    {
        public int NNf { get; private set; }
        public string NProt { get; private set; }

        public string ChNFe { get; private set; }

        public string NfeDenegada { get; private set; }

        public string XmlString { get; private set; }

        public bool LerArquivo(string caminhoArquivo, string nfDenegada)
        {
            string nNf = null;
            string nProt = null;
            string chNFe = null;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                xmlDoc.Load(caminhoArquivo);
                XmlString = xmlDoc.OuterXml;

                using (XmlReader lerXml = XmlReader.Create(caminhoArquivo))
                {
                    while (lerXml.Read())
                    {
                        if (lerXml.NodeType == XmlNodeType.Element)
                        {
                            switch (lerXml.Name)
                            {
                                case "nNF":
                                    nNf = lerXml.ReadElementContentAsString();
                                    break;

                                case "nProt":
                                    nProt = lerXml.ReadElementContentAsString();
                                    break;

                                case "chNFe":
                                    chNFe = lerXml.ReadElementContentAsString();
                                    break;
                            }
                        }
                    }

                    // Verifica se todos os elementos foram encontrados
                    if (XmlString == null || nNf == null || nProt == null || chNFe == null || nfDenegada == null)
                    {
                        MessageBox.Show("O arquivo XML não possui todos os elementos necessários. Por favor, selecione outro arquivo e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        // Se todos os elementos foram encontrados, podemos atribuí-los às variáveis
                        NNf = int.Parse(nNf);
                        NProt = nProt;
                        ChNFe = chNFe;
                        NfeDenegada = nfDenegada;

                        return true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao ler o arquivo XML", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}