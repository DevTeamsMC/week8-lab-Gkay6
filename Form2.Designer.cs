namespace PreLab06
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lbl_hangman = new System.Windows.Forms.Label();
            this.btn_ipucu = new System.Windows.Forms.Button();
            this.lbl_kelime_uzunlugu = new System.Windows.Forms.Label();
            this.lbl_yanlis_tahmin = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.btn_tahmin = new System.Windows.Forms.Button();
            this.btn_bitir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ipucu = new System.Windows.Forms.Label();
            this.lbl_kelime = new System.Windows.Forms.Label();
            this.textBox_tahmin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox_hangman = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer1 = new System.Windows.Forms.Label();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.lbl_seviye = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hangman)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hangman
            // 
            this.lbl_hangman.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hangman.Location = new System.Drawing.Point(359, 9);
            this.lbl_hangman.Name = "lbl_hangman";
            this.lbl_hangman.Size = new System.Drawing.Size(286, 45);
            this.lbl_hangman.TabIndex = 0;
            this.lbl_hangman.Text = "HANGMAN";
            // 
            // btn_ipucu
            // 
            this.btn_ipucu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ipucu.Location = new System.Drawing.Point(328, 185);
            this.btn_ipucu.Name = "btn_ipucu";
            this.btn_ipucu.Size = new System.Drawing.Size(102, 35);
            this.btn_ipucu.TabIndex = 1;
            this.btn_ipucu.Text = "İpucu?";
            this.btn_ipucu.UseVisualStyleBackColor = false;
            this.btn_ipucu.Click += new System.EventHandler(this.btn_ipucu_Click);
            // 
            // lbl_kelime_uzunlugu
            // 
            this.lbl_kelime_uzunlugu.AutoSize = true;
            this.lbl_kelime_uzunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelime_uzunlugu.Location = new System.Drawing.Point(10, 278);
            this.lbl_kelime_uzunlugu.Name = "lbl_kelime_uzunlugu";
            this.lbl_kelime_uzunlugu.Size = new System.Drawing.Size(156, 20);
            this.lbl_kelime_uzunlugu.TabIndex = 2;
            this.lbl_kelime_uzunlugu.Text = "Kelime Uzunluğu:";
            // 
            // lbl_yanlis_tahmin
            // 
            this.lbl_yanlis_tahmin.AutoSize = true;
            this.lbl_yanlis_tahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yanlis_tahmin.Location = new System.Drawing.Point(10, 314);
            this.lbl_yanlis_tahmin.Name = "lbl_yanlis_tahmin";
            this.lbl_yanlis_tahmin.Size = new System.Drawing.Size(155, 20);
            this.lbl_yanlis_tahmin.TabIndex = 3;
            this.lbl_yanlis_tahmin.Text = "Yanlış Tahminler:";
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.Location = new System.Drawing.Point(6, 372);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(148, 46);
            this.lbl_puan.TabIndex = 4;
            this.lbl_puan.Text = "PUAN:";
            // 
            // btn_tahmin
            // 
            this.btn_tahmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_tahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tahmin.Location = new System.Drawing.Point(110, 454);
            this.btn_tahmin.Name = "btn_tahmin";
            this.btn_tahmin.Size = new System.Drawing.Size(141, 45);
            this.btn_tahmin.TabIndex = 5;
            this.btn_tahmin.Text = "Tahmin Et";
            this.btn_tahmin.UseVisualStyleBackColor = false;
            this.btn_tahmin.Click += new System.EventHandler(this.btn_tahmin_Click);
            // 
            // btn_bitir
            // 
            this.btn_bitir.BackColor = System.Drawing.Color.Gold;
            this.btn_bitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bitir.Location = new System.Drawing.Point(257, 454);
            this.btn_bitir.Name = "btn_bitir";
            this.btn_bitir.Size = new System.Drawing.Size(173, 45);
            this.btn_bitir.TabIndex = 6;
            this.btn_bitir.Text = "Oyunu Bitir";
            this.btn_bitir.UseVisualStyleBackColor = false;
            this.btn_bitir.Click += new System.EventHandler(this.btn_bitir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ipucu);
            this.groupBox1.Controls.Add(this.lbl_kelime);
            this.groupBox1.Controls.Add(this.textBox_tahmin);
            this.groupBox1.Controls.Add(this.btn_ipucu);
            this.groupBox1.Controls.Add(this.lbl_kelime_uzunlugu);
            this.groupBox1.Controls.Add(this.lbl_yanlis_tahmin);
            this.groupBox1.Controls.Add(this.btn_bitir);
            this.groupBox1.Controls.Add(this.lbl_puan);
            this.groupBox1.Controls.Add(this.btn_tahmin);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 573);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lbl_ipucu
            // 
            this.lbl_ipucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ipucu.Location = new System.Drawing.Point(20, 185);
            this.lbl_ipucu.Name = "lbl_ipucu";
            this.lbl_ipucu.Size = new System.Drawing.Size(305, 77);
            this.lbl_ipucu.TabIndex = 9;
            this.lbl_ipucu.Text = "İpucu";
            // 
            // lbl_kelime
            // 
            this.lbl_kelime.AutoSize = true;
            this.lbl_kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelime.Location = new System.Drawing.Point(15, 50);
            this.lbl_kelime.Name = "lbl_kelime";
            this.lbl_kelime.Size = new System.Drawing.Size(141, 46);
            this.lbl_kelime.TabIndex = 8;
            this.lbl_kelime.Text = "Kelime";
            // 
            // textBox_tahmin
            // 
            this.textBox_tahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_tahmin.Location = new System.Drawing.Point(18, 454);
            this.textBox_tahmin.MaxLength = 1;
            this.textBox_tahmin.Name = "textBox_tahmin";
            this.textBox_tahmin.Size = new System.Drawing.Size(86, 41);
            this.textBox_tahmin.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox_hangman);
            this.groupBox2.Location = new System.Drawing.Point(492, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 573);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox_hangman
            // 
            this.pictureBox_hangman.Location = new System.Drawing.Point(44, 63);
            this.pictureBox_hangman.Name = "pictureBox_hangman";
            this.pictureBox_hangman.Size = new System.Drawing.Size(428, 391);
            this.pictureBox_hangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_hangman.TabIndex = 7;
            this.pictureBox_hangman.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timer1
            // 
            this.lbl_timer1.AutoSize = true;
            this.lbl_timer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_timer1.Location = new System.Drawing.Point(8, 75);
            this.lbl_timer1.Name = "lbl_timer1";
            this.lbl_timer1.Size = new System.Drawing.Size(115, 46);
            this.lbl_timer1.TabIndex = 8;
            this.lbl_timer1.Text = "Süre:";
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategori.Location = new System.Drawing.Point(279, 96);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(76, 20);
            this.lbl_kategori.TabIndex = 9;
            this.lbl_kategori.Text = "Kategori:";
            // 
            // lbl_seviye
            // 
            this.lbl_seviye.AutoSize = true;
            this.lbl_seviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_seviye.Location = new System.Drawing.Point(488, 96);
            this.lbl_seviye.Name = "lbl_seviye";
            this.lbl_seviye.Size = new System.Drawing.Size(63, 20);
            this.lbl_seviye.TabIndex = 10;
            this.lbl_seviye.Text = "Seviye:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 744);
            this.Controls.Add(this.lbl_seviye);
            this.Controls.Add(this.lbl_kategori);
            this.Controls.Add(this.lbl_timer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_hangman);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hangman;
        private System.Windows.Forms.Button btn_ipucu;
        private System.Windows.Forms.Label lbl_kelime_uzunlugu;
        private System.Windows.Forms.Label lbl_yanlis_tahmin;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Button btn_tahmin;
        private System.Windows.Forms.Button btn_bitir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox_hangman;
        private System.Windows.Forms.TextBox textBox_tahmin;
        private System.Windows.Forms.Label lbl_ipucu;
        private System.Windows.Forms.Label lbl_kelime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer1;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.Label lbl_seviye;
    }
}