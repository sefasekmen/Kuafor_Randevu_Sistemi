namespace kuaforf
{
    partial class RandevularimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevularimForm));
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Location = new System.Drawing.Point(505, 97);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.RowHeadersWidth = 51;
            this.dgvRandevular.RowTemplate.Height = 24;
            this.dgvRandevular.Size = new System.Drawing.Size(476, 121);
            this.dgvRandevular.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(707, 279);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 48);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // RandevularimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 508);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvRandevular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandevularimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevularım";
            this.Load += new System.EventHandler(this.RandevularimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.Button btnSil;
    }
}