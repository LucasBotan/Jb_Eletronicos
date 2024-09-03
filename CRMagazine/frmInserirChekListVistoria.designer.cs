namespace CRMagazine
{
    partial class frmInserirChekListVistoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirChekListVistoria));
            this.cboTipoEquip = new System.Windows.Forms.ComboBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAcao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtEquipamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAcao = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCriarItem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlItem.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoEquip
            // 
            this.cboTipoEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoEquip.FormattingEnabled = true;
            this.cboTipoEquip.Location = new System.Drawing.Point(11, 43);
            this.cboTipoEquip.Name = "cboTipoEquip";
            this.cboTipoEquip.Size = new System.Drawing.Size(227, 33);
            this.cboTipoEquip.TabIndex = 275;
            this.cboTipoEquip.SelectedValueChanged += new System.EventHandler(this.cboTipoEquip_SelectedValueChanged);
            this.cboTipoEquip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipoEquip_KeyPress);
            // 
            // cboEspecie
            // 
            this.cboEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Items.AddRange(new object[] {
            "ESTETICO",
            "FUNCIONAL"});
            this.cboEspecie.Location = new System.Drawing.Point(11, 111);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(227, 33);
            this.cboEspecie.TabIndex = 274;
            this.cboEspecie.SelectedValueChanged += new System.EventHandler(this.cboEspecie_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 434;
            this.label11.Text = "EQUIPAMENTO";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(7, 88);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(79, 20);
            this.lblEspecie.TabIndex = 435;
            this.lblEspecie.Text = "ESPÉCIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 437;
            this.label2.Text = "ITEM";
            // 
            // txtItem
            // 
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(406, 73);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(263, 26);
            this.txtItem.TabIndex = 438;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(317, 135);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(522, 297);
            this.dgvConsulta.TabIndex = 439;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = global::CRMagazine.Properties.Resources.B1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 93);
            this.pictureBox2.TabIndex = 440;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(269, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(364, 49);
            this.lblTitulo.TabIndex = 441;
            this.lblTitulo.Text = "CHECKLIST VISTORIA";
            // 
            // btnBusca
            // 
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Image = global::CRMagazine.Properties.Resources.lupa_24x24;
            this.btnBusca.Location = new System.Drawing.Point(236, 397);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(54, 35);
            this.btnBusca.TabIndex = 442;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // pnlItem
            // 
            this.pnlItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlItem.Controls.Add(this.btnConcluir);
            this.pnlItem.Controls.Add(this.label6);
            this.pnlItem.Controls.Add(this.txtID);
            this.pnlItem.Controls.Add(this.lblAcao);
            this.pnlItem.Controls.Add(this.label5);
            this.pnlItem.Controls.Add(this.label4);
            this.pnlItem.Controls.Add(this.label3);
            this.pnlItem.Controls.Add(this.txtEspecie);
            this.pnlItem.Controls.Add(this.txtEquipamento);
            this.pnlItem.Controls.Add(this.txtItem);
            this.pnlItem.Controls.Add(this.label2);
            this.pnlItem.Location = new System.Drawing.Point(43, 448);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(796, 111);
            this.pnlItem.TabIndex = 443;
            this.pnlItem.Visible = false;
            // 
            // btnConcluir
            // 
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Location = new System.Drawing.Point(684, 62);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(98, 37);
            this.btnConcluir.TabIndex = 447;
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(756, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 448;
            this.label6.Text = "ID";
            this.label6.Visible = false;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(630, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 31);
            this.txtID.TabIndex = 447;
            this.txtID.Visible = false;
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.Location = new System.Drawing.Point(328, 11);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(18, 25);
            this.lblAcao.TabIndex = 446;
            this.lblAcao.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 25);
            this.label5.TabIndex = 445;
            this.label5.Text = "INFORME O ITEM QUE DESEJA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 444;
            this.label4.Text = "ESPÉCIE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 443;
            this.label3.Text = "EQUIPAMENTO";
            // 
            // txtEspecie
            // 
            this.txtEspecie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(209, 73);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(180, 26);
            this.txtEspecie.TabIndex = 442;
            // 
            // txtEquipamento
            // 
            this.txtEquipamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipamento.Location = new System.Drawing.Point(12, 73);
            this.txtEquipamento.Name = "txtEquipamento";
            this.txtEquipamento.ReadOnly = true;
            this.txtEquipamento.Size = new System.Drawing.Size(180, 26);
            this.txtEquipamento.TabIndex = 440;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 445;
            this.label1.Text = "SELECIONE A AÇÃO DESEJADA:";
            // 
            // cboAcao
            // 
            this.cboAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAcao.FormattingEnabled = true;
            this.cboAcao.Items.AddRange(new object[] {
            "CONSULTAR",
            "INSERIR",
            "ALTERAR",
            "DELETAR"});
            this.cboAcao.Location = new System.Drawing.Point(43, 158);
            this.cboAcao.Name = "cboAcao";
            this.cboAcao.Size = new System.Drawing.Size(247, 33);
            this.cboAcao.TabIndex = 444;
            this.cboAcao.SelectedValueChanged += new System.EventHandler(this.cboAcao_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.btnCriarItem);
            this.panel2.Controls.Add(this.cboEspecie);
            this.panel2.Controls.Add(this.cboTipoEquip);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblEspecie);
            this.panel2.Location = new System.Drawing.Point(43, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 168);
            this.panel2.TabIndex = 444;
            // 
            // btnCriarItem
            // 
            this.btnCriarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarItem.Location = new System.Drawing.Point(165, 17);
            this.btnCriarItem.Name = "btnCriarItem";
            this.btnCriarItem.Size = new System.Drawing.Size(73, 20);
            this.btnCriarItem.TabIndex = 447;
            this.btnCriarItem.Text = "CRIAR ITEM";
            this.btnCriarItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCriarItem.UseVisualStyleBackColor = true;
            this.btnCriarItem.Click += new System.EventHandler(this.btnCriarItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::CRMagazine.Properties.Resources.lupa_24x24;
            this.pictureBox1.Location = new System.Drawing.Point(832, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.TabIndex = 446;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // frmInserirChekListVistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboAcao);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInserirChekListVistoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSERIR CHECKLIST VISTORIA";
            this.Load += new System.EventHandler(this.frmInserirChekListVistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlItem.ResumeLayout(false);
            this.pnlItem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoEquip;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtEquipamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAcao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnCriarItem;
    }
}