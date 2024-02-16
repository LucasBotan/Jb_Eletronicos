using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.IO;

namespace CRMagazine
{
    public partial class frmEtiquetas : Form
    {
        public frmEtiquetas()
        {
            InitializeComponent();
        }

        Impressao imprimir = new Impressao();
        Consulta consulta = new Consulta();

        private void frmEtiquetas_Load(object sender, EventArgs e)
        {
            rbt200dpi.Checked = true;
        }

        public string RemoverAcentos(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";
            else
            {
                byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(input);
                return System.Text.Encoding.UTF8.GetString(bytes);
            }
        }


        public void Imprimir()
        {
            string codZPL = "";
            //set variavel do modelo para consulta da etiqueta..
            //seta todas variaves do classe impressão...
            if (tabEtiquetas.SelectedTab == tpTriagem)
            {
                consulta.Coluna = "NS";
                consulta.ValorDesejado = txtChamadoTriagem.Text;
                consulta.ComData = "SIM";
                //consulta.DataDesejada = txtDataDesejadaNaoLimpar.Text;
                consulta.ConsultaTudo();
                if (consulta.Descricao == "")
                {
                    MessageBox.Show("CHAMADO NÃO ENCONTRADO.");
                }
                else
                {
                    codZPL = "";
                    //imprimir.TextoLivre = txtNS.Text;
                    string varejista = RemoverAcentos(consulta.Varejista);

                    imprimir.Varejista = "MAGAZINE LUIZA - " + RemoverAcentos(consulta.Cidade);

                    string Class = RemoverAcentos(consulta.Classificacao);

                    if (Class == "FORA DE GARANTIA")
                    {
                        if (consulta.ObsClassificacao == "MAU USO / SUCATA")
                        {
                            Class = "OBSOLETO";
                        }
                        else
                        {
                            Class = "REMESSA ORCAMENTO";
                        }
                    }
                    else if (Class.Contains("DEVOLUCAO DE VENDA"))
                    {
                        Class = "DEVOLUCAO DOA";
                    }
                    if (Class == "REPARO FUNCIONAL - GARANTIA")
                    {
                        Class = "REMESSA GARANTIA";
                    }
                    if (Class == "REPARO FUNCIONAL - ORCAMENTO")
                    {
                        Class = "REMESSA ORCAMENTO";
                    }
                        
                    
                   
                    imprimir.Classificacao = Class;
                    imprimir.IMEI1 = consulta.IMEI1;

                    
                    imprimir.NFOrigem = consulta.NF;
                    imprimir.Genco = consulta.CodVarejo;
                    imprimir.ChamadoPai = consulta.ChamadoPai;
                    imprimir.NS = consulta.NS;
                    consulta.CodPositivo = consulta.SKU;
                    imprimir.Filial = consulta.Filial;
                    imprimir.Cidade = consulta.Cidade;
                    consulta.consultarImpressao();
                    
                    if (consulta.Retorno == "falha")
                    {
                        consulta.PlayFail();
                        MessageBox.Show("CODIGO EAN NÃO CADASTRADO");
                    }
                    
                    //MessageBox.Show(consulta.EAN);
                    imprimir.CodEAN = consulta.EAN.Trim();
                    /*
                    string PrimeiroDigito = consulta.NS.Substring(0, 2);
                    if (PrimeiroDigito == "1A")
                    {
                        imprimir.Destino = "CURITIBA";
                    }
                    else
                    {
                        imprimir.Destino = "MANAUS";
                    }                    
                    imprimir.Funcional = RemoverAcentos(consulta.Funcional);
                    imprimir.Estetico = RemoverAcentos(consulta.Estetico);
                    imprimir.Faltante = RemoverAcentos(consulta.ItensFaltantes);
                    */

                    //================VERIFICA SE É RETENÇÃO OU NÃO =================
                    if (consulta.Classificacao == "RETENCAO" || consulta.Classificacao.Contains("SALDO"))
                    {
                        imprimir.Classificacao = consulta.Classificacao;
                        imprimir.Genco = consulta.CodVarejo;

                        consulta.CodPositivo = consulta.SKU;
                        consulta.consultarImpressao();
                        if (consulta.Retorno == "falha")
                        {
                            consulta.PlayFail();
                            MessageBox.Show("CODIGO EAN NÃO CADASTRADO");
                        }
                        imprimir.CodEAN = consulta.EAN.Trim();
                       // imprimir.produto = consulta.DescricaoEan;
                        imprimir.Serial = consulta.NS;
                        imprimir.ModeloMag = consulta.Descricao;
                        imprimir.EtiqChameOGenio = consulta.NumLacre;
                        imprimir.CodAtendimentoChameGenio = "";
                        imprimir.Lacre = consulta.NumLacre;
                        imprimir.Filial = consulta.Filial;
                        imprimir.Cidade = consulta.Cidade;
                        
                        if (rbt300dpi.Checked)
                        {
                            imprimir.Magazine();
                        }
                        else if (rbt200dpi.Checked)
                        {
                            imprimir.Magazine200dpi();
                        }
                        else
                        {
                            imprimir.Magazine600dpi();
                        }
                    }
                    else
                    {
                        if (rbt300dpi.Checked)
                        {
                            imprimir.EtiquetaLivre300dpi();
                        }
                        else if (rbt200dpi.Checked)
                        {                            
                            imprimir.EtiquetaLivre200dpi();
                        }
                        else
                        {
                            imprimir.EtiquetaLivre600dpi();
                        }
                    }
                   
                    codZPL = imprimir.s;
                }
            }
            else if (tabEtiquetas.SelectedTab == tpEAN)
            {
                imprimir.IMEI1 = txtIMEI1.Text;
                imprimir.IMEI2 = txtIMEI2.Text;
                imprimir.CodEAN = txtEAN.Text.Trim();
               
                imprimir.codPositivo = txtCodPositivo.Text;
                imprimir.NS = txtNSEAN.Text;

                consulta.CodPositivo = txtCodPositivo.Text;
                consulta.consultarImpressao();
                if (consulta.Retorno == "falha")
                {
                    consulta.PlayFail();
                    MessageBox.Show("CODIGO EAN NÃO CADASTRADO");
                }
                imprimir.Anatel = consulta.Anatel;
                imprimir.produto = consulta.DescricaoEan;
                imprimir.configuracao1 = consulta.Config1;
                imprimir.configuracao2 = consulta.Config2;
                imprimir.configuracao3 = consulta.Config3;
                imprimir.configuracao4 = consulta.Config4;
                imprimir.configuracao5 = consulta.Config5;
                imprimir.configuracao6 = consulta.Config6;
                imprimir.configuracao7 = consulta.Config7;
                imprimir.configuracao8 = consulta.Config8;
                imprimir.configuracao9 = consulta.Config9;
                imprimir.configuracao10 = consulta.Config10;
                imprimir.configuracao11 = consulta.Config11;

                if (consulta.TipoEtiqueta == "CELULAR")
                {
                    if (rbt600dpi.Checked)
                    {
                        imprimir.EtiqCelularNova600();
                    }
                    else if (rbt200dpi.Checked)
                    {
                        imprimir.EtiqCelularNova200();
                    }
                    else
                    {
                        imprimir.EtiqCelularNova();
                    }                    
                }
                else if (consulta.TipoEtiqueta == "EANHORIZONTAL")
                {
                    if (rbt600dpi.Checked)
                    {
                        imprimir.EtiqEANHorizontal600();
                    }
                    else if (rbt200dpi.Checked)
                    {
                        imprimir.EtiqEANHorizontal200();
                    }
                    else
                    {
                        imprimir.EtiqEANHorizontal();
                    }                    
                }
                else if (consulta.TipoEtiqueta == "EANVERTICAL")
                {
                    if (rbt600dpi.Checked)
                    {
                        imprimir.EtiqEAN600();
                    }
                    else if (rbt200dpi.Checked)
                    {
                        imprimir.EtiqEAN200();
                    }
                    else
                    {
                        imprimir.EtiqEAN();
                    }                    
                }
                else if (consulta.TipoEtiqueta == "TABLET")
                {
                    if (rbt600dpi.Checked)
                    {
                       // MessageBox.Show(imprimir.CodEAN);
                        imprimir.Tablet600();
                    }
                    else if (rbt200dpi.Checked)
                    {
                        imprimir.Tablet200();
                    }
                    else
                    {
                        imprimir.Tablet();
                    }                    
                }
                else if (consulta.TipoEtiqueta == "TABLET3G")
                {
                    if (rbt600dpi.Checked)
                    {
                        imprimir.Tablet3G600();
                    }
                    else if (rbt200dpi.Checked)
                    {
                        imprimir.Tablet3G200();
                    }
                    else
                    {
                        imprimir.Tablet3G();
                    }                    
                }
                else if (consulta.TipoEtiqueta == "QUANTUM")
                {
                    if (rbt600dpi.Checked)
                    {
                        imprimir.Quantum600();
                    }
                    else if (rbt200dpi.Checked)
                    {
                        imprimir.Quantum200();
                    }
                    else
                    {
                        imprimir.Quantum();
                    }                    
                }
                else
                {
                    MessageBox.Show("Etiqueta não encontrada!\r\nChamar o Suporte.");
                }

                codZPL = imprimir.s;
            }
            else
            {
                MessageBox.Show("Não foi possivel concluir a Impressão!");
            }

            if (codZPL.Length == 0)
            {
                MessageBox.Show("MODELO NÃO CADASTRADO");
            }
            else
            {
                if (chbSelecionarImpressora.Checked)
                {
                    // Allow the user to select a printer.
                    PrintDialog pd = new PrintDialog();
                    pd.PrinterSettings = new PrinterSettings();
                    if (DialogResult.OK == pd.ShowDialog(this))
                    {
                        // Send a printer-specific to the printer.
                        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, codZPL);
                    }
                }
                else
                {
                    string nomeImpressoraPadrao = (new PrinterSettings()).PrinterName;
                    RawPrinterHelper.SendStringToPrinter(nomeImpressoraPadrao, codZPL);
                }
            }

        }

