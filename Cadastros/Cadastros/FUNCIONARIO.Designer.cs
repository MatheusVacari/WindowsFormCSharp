namespace Cadastros
{
    partial class FUNCIONARIO
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbdSolteiro = new System.Windows.Forms.RadioButton();
            this.rbdCasado = new System.Windows.Forms.RadioButton();
            this.gbxEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(44, 189);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(182, 60);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NOME:";
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbdSolteiro);
            this.gbxEstadoCivil.Controls.Add(this.rbdCasado);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(44, 66);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(200, 100);
            this.gbxEstadoCivil.TabIndex = 2;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // rbdSolteiro
            // 
            this.rbdSolteiro.AutoSize = true;
            this.rbdSolteiro.Location = new System.Drawing.Point(0, 40);
            this.rbdSolteiro.Name = "rbdSolteiro";
            this.rbdSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbdSolteiro.TabIndex = 4;
            this.rbdSolteiro.TabStop = true;
            this.rbdSolteiro.Text = "Solteiro(a)";
            this.rbdSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbdCasado
            // 
            this.rbdCasado.AutoSize = true;
            this.rbdCasado.Location = new System.Drawing.Point(91, 40);
            this.rbdCasado.Name = "rbdCasado";
            this.rbdCasado.Size = new System.Drawing.Size(73, 17);
            this.rbdCasado.TabIndex = 5;
            this.rbdCasado.TabStop = true;
            this.rbdCasado.Text = "Casado(a)";
            this.rbdCasado.UseVisualStyleBackColor = true;
            // 
            // FUNCIONARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 261);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FUNCIONARIO";
            this.Text = "-";
            this.Load += new System.EventHandler(this.FUNCIONARIO_Load);
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbdSolteiro;
        private System.Windows.Forms.RadioButton rbdCasado;
        private System.Windows.Forms.TextBox txtNome;
    }
}