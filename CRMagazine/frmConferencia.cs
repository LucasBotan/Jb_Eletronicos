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

namespace CRMagazine
{
    public partial class frmConferencia : Form
    {
        public frmConferencia()
        {
            InitializeComponent();
        }

        Consulta consulta = new Consulta();
        Conexao cx = new Conexao();

        public string inicio = "";
        private void frmConferencia_Load(object sender, EventArgs e)
        {
            PreencherCboVarejista();
            inicio = "ok";
        }

        public void PreencherCboVarejista()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string sql = "";
            sql = "";
            sql += " Select DISTINCT Varejista from NotaFiscal where Conferir != 0";
            cx.Conectar();
            da = new SqlDataAdapter(sql, cx.c);
            da.Fill(ds, "NotaFiscal");
            cboVarejista.ValueMember = "idNotaFiscal";
            cboVarejista.DisplayMember = "Varejista";
            cboVarejista.DataSource = ds.Tables["NotaFiscal"];
            cx.Desconectar();
            cboVarejista.Text = null;
            cboVarejista.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboVarejista.AutoCompleteSource = AutoCompleteSource.ListItems;
            // cboNotaFiscal.Text = "";
            // lblRestanteNF.Text = "0";
        }

        public void PreencherCboNotaFiscal()
        {
            if(chbComDT.Checked && Data == "")
            {
                MessageBox.Show("PREENCHA A DATA DA NOTA FISCAL.");
                cboNotaFiscal.DataSource = null;
            }
            else
            {
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "";
                sql = "";
                sql += " Select DISTINCT NotaFiscal from NotaFiscal where Conferir != 0 and Varejista = '" + cboVarejista.Text + "'";
                if (chbComDT.Checked && Data != "")
                {
                    sql += " and Data = '" + Data + "'";
                }
                cx.Conectar();
                da = new SqlDataAdapter(sql, cx.c);
                da.Fill(ds, "NotaFiscal");
                cboNotaFiscal.ValueMember = "idNotaFiscal";
                cboNotaFiscal.DisplayMember = "NotaFiscal";
                cboNotaFiscal.DataSource = ds.Tables["NotaFiscal"];
                cx.Desconectar();
                cboNotaFiscal.Text = null;
                cboNotaFiscal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboNotaFiscal.AutoCompleteSource = AutoCompleteSource.ListItems;
                // cboNotaFiscal.Text = "";
                lblPendenteNF.Text = "PENDENTES: 0";
            }           
        }

