namespace CRMagazine
{
    partial class frmEstoqueEntradaAvulsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoqueEntradaAvulsa));
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodPeca = new System.Windows.Forms.TextBox();
            this.txtDescPeca = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLimparTela = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 42);
            this.label6.TabIndex = 292;
            this.label6.Text = "ENTRADA DE PEÇAS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.txtTipo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnLimparTela);
            this.panel3.Controls.Add(this.btnEntrada);
            this.panel3.Controls.Add(this.txtQuantidade);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtCodPeca);
            this.panel3.Controls.Add(this.txtDescPeca);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(24, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 167);
            this.panel3.TabIndex = 291;
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(585, 106);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(108, 47);
            this.btnEntrada.TabIndex = 279;
            this.btnEntrada.Text = "ENTRADA";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(20, 123);
            this.txtQuantidade.MaxLength = 50;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(150, 31);
            this.txtQuantidade.TabIndex = 277;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 278;
            this.label1.Text = "Quantidade";
            // 
            // txtCodPeca
            // 
            this.txtCodPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPeca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPeca.Location = new System.Drawing.Point(20, 52);
            this.txtCodPeca.MaxLength = 50;
            this.txtCodPeca.Name = "txtCodPeca";
            this.txtCodPeca.Size = new System.Drawing.Size(150, 31);
            this.txtCodPeca.TabIndex = 273;
            this.txtCodPeca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPeca_KeyPress);
            // 
            // txtDescPeca
            // 
            this.txtDescPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescPeca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescPeca.Location = new System.Drawing.Point(176, 52);
            this.txtDescPeca.MaxLength = 50;
            this.txtDescPeca.Name = "txtDescPeca";
            this.txtDescPeca.ReadOnly = true;
            this.txtDescPeca.Size = new System.Drawing.Size(517, 31);
            this.txtDescPeca.TabIndex = 274;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 24);
            this.label16.TabIndex = 275;
            this.label16.Text = "Código da Peça";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(172, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 24);
            this.label17.TabIndex = 276;
            this.label17.Text = "Descrição da Peça";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = global::CRMagazine.Properties.Resources.LOGOBSOFT;
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 111);
            this.pictureBox2.TabIndex = 293;
            this.pictureBox2.TabStop = false;
            // 
            // btnLimparTela
            // 
            this.btnLimparTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTela.Location = new System.Drawing.Point(409, 125);
            this.btnLimparTela.Name = "btnLimparTela";
            this.btnLimparTela.Size = new System.Drawing.Size(101, 29);
            this.btnLimparTela.TabIndex = 294;
            this.btnLimparTela.Text = "LIMPAR TELA";
            this.btnLimparTela.UseVisualStyleBackColor = true;
            this.btnLimparTela.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(176, 123);
            this.txtTipo.MaxLength = 50;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(150, 31);
            this.txtTipo.TabIndex = 295;
            this.txtTipo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 296;
            this.label2.Text = "Tipo";
            this.label2.Visible = false;
            // 
            // frmEstoqueEntradaAvulsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 406);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstoqueEntradaAvulsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENTRADA DE PEÇAS";
            this.Load += new System.EventHandler(this.frmEstoqueEntradaSeparada_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCodPeca;
        private System.Windows.Forms.TextBox txtDescPeca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnLimparTela;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label2;
    }
}