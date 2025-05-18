namespace kuaforf
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRandevularim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.BackColor = System.Drawing.Color.Transparent;
            this.lblHosgeldin.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldin.ForeColor = System.Drawing.Color.Transparent;
            this.lblHosgeldin.Location = new System.Drawing.Point(711, 126);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(233, 28);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "HOŞGELDİNİZ<3";
            // 
            // btnRandevu
            // 
            this.btnRandevu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.Location = new System.Drawing.Point(562, 197);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(204, 66);
            this.btnRandevu.TabIndex = 1;
            this.btnRandevu.Text = "Randevu Al";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(847, 252);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(170, 70);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRandevularim
            // 
            this.btnRandevularim.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevularim.Location = new System.Drawing.Point(562, 315);
            this.btnRandevularim.Name = "btnRandevularim";
            this.btnRandevularim.Size = new System.Drawing.Size(204, 64);
            this.btnRandevularim.TabIndex = 3;
            this.btnRandevularim.Text = "Randevularım";
            this.btnRandevularim.UseVisualStyleBackColor = true;
            this.btnRandevularim.Click += new System.EventHandler(this.btnRandevularim_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 506);
            this.Controls.Add(this.btnRandevularim);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.lblHosgeldin);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRandevularim;
    }
}