        private void txtCodVarejo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnBusca.PerformClick();
            }
        }
        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtCodVarejo.Text.Length > 0)
            {
                consulta.ConsultaNotaFiscal(cboVarejista.Text, "CodVarejo", txtCodVarejo.Text, notas);
                if (consulta.Retorno == "ok")
                {
                    txtDescricao.Text = consulta.NF_Descricao;
                    txtCodigo.Text = consulta.NF_Codigo;
                    txtEanConsulta.Text = consulta.NF_EAN;
                    //btnConcluir.Select();
                    //AKI
                    consulta.comando = "";
                    consulta.comando = "";
                    consulta.comando = "SELECT count(NotaFiscal) as Quantidade FROM NotaFiscal where idNotaFiscal = (select top 1 idNotaFiscal from NotaFiscal where CodVarejo = '" + txtCodigo.Text + "' and Conferir > 0 and Varejista = '" + cboVarejista.Text + "')";
                    consulta.consultarSimNao();           
                    if (Convert.ToInt32(consulta.qntNaPosicao) > 0)
                    {
                        btnConcluir.Visible = true;
                        btnConcluir.Select();
                    }
                    else
                    {
                        consulta.PlayFail();
                        MessageBox.Show("QUANTIDADE JÁ ZERADA PARA ESSE CÓDIGO.");
                        txtCodVarejo.Select();
                        txtCodVarejo.SelectAll();
                        btnConcluir.Visible = false;

                    }
                }
                else
                {
                    consulta.PlayFail();
                    MessageBox.Show("NOTA FISCAL SEM QUANTIDADE PARA ESSE CÓDIGO VAREJO.");
                    txtCodVarejo.Select();
                    txtCodVarejo.SelectAll();
                    btnConcluir.Visible = false;
                }
            }
            else
            {
                consulta.PlayFail();
                MessageBox.Show("PREENCHA O CÓDIGO.");
                txtCodVarejo.Select();
                txtCodVarejo.SelectAll();
                btnConcluir.Visible = false;
            }
        }

        private void txtEAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnBuscaEAN.PerformClick();
            }
        }
        private void btnBuscaEAN_Click(object sender, EventArgs e)
        {
            if (txtEAN.Text.Length > 0)
            {
                consulta.ConsultaNotaFiscal(cboVarejista.Text, "EAN", txtEAN.Text, notas);
                if (consulta.Retorno == "ok")
                {
                    txtDescricao.Text = consulta.NF_Descricao;
                    txtCodigo.Text = consulta.NF_Codigo;
                    txtEanConsulta.Text = consulta.NF_EAN;
                    //btnConcluir.Select();
                    //AKI
                    consulta.comando = "";
                    consulta.comando = "";
                    consulta.comando = "SELECT count(NotaFiscal) as Quantidade FROM NotaFiscal where idNotaFiscal = (select top 1 idNotaFiscal from NotaFiscal where CodVarejo = '" + txtCodigo.Text + "' and Conferir > 0 and Varejista = '" + cboVarejista.Text + "')";
                    consulta.consultarSimNao();
                    if (Convert.ToInt32(consulta.qntNaPosicao) > 0)
                    {
                        btnConcluir.Visible = true;
                        btnConcluir.Select();
                    }
                    else
                    {
                        consulta.PlayFail();
                        MessageBox.Show("QUANTIDADE JÁ ZERADA PARA ESSE CÓDIGO.");
                        txtEAN.SelectAll();
                        txtEAN.Select();
                        btnConcluir.Visible = false;
                    }
                }
                else
                {
                    consulta.PlayFail();
                    MessageBox.Show("NOTA FISCAL SEM QUANTIDADE PARA ESSE CÓDIGO VAREJO.");
                    btnLimpar.PerformClick();
                    txtEAN.SelectAll();
                    txtEAN.Select();
                    btnConcluir.Visible = false;
                }
            }
            else
            {
                consulta.PlayFail();
                MessageBox.Show("PREENCHA A EAN.");
                txtEAN.Select();
                btnConcluir.Visible = false;
            }
        }

        private void cboVarejista_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboVarejista.Text.Length > 0 && inicio != "")
            {
                lstColunas.Items.Clear();
                ContarVarejista();
                PreencherCboNotaFiscal();
            }
        }

        private void chbComDT_CheckedChanged(object sender, EventArgs e)
        {
            if (chbComDT.Checked)
            {
                lstColunas.Items.Clear();
                ContarVarejista();
                PreencherCboNotaFiscal();
                mtbDataNF.Visible = true;
                Data = "";
                mtbDataNF.Select();
                lnkListarPorData.Visible = true;
            }
            else
            {
                lstColunas.Items.Clear();
                ContarVarejista();
                PreencherCboNotaFiscal();
                mtbDataNF.Visible = false;
                Data = "";
                mtbDataNF.Text = "";
                lnkListarPorData.Visible = false;
            }
        }


        public void ContarVarejista()
        {
            if (cboVarejista.Text.Length > 0)
            {
                //===============verificando restante ============
                string comando = "";
                comando += "SELECT sum(convert(numeric,Conferir)) as Quantidade from NotaFiscal where Varejista = '" + cboVarejista.Text + "' and Conferir > 0";
                if (chbComDT.Checked && Data != "")
                {
                    comando += " and Data = '" + Data + "'";
                }
                consulta.comando = comando;
                consulta.consultarSimNao();
                if(consulta.qntNaPosicao == "")
                {
                    consulta.qntNaPosicao = "0";
                }
                lblRestanteVarejista.Text = consulta.qntNaPosicao.ToString();

                //================================================                     
            }
        }

        private void cboNotaFiscal_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
            if (cboNotaFiscal.Text.Length > 0)
            {
                btnLimpar.PerformClick();
                //===============verificando restante ============
                string comando = "";
                comando += "SELECT sum(convert(numeric,Conferir)) as Quantidade from NotaFiscal where NotaFiscal = '" + cboNotaFiscal.Text + "' and Conferir > 0";
                consulta.comando = comando;
                consulta.consultarSimNao();
                lblPendenteNF.Text = consulta.qntNaPosicao.ToString();
                //================================================                     
            }
            */
        }

        private void cboNotaFiscal_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("ESCRITA NÃO PERMITIDA.");
            if (cboNotaFiscal.Text.Length > 0)
            {
                cboNotaFiscal.Text = "";
            }
        }

        private void lnkAtualizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inicio = "";
            PreencherCboVarejista();
            inicio = "ok";
            AtualizaContadores();
            limpar();
            btnLimparLista.PerformClick();
            chbComDT.Checked = false;

        }

        public void AtualizaContadores()
        {
            if (cboVarejista.Text.Length > 0)
            {
                consulta.comando = "SELECT sum(convert(numeric,Conferir)) as Quantidade from NotaFiscal where Conferir > 0 and Varejista = '" + cboVarejista.Text + "' ";
                consulta.consultarSimNao();
                if (consulta.qntNaPosicao == "")
                {
                    consulta.qntNaPosicao = "0";
                }
                lblRestanteVarejista.Text = consulta.qntNaPosicao.ToString();

                AtualizarListaNotas();
            }
            else
            {
                MessageBox.Show("SELECIONE UM VAREJISTA.");
                lblRestanteVarejista.Text = "0";
            }            
        }

        public void AtualizarListaNotas()
        {
            if (lstColunas.Items.Count > 0)
            {
                consulta.comando = "SELECT sum(convert(numeric,Conferir)) as Quantidade from NotaFiscal where NotaFiscal in (" + notas + ") and Conferir > 0";
                consulta.consultarSimNao();
                if(consulta.qntNaPosicao == "")
                {
                    consulta.qntNaPosicao = "0";
                }
                lblPendenteNF.Text = "PENDENTES: " + consulta.qntNaPosicao.ToString();
            }
            else
            {
                lblPendenteNF.Text = "PENDENTES: 0";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
            txtEAN.Text = "";
            txtCodVarejo.Text = "";
            txtDescricao.Text = "";
            txtCodigo.Text = "";
            txtEanConsulta.Text = "";
            btnConcluir.Visible = false;
        }

        private void btnListarNF_Click(object sender, EventArgs e)
        {
            if(cboVarejista.Text.Length > 0 && lstColunas.Items.Count > 0)
            {
                ListarTudo(false);
            }
            else
            {
                MessageBox.Show("INFORME O VAREJISTA E A NOTA FISCAL.");
            }
        }

        public void ListarTudo(bool ComData)
        {
            string sql = "";
            if(ComData == false)
            {
                sql += " Select NotaFiscal as NF, CodVarejo as Cod, QntProdutos as QNT, Conferir as Rest, Descricao as Descr From NotaFiscal where Varejista = '" + cboVarejista.Text + "' and NotaFiscal in (" + notas + ") ";
            }
            else
            {
                sql += " Select NotaFiscal as NF, CodVarejo as Cod, QntProdutos as QNT, Conferir as Rest, Descricao as Descr From NotaFiscal where Varejista = '" + cboVarejista.Text + "' and Data = '" + Data + "' "; 
            }
            
            cx.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx.c);
            DataSet ds = new DataSet();
            da.Fill(ds, "NotaFiscal");
            dgvConsulta.DataSource = ds.Tables["NotaFiscal"];
            cx.Desconectar();
            dgvConsulta.RowHeadersVisible = false;
            dgvConsulta.Columns["Descr"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            dgvConsulta.AutoResizeColumns();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Concluir();
        }
        public void Concluir()
        {
            // baixa a qnt da nota fiscal, se o flag estiver marcado
            consulta.comando = "";
            consulta.comando = "update NotaFiscal set Conferir = Conferir - 1 where idNotaFiscal = (select top 1 idNotaFiscal from NotaFiscal where CodVarejo = '" + txtCodigo.Text + "' and Conferir > 0 and Varejista = '" + cboVarejista.Text + "' and NotaFiscal in (" + notas + "))";
            consulta.Atualizar();
            consulta.PlayOK();
            AdcionarContador();
            lblUltimoColetado.Text = "ÚLTIMO: " + txtCodigo.Text + " - " + txtEanConsulta.Text + "\r\n" + txtDescricao.Text;
            btnLimpar.PerformClick();
            AtualizaContadores();
            ListarTudo(false);
            txtEAN.Select();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            if (lstColunas.Items.Contains(cboNotaFiscal.Text))
            {
                consulta.PlayFail();
                MessageBox.Show("ITEM JÁ CADASTRADO.");
            }
            else if (cboNotaFiscal.Text.Length == 0)
            {
                consulta.PlayFail();
                MessageBox.Show("SELECIONE O ITEM.");
            }
            else
            {
                lstColunas.Items.Add(cboNotaFiscal.Text);
                cboNotaFiscal.Text = null;
                cboNotaFiscal.Select();
                recebeColunas();
            }
        }

        public string notas = "";
        public void recebeColunas()
        {
            notas = "";
            int rows = lstColunas.Items.Count;            
            foreach (string item in lstColunas.Items)
            {
                if (rows > 1)
                {
                    notas += "'" + item + "', ";
                }
                else
                {
                    notas += "'" + item + "' ";
                }
                rows--;
            }
            AtualizarListaNotas();
            ContarListados();
            limpar();
        }

        public void ContarListados()
        {
            int Listados = lstColunas.Items.Count;
            lblListados.Text = "NOTAS: " + Listados.ToString();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            lstColunas.Items.Remove(lstColunas.SelectedItem);
            recebeColunas();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            lstColunas.Items.Clear();
            for (int i = 0; i < cboNotaFiscal.Items.Count; i++)
            {
                string value = cboNotaFiscal.GetItemText(cboNotaFiscal.Items[i]);
                lstColunas.Items.Add(value);
            }
            recebeColunas();
        }              

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            lstColunas.Items.Clear();
            lblListados.Text = "NOTAS: 0";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

        public string Data = "";
        private void mtbDataNF_TextChanged(object sender, EventArgs e)
        {
            Data = "";
            if (mtbDataNF.Text.Length > 7)
            {
                Data = "";
                string check = "";
                string Vdata = "";
                ValidaData(mtbDataNF.Text, out check, out Vdata);
                if (check == "OK")
                {
                    Data = Vdata;

                    lstColunas.Items.Clear();
                    ContarVarejista();
                    PreencherCboNotaFiscal();
                    cboNotaFiscal.Select();
                }
                else
                {
                    mtbDataNF.SelectAll();
                }
            }
        }

        private void mtbDataNF_Leave(object sender, EventArgs e)
        {
            if (mtbDataNF.Text.Length == 0)
            {
                Data = "";                
            }
            else if (mtbDataNF.Text.Length < 8)
            {
                consulta.PlayFail();
                MessageBox.Show("DATA INVÁLIDA");
                mtbDataNF.Focus();
            }
            else
            {
                string check = "";
                string Vdata = "";
                ValidaData(mtbDataNF.Text, out check, out Vdata);
                if (check == "OK")
                {
                    Data = Vdata;

                    lstColunas.Items.Clear();
                    ContarVarejista();
                    PreencherCboNotaFiscal();
                    cboNotaFiscal.Select();
                }
            }
        }

        public void ValidaData(string data, out string check, out string Vdata)
        {
            check = "";
            string Data = "";
            Vdata = data.Substring(0, 2) + "/" + data.Substring(2, 2) + "/" + data.Substring(4, 4);
            //MessageBox.Show(Vdata);
            try
            {
                DateTime teste = Convert.ToDateTime(Vdata);
                if (teste > DateTime.Now)
                {
                    consulta.PlayFail();
                    MessageBox.Show("DATA MAIOR QUE HOJE");
                    // mtbDataCompra.SelectAll();
                }
                else
                {
                    Data = Vdata;
                    // mtbDataCompra.Select();
                    check = "OK";
                }
            }
            catch (Exception)
            {
                consulta.PlayFail();
                MessageBox.Show("DIGITE UMA DATA VÁLIDA");
                // mtbDataCompra.SelectAll();
            }
        }

        private void btnListarNF_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnListarNF, "CONSULTAR NFs DA LISTA.");
        }

        private void lnkListarPorData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("DESEJA LISTAR AS NFs DO VAREJISTA NA DATA INFORMADA\r\n\r\nESSA CONSULTA RETORNA ATÉ OS ITENS JÁ CONFERIDOS? ", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cboVarejista.Text.Length > 0 || Data == "")
                {
                    ListarTudo(true);
                }
                else
                {
                    MessageBox.Show("INFORME O VAREJISTA E A DATA.");
                }
            }
        }

        public void AdcionarContador()
        {
            if (txtContagem.Lines.Length == 0)
            {
                txtContagem.Text = txtCodigo.Text;
            }
            else
            {
                txtContagem.Text = txtContagem.Text + "\r\n" + txtCodigo.Text;
            }
        }

        private void btnLimpaContador_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA LIMPAR OS CÓDIGO JÁ COLETADOS? ", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtContagem.Text = "";
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContagem_TextChanged(object sender, EventArgs e)
        {
            lblContagem.Text = txtContagem.Lines.Length.ToString();
        }
    }
}
