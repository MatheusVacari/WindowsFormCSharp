namespace Cadastros
{
    partial class MENU
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Image = global::Cadastros.Properties.Resources.CLIEN;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.Location = new System.Drawing.Point(12, 64);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(103, 111);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Cadastros.Properties.Resources.iconfinder_059_CircledOff_183188;
            this.btnSair.Location = new System.Drawing.Point(61, 206);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 79);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Image = global::Cadastros.Properties.Resources.FUNCI;
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionario.Location = new System.Drawing.Point(134, 64);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(106, 111);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.Text = "FUNCIONARIO";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 354);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFuncionario);
            this.Name = "MENU";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCliente;
    }
}

