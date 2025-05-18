namespace kuaforf
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAd.Location = new System.Drawing.Point(812, 103);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(201, 28);
            this.txtPersonelAd.TabIndex = 0;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSoyad.Location = new System.Drawing.Point(812, 154);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(201, 28);
            this.txtPersonelSoyad.TabIndex = 1;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.Location = new System.Drawing.Point(1131, 123);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(175, 43);
            this.btnPersonelEkle.TabIndex = 2;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(661, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(661, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoneller.Location = new System.Drawing.Point(665, 239);
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.RowHeadersWidth = 51;
            this.dgvPersoneller.RowTemplate.Height = 24;
            this.dgvPersoneller.Size = new System.Drawing.Size(404, 121);
            this.dgvPersoneller.TabIndex = 5;
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(665, 397);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 24;
            this.dgvKullanicilar.Size = new System.Drawing.Size(404, 133);
            this.dgvKullanicilar.TabIndex = 7;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnKullaniciSil.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciSil.Location = new System.Drawing.Point(1131, 439);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(175, 42);
            this.btnKullaniciSil.TabIndex = 8;
            this.btnKullaniciSil.Text = "Kullanıcıyı Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = false;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnPersonelSil.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.Location = new System.Drawing.Point(1131, 272);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(175, 42);
            this.btnPersonelSil.TabIndex = 9;
            this.btnPersonelSil.Text = "Personeli Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = false;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click_1);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1410, 593);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.dgvPersoneller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.txtPersonelAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPersoneller;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnPersonelSil;
    }
}