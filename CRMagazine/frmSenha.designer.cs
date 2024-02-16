namespace CRMagazine
{
    partial class frmSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSenha));
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlVolts = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtVolts = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAmper = new System.Windows.Forms.TextBox();
            this.pnlVolts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(41, 114);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.PasswordChar = '*';
            this.txtTexto.Size = new System.Drawing.Size(231, 31);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "EQUIPAMENTO COM 3G";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "DIGITAR O IMEI:";
            this.label2.Visible = false;
            // 
            // pnlVolts
            // 
            this.pnlVolts.Controls.Add(this.btnOK);
            this.pnlVolts.Controls.Add(this.txtVolts);
            this.pnlVolts.Controls.Add(this.label15);
            this.pnlVolts.Controls.Add(this.label14);
            this.pnlVolts.Controls.Add(this.txtAmper);
            this.pnlVolts.Location = new System.Drawing.Point(41, 151);
            this.pnlVolts.Name = "pnlVolts";
            this.pnlVolts.Size = new System.Drawing.Size(231, 51);
            this.pnlVolts.TabIndex = 295;
            this.pnlVolts.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(171, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(45, 39);
            this.btnOK.TabIndex = 294;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtVolts
            // 
            this.txtVolts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVolts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolts.Location = new System.Drawing.Point(12, 22);
            this.txtVolts.Name = "txtVolts";
            this.txtVolts.Size = new System.Drawing.Size(48, 26);
            this.txtVolts.TabIndex = 290;
            this.txtVolts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolts_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 293;
            this.label15.Text = "Amperagem";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 291;
            this.label14.Text = "Voltagem";
            // 
            // txtAmper
            // 
            this.txtAmper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmper.Location = new System.Drawing.Point(88, 22);
            this.txtAmper.Name = "txtAmper";
            this.txtAmper.Size = new System.Drawing.Size(54, 26);
            this.txtAmper.TabIndex = 292;
            this.txtAmper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmper_KeyPress);
            // 
            // frmRecebeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 214);
            this.Controls.Add(this.pnlVolts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecebeTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA DE SENHA";
            this.Load += new System.EventHandler(this.frmRecebeTexto_Load);
            this.pnlVolts.ResumeLayout(false);
            this.pnlVolts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlVolts;
        private System.Windows.Forms.TextBox txtVolts;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAmper;
        private System.Windows.Forms.Button btnOK;
    }
}