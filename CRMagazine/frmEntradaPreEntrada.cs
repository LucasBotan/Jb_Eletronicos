using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace CRMagazine
{
    public partial class frmEntradaPreEntrada : Form
    {
        public frmEntradaPreEntrada()
        {
            InitializeComponent();
        }

        Consulta consulta = new Consulta();
        Conexao cx = new Conexao();

        private void frmEntradaPreEntrada_Load(object sender, EventArgs e)
        {

        }

        public string RG = "";
        public string CodVarejo = "";
        public string Nota = "";
        public string Erro = "";
        public int LinhaAtual = 0;

        public void ZeraVariaveis()
        {
            RG = "";
            CodVarejo = "";
            Nota = "";
            Erro = "";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            txtErro.Text = "";
            lblStatus.Text = "";
            btnGravar.Enabled = false;
            OpenFileDialog vAbreArq = new OpenFileDialog();
            vAbreArq.Filter = "Microsoft Excel |*.xls; *.xlsx";
            vAbreArq.Title = "Selecione o Arquivo";
            if (vAbreArq.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("igual =" + vAbreArq.FileName);
                string pasta = vAbreArq.FileName;
                txtEndereco.Text = pasta;
            }
        }

        private void btnLerPlanilha_Click(object sender, EventArgs e)
        {
            txtErro.Text = "";
            lblStatus.Text = "";
            btnGravar.Enabled = false;
            importdatafromexcel(txtEndereco.Text);
        }

        public void importdatafromexcel(string pasta)
        {
            string myexceldataquery = "select RG, CodVarejo, Nota from [Plan1$]";
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //create our connection strings
                string sexcelconnectionstring = @"provider=microsoft.jet.oledb.4.0;data source=" + pasta + ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                // string ssqlconnectionstring = "Server=011EIND2899\\SQLEXPRESS;Database=Vistoria;UID=sa;PWD=123";
                string ssqlconnectionstring = "Data Source=10.83.200.23,49172;Initial Catalog=Positivo;User ID=sa;Password=Maiden!@#";
                //execute a query to erase any previous data from our destination table
                //series of commands to bulk copy data from the excel file into our sql table
                OleDbConnection oledbconn = new OleDbConnection(sexcelconnectionstring);
                OleDbCommand oledbcmd = new OleDbCommand(myexceldataquery, oledbconn);

                oledbconn.Open();
                OleDbDataReader dr = oledbcmd.ExecuteReader();
                SqlBulkCopy bulkcopy = new SqlBulkCopy(ssqlconnectionstring);


                //   bulkcopy.DestinationTableName = ssqltable;

                int Cont = 1;
                while (dr.Read())
                {
                    Cont = Cont + 1;
                    lblStatus.Text = "Executando Linha: " + Cont;

                    RG = dr["RG"].ToString();
                    CodVarejo = dr["CodVarejo"].ToString();
                    Nota = dr["Nota"].ToString();

                    LinhaAtual = Cont;
                    Validacao(RG, CodVarejo, Nota);
                }



                lblStatus.Text = "Leitura da tablela finalizada";
                if (txtErro.Text.Length == 0)
                {
                    MessageBox.Show("INFORMAÇÕES VALIDADAS\r\nCLICAR EM GRAVAR PARA SUBIR OS DADOS NO BANCO!");
                    btnGravar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("CORRIGIR OS ERROS ANTES DE SUBIR OS DADOS NO BANCO!");
                }
                oledbconn.Close();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                //handle exception
                MessageBox.Show(" = " + ex);
                this.Cursor = Cursors.Default;
            }
        }

        public void InserirNoBancoFromExcel()
        {
            string myexceldataquery = "select RG, CodVarejo, Nota from [Plan1$]";
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //create our connection strings
                string sexcelconnectionstring = @"provider=microsoft.jet.oledb.4.0;data source=" + txtEndereco.Text + ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                // string ssqlconnectionstring = "Server=011EIND2899\\SQLEXPRESS;Database=Vistoria;UID=sa;PWD=123";
                string ssqlconnectionstring = "Data Source=10.83.200.23,49172;Initial Catalog=Positivo;User ID=sa;Password=Maiden!@#";
                //execute a query to erase any previous data from our destination table

                //series of commands to bulk copy data from the excel file into our sql table
                OleDbConnection oledbconn = new OleDbConnection(sexcelconnectionstring);
                OleDbCommand oledbcmd = new OleDbCommand(myexceldataquery, oledbconn);
                oledbconn.Open();
                OleDbDataReader dr = oledbcmd.ExecuteReader();
                SqlBulkCopy bulkcopy = new SqlBulkCopy(ssqlconnectionstring);
                //   bulkcopy.DestinationTableName = ssqltable;

                int Cont = 1;
                while (dr.Read())
                {
                    Cont = Cont + 1;
                    lblStatus.Text = "Executando Linha: " + Cont;

                    RG = dr["RG"].ToString();
                    CodVarejo = dr["CodVarejo"].ToString();
                    Nota = dr["Nota"].ToString();

                    LinhaAtual = Cont;
                    Validacao(RG, CodVarejo, Nota);

                    if (Erro == "")
                    {
                        Concluir(RG, CodVarejo, Nota);
                        // GravarNoExcel();
                    }
                    else
                    {

                    }
                    ZeraVariaveis();
                }
                lblStatus.Text = "Leitura da tablela finalizada";
                if (txtErro.Text.Length == 0)
                {

                }
                else
                {
                    MessageBox.Show("OCORREU UM ERRO AO SUBIR OS DADOS NO BANCO!");
                }
                oledbconn.Close();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                //handle exception
                MessageBox.Show(" = " + ex);
                this.Cursor = Cursors.Default;
            }
            btnGravar.Enabled = false;
        }


        public void Validacao(string RG, string CodVarejo, string Nota)
        {
            // VERIFICA SE JÁ O RG JÁ ESTA NO POSTO
            consulta.comando = "Select count(*) as Quantidade from Chamados where OS = '" + RG + "'";
            consulta.consultarSimNao();
            if (consulta.qntNaPosicao == "") { consulta.qntNaPosicao = "0"; }
            if (Convert.ToInt32(consulta.qntNaPosicao) > 0) // se já esta no posto da erro
            {
                Erro = "ERRO LINHA " + LinhaAtual + ": RG " + RG + " JÁ ESTA NO POSTO.\r\n";
                txtErro.Text += Erro;
            }

            //VERIFICA SE JÁ TEM A NF PARA O VAREJISTA MULTIVAREJO.
            consulta.comando = "Select count(*) as Quantidade from NotaFiscal where Varejista = 'MULTIVAREJO' AND NOTAFISCAL = '" + Nota + "' ";
            consulta.consultarSimNao();
            if (consulta.qntNaPosicao == "") {consulta.qntNaPosicao = "0";}
            if (Convert.ToInt32(consulta.qntNaPosicao) <= 0) // se a nota não foi cadastrada da erro
            {
                Erro = "ERRO LINHA " + LinhaAtual + ": NOTA " + Nota + " NÃO CADASTRADA.\r\n";
                txtErro.Text += Erro;
            }

            //VERIFICA SE JÁ TEM O RG NO BANCO PREENTRADA.
            consulta.comando = "Select count(*) as Quantidade from PreEntrada where RG = '" + RG + "' ";//AND NOTAFISCAL = '" + Nota + "' ";
            consulta.consultarSimNao();
            if (consulta.qntNaPosicao == "") { consulta.qntNaPosicao = "0"; }
            if (Convert.ToInt32(consulta.qntNaPosicao) > 0) // SE O RG JA FOI PRE CADASTRADO DA ERRO
            {
                Erro = "ERRO LINHA " + LinhaAtual + ": RG " + RG + " JÁ ESTA NA PRE-ENTRADA.\r\n";
                txtErro.Text += Erro;
            }

            /* // ANTIGO
           consulta.Coluna = "OS";
           consulta.ValorDesejado = RG;
           consulta.ConsultaTudo();
           if (consulta.Retorno != "ok")
           {

           }
           else
           {
               Erro = "ERRO LINHA " + LinhaAtual + ": RG " + RG + " JÁ ESTA NO POSTO.\r\n";
               txtErro.Text += Erro;
           }
            */
        }

        public void Concluir(string RG, string CodVarejo, string Nota)
        {
            consulta.DataAtual();
            string Retorno = "";
            string sql = "";
            try
            {
                sql += "insert into PreEntrada (RG, CodVarejo, Nota, Data) values ";
                sql += "('" + RG + "', '" + CodVarejo + "', '" + Nota + "', '" + consulta.dataNormal + "' )";
                cx.Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cx.c;
                cd.CommandText = sql;
                cd.ExecuteNonQuery();
                Retorno = "ok";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERRO AO INSERIR EM PREENTRADA: \n" + x.Message);
                Retorno = "falha";
            }
            cx.Desconectar();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            InserirNoBancoFromExcel();
        }




    }
}
