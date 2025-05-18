namespace kuaforf
{
    partial class RandevuAlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuAlForm));
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblIslem = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(656, 128);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(78, 25);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(656, 190);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(69, 25);
            this.lblSaat.TabIndex = 1;
            this.lblSaat.Text = "Saat:";
            // 
            // lblIslem
            // 
            this.lblIslem.AutoSize = true;
            this.lblIslem.BackColor = System.Drawing.Color.Transparent;
            this.lblIslem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslem.ForeColor = System.Drawing.Color.White;
            this.lblIslem.Location = new System.Drawing.Point(656, 247);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(143, 25);
            this.lblIslem.TabIndex = 2;
            this.lblIslem.Text = "İşlem Türü:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(842, 122);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(281, 28);
            this.dtpTarih.TabIndex = 3;
            // 
            // cmbSaat
            // 
            this.cmbSaat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(842, 181);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(218, 28);
            this.cmbSaat.TabIndex = 4;
            // 
            // cmbIslem
            // 
            this.cmbIslem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Location = new System.Drawing.Point(842, 244);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(218, 28);
            this.cmbIslem.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(802, 409);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(168, 77);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Randevu Oluştur";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(656, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personel:";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(842, 313);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(218, 28);
            this.cmbPersonel.TabIndex = 9;
            // 
            // RandevuAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 574);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbIslem);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblIslem);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandevuAlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Al";
            this.Load += new System.EventHandler(this.RandevuAlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersonel;
    }
}