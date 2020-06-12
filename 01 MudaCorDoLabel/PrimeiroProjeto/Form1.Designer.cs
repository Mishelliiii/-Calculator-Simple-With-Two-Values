namespace PrimeiroProjeto
{
    partial class frmPrimeiroFormulario
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
            this.btnVermelho = new System.Windows.Forms.Button();
            this.lblCor = new System.Windows.Forms.Label();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnPadrao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVermelho
            // 
            this.btnVermelho.Location = new System.Drawing.Point(29, 89);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(91, 40);
            this.btnVermelho.TabIndex = 0;
            this.btnVermelho.Text = "&Vermelho";
            this.btnVermelho.UseVisualStyleBackColor = true;
            this.btnVermelho.Click += new System.EventHandler(this.btnVermelho_Click);
            // 
            // lblCor
            // 
            this.lblCor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCor.Location = new System.Drawing.Point(29, 28);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(329, 41);
            this.lblCor.TabIndex = 1;
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(145, 89);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(94, 40);
            this.btnAzul.TabIndex = 2;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnPadrao
            // 
            this.btnPadrao.Location = new System.Drawing.Point(268, 89);
            this.btnPadrao.Name = "btnPadrao";
            this.btnPadrao.Size = new System.Drawing.Size(90, 40);
            this.btnPadrao.TabIndex = 3;
            this.btnPadrao.Text = "Verde";
            this.btnPadrao.UseVisualStyleBackColor = true;
            this.btnPadrao.Click += new System.EventHandler(this.btnPadrao_Click);
            // 
            // frmPrimeiroFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(382, 148);
            this.Controls.Add(this.btnPadrao);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.btnVermelho);
            this.Name = "frmPrimeiroFormulario";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnPadrao;
    }
}

