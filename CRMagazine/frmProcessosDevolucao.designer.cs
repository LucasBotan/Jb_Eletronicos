namespace CRMagazine
{
    partial class frmProcessosDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcessosDevolucao));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtMotivoDevolucao = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtVarejista = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarChamado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtDevolucao = new System.Windows.Forms.RadioButton();
            this.rbtSucata = new System.Windows.Forms.RadioButton();
            this.rbtDivergencia = new System.Windows.Forms.RadioButton();
            this.rbtReprovado = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbNaoImprimir = new System.Windows.Forms.CheckBox();
            this.chbSelecionarImpressora = new System.Windows.Forms.CheckBox();
            this.chbConfigImpressora = new System.Windows.Forms.CheckBox();
            this.rbtBIv = new System.Windows.Forms.RadioButton();
            this.rbt220 = new System.Windows.Forms.RadioButton();
            this.rbt110 = new System.Windows.Forms.RadioButton();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodVarejo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(520, 355);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 28);
            this.btnLimpar.TabIndex = 457;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtMotivoDevolucao
            // 
            this.txtMotivoDevolucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivoDevolucao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivoDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoDevolucao.Location = new System.Drawing.Point(78, 321);
            this.txtMotivoDevolucao.MaxLength = 200;
            this.txtMotivoDevolucao.Multiline = true;
            this.txtMotivoDevolucao.Name = "txtMotivoDevolucao";
            this.txtMotivoDevolucao.Size = new System.Drawing.Size(436, 90);
            this.txtMotivoDevolucao.TabIndex = 455;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(242, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 59);
            this.lblTitulo.TabIndex = 454;
            this.lblTitulo.Text = "DEVOLUÇÃO";
            // 
            // btnConcluir
            // 
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Location = new System.Drawing.Point(520, 321);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(107, 28);
            this.btnConcluir.TabIndex = 453;
            this.btnConcluir.Text = "CONCLUIR";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 452;
            this.label4.Text = "MOTIVO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 451;
            this.label1.Text = "STATUS";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(367, 163);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(260, 26);
            this.txtStatus.TabIndex = 450;
            // 
            // txtVarejista
            // 
            this.txtVarejista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVarejista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVarejista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarejista.Location = new System.Drawing.Point(503, 12);
            this.txtVarejista.Name = "txtVarejista";
            this.txtVarejista.ReadOnly = true;
            this.txtVarejista.Size = new System.Drawing.Size(229, 26);
            this.txtVarejista.TabIndex = 448;
            // 
            // txtOS
            // 
            this.txtOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.Location = new System.Drawing.Point(78, 163);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(247, 26);
            this.txtOS.TabIndex = 446;
            this.txtOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChamado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 445;
            this.label2.Text = "OS";
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(78, 217);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(549, 26);
            this.txtModelo.TabIndex = 444;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 443;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(235, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(16, 24);
            this.lblUsuario.TabIndex = 442;
            this.lblUsuario.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 12);
            this.label6.TabIndex = 458;
            this.label6.Text = "MAX. 200 CARACTERES";
            // 
            // btnBuscarChamado
            // 
            this.btnBuscarChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarChamado.Image = global::CRMagazine.Properties.Resources.lupa_24x24;
            this.btnBuscarChamado.Location = new System.Drawing.Point(323, 163);
            this.btnBuscarChamado.Name = "btnBuscarChamado";
            this.btnBuscarChamado.Size = new System.Drawing.Size(38, 26);
            this.btnBuscarChamado.TabIndex = 447;
            this.btnBuscarChamado.UseVisualStyleBackColor = true;
            this.btnBuscarChamado.Click += new System.EventHandler(this.btnBuscarChamado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRMagazine.Properties.Resources.B1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 94);
            this.pictureBox1.TabIndex = 441;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rbtDevolucao
            // 
            this.rbtDevolucao.AutoSize = true;
            this.rbtDevolucao.Location = new System.Drawing.Point(600, 62);
            this.rbtDevolucao.Name = "rbtDevolucao";
            this.rbtDevolucao.Size = new System.Drawing.Size(91, 17);
            this.rbtDevolucao.TabIndex = 459;
            this.rbtDevolucao.TabStop = true;
            this.rbtDevolucao.Text = "DEVOLUÇÃO";
            this.rbtDevolucao.UseVisualStyleBackColor = true;
            this.rbtDevolucao.CheckedChanged += new System.EventHandler(this.rbtDevolucao_CheckedChanged);
            // 
            // rbtSucata
            // 
            this.rbtSucata.AutoSize = true;
            this.rbtSucata.Location = new System.Drawing.Point(600, 85);
            this.rbtSucata.Name = "rbtSucata";
            this.rbtSucata.Size = new System.Drawing.Size(68, 17);
            this.rbtSucata.TabIndex = 460;
            this.rbtSucata.TabStop = true;
            this.rbtSucata.Text = "SUCATA";
            this.rbtSucata.UseVisualStyleBackColor = true;
            this.rbtSucata.CheckedChanged += new System.EventHandler(this.rbtSucata_CheckedChanged);
            // 
            // rbtDivergencia
            // 
            this.rbtDivergencia.AutoSize = true;
            this.rbtDivergencia.Location = new System.Drawing.Point(600, 131);
            this.rbtDivergencia.Name = "rbtDivergencia";
            this.rbtDivergencia.Size = new System.Drawing.Size(98, 17);
            this.rbtDivergencia.TabIndex = 462;
            this.rbtDivergencia.TabStop = true;
            this.rbtDivergencia.Text = "DIVERGENCIA";
            this.rbtDivergencia.UseVisualStyleBackColor = true;
            this.rbtDivergencia.CheckedChanged += new System.EventHandler(this.rbtDivergencia_CheckedChanged);
            // 
            // rbtReprovado
            // 
            this.rbtReprovado.AutoSize = true;
            this.rbtReprovado.Location = new System.Drawing.Point(600, 108);
            this.rbtReprovado.Name = "rbtReprovado";
            this.rbtReprovado.Size = new System.Drawing.Size(93, 17);
            this.rbtReprovado.TabIndex = 461;
            this.rbtReprovado.TabStop = true;
            this.rbtReprovado.Text = "REPROVADO";
            this.rbtReprovado.UseVisualStyleBackColor = true;
            this.rbtReprovado.CheckedChanged += new System.EventHandler(this.rbtReprovado_CheckedChanged);
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
            this.panel2.Location = new System.Drawing.Point(78, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 66);
            this.panel2.TabIndex = 478;
            // 
            // chbNaoImprimir
            // 
            this.chbNaoImprimir.AutoSize = true;
            this.chbNaoImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNaoImprimir.Location = new System.Drawing.Point(96, 28);
            this.chbNaoImprimir.Name = "chbNaoImprimir";
            this.chbNaoImprimir.Size = new System.Drawing.Size(94, 16);
            this.chbNaoImprimir.TabIndex = 487;
            this.chbNaoImprimir.Text = "NÃO IMPRIMIR";
            this.chbNaoImprimir.UseVisualStyleBackColor = true;
            // 
            // chbSelecionarImpressora
            // 
            this.chbSelecionarImpressora.AutoSize = true;
            this.chbSelecionarImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSelecionarImpressora.Location = new System.Drawing.Point(96, 10);
            this.chbSelecionarImpressora.Name = "chbSelecionarImpressora";
            this.chbSelecionarImpressora.Size = new System.Drawing.Size(151, 16);
            this.chbSelecionarImpressora.TabIndex = 475;
            this.chbSelecionarImpressora.Text = "SELECIONAR IMPRESSORA";
            this.chbSelecionarImpressora.UseVisualStyleBackColor = true;
            // 
            // chbConfigImpressora
            // 
            this.chbConfigImpressora.AutoSize = true;
            this.chbConfigImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbConfigImpressora.Location = new System.Drawing.Point(96, 45);
            this.chbConfigImpressora.Name = "chbConfigImpressora";
            this.chbConfigImpressora.Size = new System.Drawing.Size(172, 16);
            this.chbConfigImpressora.TabIndex = 489;
            this.chbConfigImpressora.Text = "USAR CONFIG DA IMPRESSORA";
            this.chbConfigImpressora.UseVisualStyleBackColor = true;
            // 
            // rbtBIv
            // 
            this.rbtBIv.AutoSize = true;
            this.rbtBIv.Location = new System.Drawing.Point(3, 41);
            this.rbtBIv.Name = "rbtBIv";
            this.rbtBIv.Size = new System.Drawing.Size(42, 17);
            this.rbtBIv.TabIndex = 504;
            this.rbtBIv.TabStop = true;
            this.rbtBIv.Text = "BIV";
            this.rbtBIv.UseVisualStyleBackColor = true;
            // 
            // rbt220
            // 
            this.rbt220.AutoSize = true;
            this.rbt220.Location = new System.Drawing.Point(3, 25);
            this.rbt220.Name = "rbt220";
            this.rbt220.Size = new System.Drawing.Size(50, 17);
            this.rbt220.TabIndex = 503;
            this.rbt220.TabStop = true;
            this.rbt220.Text = "220V";
            this.rbt220.UseVisualStyleBackColor = true;
            // 
            // rbt110
            // 
            this.rbt110.AutoSize = true;
            this.rbt110.Location = new System.Drawing.Point(3, 10);
            this.rbt110.Name = "rbt110";
            this.rbt110.Size = new System.Drawing.Size(50, 17);
            this.rbt110.TabIndex = 502;
            this.rbt110.TabStop = true;
            this.rbt110.Text = "110V";
            this.rbt110.UseVisualStyleBackColor = true;
            // 
            // txtEAN
            // 
            this.txtEAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEAN.Location = new System.Drawing.Point(194, 263);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.ReadOnly = true;
            this.txtEAN.Size = new System.Drawing.Size(167, 24);
            this.txtEAN.TabIndex = 481;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 482;
            this.label9.Text = "EAN";
            // 
            // txtCodVarejo
            // 
            this.txtCodVarejo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodVarejo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodVarejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVarejo.Location = new System.Drawing.Point(78, 263);
            this.txtCodVarejo.Name = "txtCodVarejo";
            this.txtCodVarejo.ReadOnly = true;
            this.txtCodVarejo.Size = new System.Drawing.Size(105, 24);
            this.txtCodVarejo.TabIndex = 479;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 480;
            this.label8.Text = "COD VAREJO";
            // 
            // txtNS
            // 
            this.txtNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNS.Location = new System.Drawing.Point(368, 263);
            this.txtNS.Name = "txtNS";
            this.txtNS.ReadOnly = true;
            this.txtNS.Size = new System.Drawing.Size(172, 24);
            this.txtNS.TabIndex = 483;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 484;
            this.label5.Text = "NS";
            // 
            // frmProcessosDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 485);
            this.Controls.Add(this.txtNS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEAN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodVarejo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rbtDivergencia);
            this.Controls.Add(this.rbtReprovado);
            this.Controls.Add(this.rbtSucata);
            this.Controls.Add(this.rbtDevolucao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtMotivoDevolucao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtVarejista);
            this.Controls.Add(this.btnBuscarChamado);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProcessosDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEVOLUÇÃO / SUCATA";
            this.Load += new System.EventHandler(this.frmAjusteDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtMotivoDevolucao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtVarejista;
        private System.Windows.Forms.Button btnBuscarChamado;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtDevolucao;
        private System.Windows.Forms.RadioButton rbtSucata;
        private System.Windows.Forms.RadioButton rbtDivergencia;
        private System.Windows.Forms.RadioButton rbtReprovado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chbNaoImprimir;
        private System.Windows.Forms.CheckBox chbSelecionarImpressora;
        private System.Windows.Forms.CheckBox chbConfigImpressora;
        private System.Windows.Forms.RadioButton rbtBIv;
        private System.Windows.Forms.RadioButton rbt220;
        private System.Windows.Forms.RadioButton rbt110;
        private System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodVarejo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.Label label5;
    }
}