namespace AdamAsmacaOyunudur
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.picAdam = new System.Windows.Forms.PictureBox();
            this.lblKelime = new System.Windows.Forms.Label();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAdam)).BeginInit();
            this.SuspendLayout();
            // 
            // picAdam
            // 
            this.picAdam.Location = new System.Drawing.Point(48, 45);
            this.picAdam.Name = "picAdam";
            this.picAdam.Size = new System.Drawing.Size(286, 268);
            this.picAdam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdam.TabIndex = 0;
            this.picAdam.TabStop = false;
            this.picAdam.Click += new System.EventHandler(this.picAdam_Click);
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(389, 134);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(100, 75);
            this.lblKelime.TabIndex = 1;
            this.lblKelime.Text = "----";
            this.lblKelime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtHarf
            // 
            this.txtHarf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHarf.Location = new System.Drawing.Point(402, 45);
            this.txtHarf.MaxLength = 1;
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(100, 31);
            this.txtHarf.TabIndex = 2;
            this.txtHarf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTahmin
            // 
            this.btnTahmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTahmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTahmin.ForeColor = System.Drawing.Color.White;
            this.btnTahmin.Location = new System.Drawing.Point(569, 53);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(75, 23);
            this.btnTahmin.TabIndex = 3;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(397, 265);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(135, 25);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "Kalan Hak: 6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtHarf);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.picAdam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAdam;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblDurum;
    }
}