namespace ContentApiForm
{
    partial class Form1
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
            this.ImportaConteudo = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.ExportaExcel = new System.Windows.Forms.Button();
            this.Compactar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportaConteudo
            // 
            this.ImportaConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ImportaConteudo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportaConteudo.Location = new System.Drawing.Point(68, 23);
            this.ImportaConteudo.Name = "ImportaConteudo";
            this.ImportaConteudo.Size = new System.Drawing.Size(159, 46);
            this.ImportaConteudo.TabIndex = 0;
            this.ImportaConteudo.Text = "Importa Conteudo";
            this.ImportaConteudo.UseVisualStyleBackColor = false;
            this.ImportaConteudo.Click += new System.EventHandler(this.ImportaConteudo_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtConteudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConteudo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtConteudo.Location = new System.Drawing.Point(39, 103);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(690, 237);
            this.txtConteudo.TabIndex = 1;
            // 
            // ExportaExcel
            // 
            this.ExportaExcel.BackColor = System.Drawing.Color.Silver;
            this.ExportaExcel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportaExcel.Location = new System.Drawing.Point(280, 23);
            this.ExportaExcel.Name = "ExportaExcel";
            this.ExportaExcel.Size = new System.Drawing.Size(159, 46);
            this.ExportaExcel.TabIndex = 2;
            this.ExportaExcel.Text = "Exporta Excel";
            this.ExportaExcel.UseVisualStyleBackColor = false;
            this.ExportaExcel.Click += new System.EventHandler(this.ExportaExcel_Click);
            // 
            // Compactar
            // 
            this.Compactar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Compactar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compactar.Location = new System.Drawing.Point(492, 23);
            this.Compactar.Name = "Compactar";
            this.Compactar.Size = new System.Drawing.Size(159, 46);
            this.Compactar.TabIndex = 3;
            this.Compactar.Text = "Compactar";
            this.Compactar.UseVisualStyleBackColor = false;
            this.Compactar.Click += new System.EventHandler(this.Compactar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 352);
            this.Controls.Add(this.Compactar);
            this.Controls.Add(this.ExportaExcel);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.ImportaConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Busca Conteudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportaConteudo;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button ExportaExcel;
        private System.Windows.Forms.Button Compactar;
    }
}

