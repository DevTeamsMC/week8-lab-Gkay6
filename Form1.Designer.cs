namespace PreLab06
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
            this.lbl_hangman = new System.Windows.Forms.Label();
            this.btn_basla = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lbl_ayarlar = new System.Windows.Forms.Label();
            this.comboBox_kategori = new System.Windows.Forms.ComboBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_hangman
            // 
            this.lbl_hangman.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hangman.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hangman.Location = new System.Drawing.Point(578, 357);
            this.lbl_hangman.Name = "lbl_hangman";
            this.lbl_hangman.Size = new System.Drawing.Size(412, 73);
            this.lbl_hangman.TabIndex = 0;
            this.lbl_hangman.Text = "HANGMAN";
            // 
            // btn_basla
            // 
            this.btn_basla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_basla.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_basla.ForeColor = System.Drawing.Color.Black;
            this.btn_basla.Location = new System.Drawing.Point(688, 491);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(119, 49);
            this.btn_basla.TabIndex = 1;
            this.btn_basla.Text = "BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::PreLab06.Properties.Resources.settings_image;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.Location = new System.Drawing.Point(67, 584);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 100);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lbl_ayarlar
            // 
            this.lbl_ayarlar.AutoSize = true;
            this.lbl_ayarlar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ayarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ayarlar.Location = new System.Drawing.Point(63, 687);
            this.lbl_ayarlar.Name = "lbl_ayarlar";
            this.lbl_ayarlar.Size = new System.Drawing.Size(93, 20);
            this.lbl_ayarlar.TabIndex = 3;
            this.lbl_ayarlar.Text = "AYARLAR";
            // 
            // comboBox_kategori
            // 
            this.comboBox_kategori.FormattingEnabled = true;
            this.comboBox_kategori.Items.AddRange(new object[] {
            "Tarih",
            "Cografya",
            "Matematik",
            "Genel Kultur",
            "Karma"});
            this.comboBox_kategori.Location = new System.Drawing.Point(767, 433);
            this.comboBox_kategori.Name = "comboBox_kategori";
            this.comboBox_kategori.Size = new System.Drawing.Size(121, 24);
            this.comboBox_kategori.TabIndex = 4;
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategori.Location = new System.Drawing.Point(599, 432);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(146, 25);
            this.lbl_kategori.TabIndex = 5;
            this.lbl_kategori.Text = "Kategori Seçin:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 716);
            this.Controls.Add(this.lbl_kategori);
            this.Controls.Add(this.comboBox_kategori);
            this.Controls.Add(this.lbl_ayarlar);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.lbl_hangman);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hangman;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lbl_ayarlar;
        private System.Windows.Forms.ComboBox comboBox_kategori;
        private System.Windows.Forms.Label lbl_kategori;
    }
}

