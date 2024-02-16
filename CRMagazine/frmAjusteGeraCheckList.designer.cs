namespace CRMagazine
{
    partial class frmAjusteGeraCheckList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjusteGeraCheckList));
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtAcessorio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.txtEstetico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChamado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTriador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataTriagem = new System.Windows.Forms.TextBox();
            this.txtAcessoriosDisponiveis = new System.Windows.Forms.TextBox();
            this.txtFuncional = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSAT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodSat = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(750, 572);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(127, 43);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "GERAR PDF";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtAcessorio
            // 
            this.txtAcessorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcessorio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAcessorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcessorio.Location = new System.Drawing.Point(33, 598);
            this.txtAcessorio.Multiline = true;
            this.txtAcessorio.Name = "txtAcessorio";
            this.txtAcessorio.Size = new System.Drawing.Size(262, 43);
            this.txtAcessorio.TabIndex = 386;
            this.txtAcessorio.Visible = false;
            this.txtAcessorio.TextChanged += new System.EventHandler(this.txtAcessorio_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRMagazine.Properties.Resources.JP;
            this.pictureBox1.Location = new System.Drawing.Point(615, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 109);
            this.pictureBox1.TabIndex = 385;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtFunc
            // 
            this.txtFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFunc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFunc.Location = new System.Drawing.Point(324, 598);
            this.txtFunc.Multiline = true;
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(262, 48);
            this.txtFunc.TabIndex = 387;
            this.txtFunc.Visible = false;
            this.txtFunc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            // 
            // txtEstetico
            // 
            this.txtEstetico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstetico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstetico.Location = new System.Drawing.Point(615, 375);
            this.txtEstetico.Multiline = true;
            this.txtEstetico.Name = "txtEstetico";
            this.txtEstetico.Size = new System.Drawing.Size(262, 180);
            this.txtEstetico.TabIndex = 388;
            this.txtEstetico.TextChanged += new System.EventHandler(this.txtEstetico_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 389;
            this.label1.Text = "ACESSÓRIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 390;
            this.label2.Text = "FUNCIONAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 391;
            this.label3.Text = "ESTÉTICO";
            // 
            // txtChamado
            // 
            this.txtChamado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChamado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChamado.Location = new System.Drawing.Point(88, 84);
            this.txtChamado.Name = "txtChamado";
            this.txtChamado.Size = new System.Drawing.Size(217, 26);
            this.txtChamado.TabIndex = 392;
            this.txtChamado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChamado_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 393;
            this.label4.Text = "OS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 395;
            this.label5.Text = "NÚMERO DE SÉRIE";
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSerie.Location = new System.Drawing.Point(88, 140);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(217, 26);
            this.txtNumeroSerie.TabIndex = 394;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 397;
            this.label6.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(321, 140);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(500, 26);
            this.txtDescricao.TabIndex = 396;
            // 
            // txtTriador
            // 
            this.txtTriador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTriador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTriador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriador.Location = new System.Drawing.Point(88, 194);
            this.txtTriador.Name = "txtTriador";
            this.txtTriador.Size = new System.Drawing.Size(353, 26);
            this.txtTriador.TabIndex = 398;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 399;
            this.label7.Text = "TRIADOR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(456, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 401;
            this.label8.Text = "DATA";
            // 
            // txtDataTriagem
            // 
            this.txtDataTriagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataTriagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataTriagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataTriagem.Location = new System.Drawing.Point(460, 194);
            this.txtDataTriagem.Name = "txtDataTriagem";
            this.txtDataTriagem.Size = new System.Drawing.Size(166, 26);
            this.txtDataTriagem.TabIndex = 400;
            this.txtDataTriagem.TextChanged += new System.EventHandler(this.txtDataTriagem_TextChanged);
            // 
            // txtAcessoriosDisponiveis
            // 
            this.txtAcessoriosDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcessoriosDisponiveis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAcessoriosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcessoriosDisponiveis.Location = new System.Drawing.Point(33, 375);
            this.txtAcessoriosDisponiveis.Multiline = true;
            this.txtAcessoriosDisponiveis.Name = "txtAcessoriosDisponiveis";
            this.txtAcessoriosDisponiveis.Size = new System.Drawing.Size(262, 217);
            this.txtAcessoriosDisponiveis.TabIndex = 402;
            this.txtAcessoriosDisponiveis.TextChanged += new System.EventHandler(this.txtAcessoriosDisponiveis_TextChanged);
            // 
            // txtFuncional
            // 
            this.txtFuncional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuncional.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncional.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncional.Location = new System.Drawing.Point(324, 375);
            this.txtFuncional.Multiline = true;
            this.txtFuncional.Name = "txtFuncional";
            this.txtFuncional.Size = new System.Drawing.Size(262, 217);
            this.txtFuncional.TabIndex = 403;
            this.txtFuncional.TextChanged += new System.EventHandler(this.txtDocumentosDisponiveis_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(642, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 405;
            this.label9.Text = "TIPO";
            // 
            // txtTipo
            // 
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(646, 194);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(175, 26);
            this.txtTipo.TabIndex = 404;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 407;
            this.label10.Text = "SAT";
            // 
            // txtSAT
            // 
            this.txtSAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAT.Location = new System.Drawing.Point(88, 248);
            this.txtSAT.Multiline = true;
            this.txtSAT.Name = "txtSAT";
            this.txtSAT.Size = new System.Drawing.Size(498, 97);
            this.txtSAT.TabIndex = 406;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(588, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 409;
            this.label11.Text = "COD SAT";
            // 
            // txtCodSat
            // 
            this.txtCodSat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodSat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSat.Location = new System.Drawing.Point(592, 248);
            this.txtCodSat.Name = "txtCodSat";
            this.txtCodSat.Size = new System.Drawing.Size(229, 26);
            this.txtCodSat.TabIndex = 408;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(615, 572);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(127, 43);
            this.btnSalvar.TabIndex = 410;
            this.btnSalvar.Text = "SALVAR PDF";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Image = global::CRMagazine.Properties.Resources.lupa_24x24;
            this.btnBusca.Location = new System.Drawing.Point(304, 84);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(35, 26);
            this.btnBusca.TabIndex = 430;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // frmAjusteGeraCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 630);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCodSat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSAT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtFuncional);
            this.Controls.Add(this.txtAcessoriosDisponiveis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDataTriagem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTriador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChamado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstetico);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.txtAcessorio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAjusteGeraCheckList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERA CHECKLIST";
            this.Load += new System.EventHandler(this.frmAjusteGeraCheckList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAcessorio;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.TextBox txtEstetico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChamado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTriador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDataTriagem;
        private System.Windows.Forms.TextBox txtAcessoriosDisponiveis;
        private System.Windows.Forms.TextBox txtFuncional;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSAT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodSat;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnBusca;
    }
}