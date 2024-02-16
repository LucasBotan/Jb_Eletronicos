using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMagazine
{
    public partial class frmSenha : Form
    {
        public frmSenha(string tipo)
        {
            InitializeComponent();
            txtTexto.Focus();
            Tipo = tipo;
        }

        Consulta consulta = new Consulta();

        public string Tipo = "";

        private void frmRecebeTexto_Load(object sender, EventArgs e)
        {
            if (Tipo.Length > 0)
            {
                txtTexto.Visible = false;
                pnlVolts.Visible = true;
            }
        }

        public string TextoTeste { get; set; }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //Atribuir valor na propriedade
                TextoTeste = txtTexto.Text.ToString();
                //Fechar este Form
                this.Close();
        
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtVolts.Text + " V  ---  " + txtAmper.Text + " A\r\n\r\nDESEJA CADASTRAR?", "PERGUNTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                consulta.comando = "";
                consulta.comando = "update CodVarDescricao set voltagem ='" + txtVolts.Text + "', amperagem = '" + txtAmper.Text + "' where CodPositivo = '" + Tipo + "'";
                consulta.Atualizar();
                this.Close();
            }           
        }

        private void txtVolts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAmper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
