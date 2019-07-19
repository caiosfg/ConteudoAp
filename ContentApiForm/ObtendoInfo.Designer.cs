namespace ContentApiForm
{
    partial class ObtendoInfo
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
            this.Carregando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Carregando
            // 
            this.Carregando.AutoSize = true;
            this.Carregando.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carregando.Location = new System.Drawing.Point(51, 43);
            this.Carregando.Name = "Carregando";
            this.Carregando.Size = new System.Drawing.Size(257, 42);
            this.Carregando.TabIndex = 0;
            this.Carregando.Text = "Carregando .......";
            // 
            // ObtendoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 140);
            this.Controls.Add(this.Carregando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ObtendoInfo";
            this.Text = "ObtendoInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Carregando;
    }
}