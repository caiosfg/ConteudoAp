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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImportaConteudo = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.Compactar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Sender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportaConteudo
            // 
            this.ImportaConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ImportaConteudo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportaConteudo.Location = new System.Drawing.Point(12, 12);
            this.ImportaConteudo.Name = "ImportaConteudo";
            this.ImportaConteudo.Size = new System.Drawing.Size(259, 51);
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
            this.txtConteudo.Location = new System.Drawing.Point(12, 109);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(717, 231);
            this.txtConteudo.TabIndex = 1;
            // 
            // Compactar
            // 
            this.Compactar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Compactar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compactar.Location = new System.Drawing.Point(292, 12);
            this.Compactar.Name = "Compactar";
            this.Compactar.Size = new System.Drawing.Size(298, 51);
            this.Compactar.TabIndex = 3;
            this.Compactar.Text = "Compactar";
            this.Compactar.UseVisualStyleBackColor = false;
            this.Compactar.Click += new System.EventHandler(this.Compactar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 80);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(717, 23);
            this.progressBar.TabIndex = 4;
            // 
            // Sender
            // 
            this.Sender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Sender.BackgroundImage = global::ContentApiForm.Properties.Resources.Email_Send;
            this.Sender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sender.Location = new System.Drawing.Point(609, 12);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(127, 51);
            this.Sender.TabIndex = 5;
            this.Sender.Text = "Send Email";
            this.Sender.UseVisualStyleBackColor = false;
            this.Sender.Click += new System.EventHandler(this.Sender_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(748, 355);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Compactar);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.ImportaConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Busca Conteudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportaConteudo;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button Compactar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Sender;
    }
}

