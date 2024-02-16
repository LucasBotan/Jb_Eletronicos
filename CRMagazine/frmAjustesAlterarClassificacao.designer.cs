namespace CRMagazine
{
    partial class frmAjustesAlterarClassificacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjustesAlterarClassificacao));
            this.label7 = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtClassificacaoAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxClassificacao = new System.Windows.Forms.ComboBox();
            this.btnLimparTela = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtMotivoAlteracaoClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtBIv = new System.Windows.Forms.RadioButton();
            this.rbt220 = new System.Windows.Forms.RadioButton();
            this.rbt110 = new System.Windows.Forms.RadioButton();
            this.chbConfigImpressora = new System.Windows.Forms.CheckBox();
            this.chbNaoImprimir = new System.Windows.Forms.CheckBox();
            this.chbSelecionarImpressora = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtVarejista = new System.Windows.Forms.TextBox();
            this.btnBuscarChamado = new System.Windows.Forms.Button();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodVarejo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(266, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(538, 61);
            this.label7.TabIndex = 77;
            this.label7.Text = "ALTERAR CLASSIFICAÇÃO";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(55, 182);
            this.lblOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(48, 29);
            this.lblOS.TabIndex = 80;
            this.lblOS.Text = "OS";
            // 
            // txtOS
            // 
            this.txtOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.Location = new System.Drawing.Point(60, 212);
            this.txtOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(314, 30);
            this.txtOS.TabIndex = 79;
            this.txtOS.TextChanged += new System.EventHandler(this.txtOS_TextChanged);
            this.txtOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOS_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "DESCRIÇÃO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "SKU";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(220, 279);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(513, 28);
            this.txtDescricao.TabIndex = 82;
            // 
            // txtSKU
            // 
            this.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSKU.Enabled = false;
            this.txtSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.Location = new System.Drawing.Point(60, 279);
            this.txtSKU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.ReadOnly = true;
            this.txtSKU.Size = new System.Drawing.Size(151, 28);
            this.txtSKU.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(741, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 86;
            this.label9.Text = "STATUS";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(741, 279);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(198, 28);
            this.txtStatus.TabIndex = 85;
            // 
            // txtClassificacaoAtual
            // 
            this.txtClassificacaoAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassificacaoAtual.Enabled = false;
            this.txtClassificacaoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacaoAtual.Location = new System.Drawing.Point(237, 399);
            this.txtClassificacaoAtual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClassificacaoAtual.Name = "txtClassificacaoAtual";
            this.txtClassificacaoAtual.ReadOnly = true;
            this.txtClassificacaoAtual.Size = new System.Drawing.Size(245, 34);
            this.txtClassificacaoAtual.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 88;
            this.label2.Text = "CLASSI ATUAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 29);
            this.label3.TabIndex = 89;
            this.label3.Text = "ALTERAR PARA:";
            // 
            // cbxClassificacao
            // 
            this.cbxClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClassificacao.FormattingEnabled = true;
            this.cbxClassificacao.Items.AddRange(new object[] {
            "SALDO",
            "NOVO"});
            this.cbxClassificacao.Location = new System.Drawing.Point(237, 454);
            this.cbxClassificacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxClassificacao.Name = "cbxClassificacao";
            this.cbxClassificacao.Size = new System.Drawing.Size(244, 37);
            this.cbxClassificacao.TabIndex = 90;
            this.cbxClassificacao.SelectedIndexChanged += new System.EventHandler(this.cbxClassificacao_SelectedIndexChanged);
            this.cbxClassificacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxClassificacao_KeyPress);
            // 
            // btnLimparTela
            // 
            this.btnLimparTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparTela.Location = new System.Drawing.Point(60, 526);
            this.btnLimparTela.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparTela.Name = "btnLimparTela";
            this.btnLimparTela.Size = new System.Drawing.Size(121, 30);
            this.btnLimparTela.TabIndex = 183;
            this.btnLimparTela.Text = "LIMPAR TELA";
            this.btnLimparTela.UseVisualStyleBackColor = true;
            this.btnLimparTela.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(818, 526);
            this.btnConcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(121, 59);
            this.btnConcluir.TabIndex = 182;
            this.btnConcluir.Text = "CONCLUIR";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(284, 9);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(20, 29);
            this.lblUsuario.TabIndex = 184;
            this.lblUsuario.Text = ".";
            // 
            // txtMotivoAlteracaoClass
            // 
            this.txtMotivoAlteracaoClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivoAlteracaoClass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivoAlteracaoClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoAlteracaoClass.Location = new System.Drawing.Point(219, 526);
            this.txtMotivoAlteracaoClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotivoAlteracaoClass.MaxLength = 200;
            this.txtMotivoAlteracaoClass.Multiline = true;
            this.txtMotivoAlteracaoClass.Name = "txtMotivoAlteracaoClass";
            this.txtMotivoAlteracaoClass.Size = new System.Drawing.Size(427, 94);
            this.txtMotivoAlteracaoClass.TabIndex = 91;
            this.txtMotivoAlteracaoClass.Visible = false;
            this.txtMotivoAlteracaoClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotivoAlteracaoClass_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 186;
            this.label4.Text = "MOTIVO ALTERAÇÃO";
            this.label4.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.rbtBIv);
            this.panel2.Controls.Add(this.rbt220);
            this.panel2.Controls.Add(this.rbt110);
            this.panel2.Controls.Add(this.chbConfigImpressora);
            this.panel2.Controls.Add(this.chbNaoImprimir);
            this.panel2.Controls.Add(this.chbSelecionarImpressora);
            this.panel2.Location = new System.Drawing.Point(562, 399);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 92);
            this.panel2.TabIndex = 479;
            // 
            // rbtBIv
            // 
            this.rbtBIv.AutoSize = true;
            this.rbtBIv.Location = new System.Drawing.Point(4, 63);
            this.rbtBIv.Margin = new System.Windows.Forms.Padding(4);
            this.rbtBIv.Name = "rbtBIv";
            this.rbtBIv.Size = new System.Drawing.Size(50, 21);
            this.rbtBIv.TabIndex = 504;
            this.rbtBIv.TabStop = true;
            this.rbtBIv.Text = "BIV";
            this.rbtBIv.UseVisualStyleBackColor = true;
            // 
            // rbt220
            // 
            this.rbt220.AutoSize = true;
            this.rbt220.Location = new System.Drawing.Point(4, 37);
            this.rbt220.Margin = new System.Windows.Forms.Padding(4);
            this.rbt220.Name = "rbt220";
            this.rbt220.Size = new System.Drawing.Size(62, 21);
            this.rbt220.TabIndex = 503;
            this.rbt220.TabStop = true;
            this.rbt220.Text = "220V";
            this.rbt220.UseVisualStyleBackColor = true;
            this.rbt220.CheckedChanged += new System.EventHandler(this.rbt220_CheckedChanged);
            // 
            // rbt110
            // 
            this.rbt110.AutoSize = true;
            this.rbt110.Location = new System.Drawing.Point(4, 10);
            this.rbt110.Margin = new System.Windows.Forms.Padding(4);
            this.rbt110.Name = "rbt110";
            this.rbt110.Size = new System.Drawing.Size(62, 21);
            this.rbt110.TabIndex = 502;
            this.rbt110.TabStop = true;
            this.rbt110.Text = "110V";
            this.rbt110.UseVisualStyleBackColor = true;
            // 
            // chbConfigImpressora
            // 
            this.chbConfigImpressora.AutoSize = true;
            this.chbConfigImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbConfigImpressora.Location = new System.Drawing.Point(128, 65);
            this.chbConfigImpressora.Margin = new System.Windows.Forms.Padding(4);
            this.chbConfigImpressora.Name = "chbConfigImpressora";
            this.chbConfigImpressora.Size = new System.Drawing.Size(212, 19);
            this.chbConfigImpressora.TabIndex = 489;
            this.chbConfigImpressora.Text = "USAR CONFIG DA IMPRESSORA";
            this.chbConfigImpressora.UseVisualStyleBackColor = true;
            // 
            // chbNaoImprimir
            // 
            this.chbNaoImprimir.AutoSize = true;
            this.chbNaoImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNaoImprimir.Location = new System.Drawing.Point(128, 37);
            this.chbNaoImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.chbNaoImprimir.Name = "chbNaoImprimir";
            this.chbNaoImprimir.Size = new System.Drawing.Size(114, 19);
            this.chbNaoImprimir.TabIndex = 487;
            this.chbNaoImprimir.Text = "NÃO IMPRIMIR";
            this.chbNaoImprimir.UseVisualStyleBackColor = true;
            this.chbNaoImprimir.CheckedChanged += new System.EventHandler(this.chbNaoImprimir_CheckedChanged);
            // 
            // chbSelecionarImpressora
            // 
            this.chbSelecionarImpressora.AutoSize = true;
            this.chbSelecionarImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSelecionarImpressora.Location = new System.Drawing.Point(128, 10);
            this.chbSelecionarImpressora.Margin = new System.Windows.Forms.Padding(4);
            this.chbSelecionarImpressora.Name = "chbSelecionarImpressora";
            this.chbSelecionarImpressora.Size = new System.Drawing.Size(188, 19);
            this.chbSelecionarImpressora.TabIndex = 475;
            this.chbSelecionarImpressora.Text = "SELECIONAR IMPRESSORA";
            this.chbSelecionarImpressora.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRMagazine.Properties.Resources.B1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 134);
            this.pictureBox1.TabIndex = 480;
            this.pictureBox1.TabStop = false;
            // 
            // txtVarejista
            // 
            this.txtVarejista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVarejista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVarejista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarejista.Location = new System.Drawing.Point(740, 13);
            this.txtVarejista.Margin = new System.Windows.Forms.Padding(4);
            this.txtVarejista.Name = "txtVarejista";
            this.txtVarejista.ReadOnly = true;
            this.txtVarejista.Size = new System.Drawing.Size(199, 30);
            this.txtVarejista.TabIndex = 481;
            // 
            // btnBuscarChamado
            // 
            this.btnBuscarChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarChamado.Image = global::CRMagazine.Properties.Resources.lupa_24x24;
            this.btnBuscarChamado.Location = new System.Drawing.Point(370, 212);
            this.btnBuscarChamado.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarChamado.Name = "btnBuscarChamado";
            this.btnBuscarChamado.Size = new System.Drawing.Size(51, 30);
            this.btnBuscarChamado.TabIndex = 482;
            this.btnBuscarChamado.UseVisualStyleBackColor = true;
            this.btnBuscarChamado.Click += new System.EventHandler(this.btnBuscarChamado_Click);
            // 
            // txtNS
            // 
            this.txtNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNS.Location = new System.Drawing.Point(478, 337);
            this.txtNS.Margin = new System.Windows.Forms.Padding(4);
            this.txtNS.Name = "txtNS";
            this.txtNS.ReadOnly = true;
            this.txtNS.Size = new System.Drawing.Size(255, 29);
            this.txtNS.TabIndex = 489;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 490;
            this.label5.Text = "NS";
            // 
            // txtEAN
            // 
            this.txtEAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEAN.Location = new System.Drawing.Point(220, 337);
            this.txtEAN.Margin = new System.Windows.Forms.Padding(4);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.ReadOnly = true;
            this.txtEAN.Size = new System.Drawing.Size(246, 29);
            this.txtEAN.TabIndex = 487;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(216, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 488;
            this.label8.Text = "EAN";
            // 
            // txtCodVarejo
            // 
            this.txtCodVarejo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodVarejo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodVarejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVarejo.Location = new System.Drawing.Point(63, 337);
            this.txtCodVarejo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodVarejo.Name = "txtCodVarejo";
            this.txtCodVarejo.ReadOnly = true;
            this.txtCodVarejo.Size = new System.Drawing.Size(148, 29);
            this.txtCodVarejo.TabIndex = 485;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 321);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 486;
            this.label10.Text = "COD VAREJO";
            // 
            // frmAjustesAlterarClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 611);
            this.Controls.Add(this.txtNS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEAN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodVarejo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscarChamado);
            this.Controls.Add(this.txtVarejista);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMotivoAlteracaoClass);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnLimparTela);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.cbxClassificacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClassificacaoAtual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAjustesAlterarClassificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTERAR CLASSIFICAÇÃO";
            this.Load += new System.EventHandler(this.frmAjustesAlterarClassificacao_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtClassificacaoAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxClassificacao;
        private System.Windows.Forms.Button btnLimparTela;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtMotivoAlteracaoClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtBIv;
        private System.Windows.Forms.RadioButton rbt220;
        private System.Windows.Forms.RadioButton rbt110;
        private System.Windows.Forms.CheckBox chbConfigImpressora;
        private System.Windows.Forms.CheckBox chbNaoImprimir;
        private System.Windows.Forms.CheckBox chbSelecionarImpressora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtVarejista;
        private System.Windows.Forms.Button btnBuscarChamado;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodVarejo;
        private System.Windows.Forms.Label label10;
    }
}