        private void btnConcluirTriagem_Click(object sender, EventArgs e)
        {
            Imprimir();
            consulta.LimparControles(this);
            txtChamadoTriagem.Select();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            
        }

        private void lnkCadastrarEtq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAjustesCriarEAN c = new frmAjustesCriarEAN();
            c.Show();
        }

        private void btnConcluirEAN_Click(object sender, EventArgs e)
        {
            Imprimir();
            consulta.LimparControles(this);
            txtChamadoTriagem.Select();
        }

        private void txtNSEAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                consulta.NumeroSerie = txtNSEAN.Text;
                consulta.ConsultarNSEQUISAP();

                if (consulta.SAPCodPos.Length > 0)
                {
                    txtCodPositivo.Text = consulta.SAPCodPos.TrimStart('0');
                    ConsultarEAN();
                }
                else
                {
                    consulta.PlayFail();
                    MessageBox.Show("CÓDIGO POSITIVO NÃO ENCONTRADO.\r\nVERIFICAR NS OU PREENCHER MANUALMENTE.");                    
                }
                
            }    
        }

        private void txtCodPositivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConsultarEAN();
        }

        public void ConsultarEAN()
        {
            consulta.CodPositivo = txtCodPositivo.Text;
            consulta.consultarImpressao();
            if (consulta.Retorno == "falha")
            {
                consulta.PlayFail();
                MessageBox.Show("CODIGO EAN NÃO CADASTRADO");
            }
            else
            {
                txtEAN.Text = consulta.EAN;
                txtTipo.Text = consulta.TipoEtiqueta;
                if (txtTipo.Text == "CELULAR" || txtTipo.Text == "QUANTUM" || txtTipo.Text == "TABLET3G")
                {
                    consulta.Coluna = "NS";
                    consulta.ValorDesejado = txtNSEAN.Text;
                    consulta.ConsultaTudo();                    
                    txtIMEI1.Text = consulta.IMEI1;
                    txtIMEI2.Text = consulta.IMEI2;
                    if (txtIMEI1.Text.Length == 0)
                    {
                        txtIMEI1.Select();
                    }
                    else
                    {
                        btnConcluirEAN.Select();
                    }
                }
                else
                {
                    btnConcluirEAN.Select();
                }
            }
        }

        private void txtIMEI1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(txtTipo.Text == "TABLET3G")
                {
                    btnConcluirEAN.Select();
                }
                else
                {
                    txtIMEI2.Select();
                }
            }
        }

        private void txtIMEI2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConcluirEAN.Select();
            }
        }

        private void tpTriagem_Click(object sender, EventArgs e)
        {

        }

        private void txtNSEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtNSEntrada.Text.Length > 0)
                {
                    consulta.Coluna = "NS";
                    consulta.ValorDesejado = txtNSEntrada.Text;
                    consulta.ComData = "SIM"; // para não puxar os finalizados            
                    consulta.ConsultaTudo();
                    if (consulta.Retorno != "ok")
                    {
                        MessageBox.Show("CHAMADO NÃO ENCONTRADO.");
                    }
                    else
                    {
                        btnConcluirEntrada.Select();
                    }
                }
                else
                {
                    MessageBox.Show("INFORME O NS");
                }           
            }            
        }

        private void btnConcluirEntrada_Click(object sender, EventArgs e)
        {
            if (txtNSEntrada.Text.Length > 0)
            {
                if (consulta.NS == txtNSEntrada.Text)
                {
                    ImprimirEntrada();
                    consulta.LimparControles(this);
                    txtNSEntrada.Select();
                }
                else
                {
                    MessageBox.Show("CONFIRME O NS COM ENTER.");
                }
            }      
        }

        public void ImprimirEntrada()
        {
            string codZPL = "";
            string Cidade = RemoverAcentos(consulta.Cidade);
            string Data = "";
            try
            {
                DateTime dia = Convert.ToDateTime(consulta.DtEntrada);
                Data = dia.ToString("dd/MM/yyyy");
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }          
            imprimir.Entrada(txtNSEntrada.Text, consulta.Descricao, Cidade, Data);
            codZPL = imprimir.s;

            // SELECIONAR IMPRESSORA OU UTILIZAR A PADRÃO
            if (chbSelecionarImpressora.Checked)
            {
                // Allow the user to select a printer.
                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new PrinterSettings();
                if (DialogResult.OK == pd.ShowDialog(this))
                {
                    // Send a printer-specific to the printer.
                    RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, codZPL);
                }
            }
            else
            {
                string nomeImpressoraPadrao = (new PrinterSettings()).PrinterName;
                RawPrinterHelper.SendStringToPrinter(nomeImpressoraPadrao, codZPL);
            }
        }
         
             

   

       



    }
}
