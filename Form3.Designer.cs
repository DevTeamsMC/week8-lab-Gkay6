namespace PreLab06
{
    partial class Form3
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
            this.lblTime = new System.Windows.Forms.Label();
            this.numericUpDown_time = new System.Windows.Forms.NumericUpDown();
            this.rbtnHangman = new System.Windows.Forms.RadioButton();
            this.lblBackgroundImage = new System.Windows.Forms.Label();
            this.rbtnCities = new System.Windows.Forms.RadioButton();
            this.rbtnEurope = new System.Windows.Forms.RadioButton();
            this.rbtnKolay = new System.Windows.Forms.RadioButton();
            this.rbtnOrta = new System.Windows.Forms.RadioButton();
            this.rbtnZor = new System.Windows.Forms.RadioButton();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(42, 269);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(261, 38);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Başlangıç Süresi";
            // 
            // numericUpDown_time
            // 
            this.numericUpDown_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_time.Location = new System.Drawing.Point(47, 311);
            this.numericUpDown_time.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numericUpDown_time.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_time.Name = "numericUpDown_time";
            this.numericUpDown_time.Size = new System.Drawing.Size(267, 45);
            this.numericUpDown_time.TabIndex = 5;
            this.numericUpDown_time.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_time.ValueChanged += new System.EventHandler(this.numericUpDown_time_ValueChanged);
            // 
            // rbtnHangman
            // 
            this.rbtnHangman.AutoSize = true;
            this.rbtnHangman.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnHangman.Location = new System.Drawing.Point(13, 62);
            this.rbtnHangman.Name = "rbtnHangman";
            this.rbtnHangman.Size = new System.Drawing.Size(178, 41);
            this.rbtnHangman.TabIndex = 6;
            this.rbtnHangman.TabStop = true;
            this.rbtnHangman.Text = "Hangman";
            this.rbtnHangman.UseVisualStyleBackColor = true;
            // 
            // lblBackgroundImage
            // 
            this.lblBackgroundImage.AutoSize = true;
            this.lblBackgroundImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBackgroundImage.Location = new System.Drawing.Point(6, 18);
            this.lblBackgroundImage.Name = "lblBackgroundImage";
            this.lblBackgroundImage.Size = new System.Drawing.Size(145, 37);
            this.lblBackgroundImage.TabIndex = 7;
            this.lblBackgroundImage.Text = "Arkaplan";
            // 
            // rbtnCities
            // 
            this.rbtnCities.AutoSize = true;
            this.rbtnCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnCities.Location = new System.Drawing.Point(13, 109);
            this.rbtnCities.Name = "rbtnCities";
            this.rbtnCities.Size = new System.Drawing.Size(117, 41);
            this.rbtnCities.TabIndex = 8;
            this.rbtnCities.TabStop = true;
            this.rbtnCities.Text = "Cities";
            this.rbtnCities.UseVisualStyleBackColor = true;
            // 
            // rbtnEurope
            // 
            this.rbtnEurope.AutoSize = true;
            this.rbtnEurope.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnEurope.Location = new System.Drawing.Point(13, 158);
            this.rbtnEurope.Name = "rbtnEurope";
            this.rbtnEurope.Size = new System.Drawing.Size(141, 41);
            this.rbtnEurope.TabIndex = 9;
            this.rbtnEurope.TabStop = true;
            this.rbtnEurope.Text = "Europe";
            this.rbtnEurope.UseVisualStyleBackColor = true;
            // 
            // rbtnKolay
            // 
            this.rbtnKolay.AutoSize = true;
            this.rbtnKolay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnKolay.Location = new System.Drawing.Point(13, 59);
            this.rbtnKolay.Name = "rbtnKolay";
            this.rbtnKolay.Size = new System.Drawing.Size(120, 42);
            this.rbtnKolay.TabIndex = 0;
            this.rbtnKolay.TabStop = true;
            this.rbtnKolay.Text = "Kolay";
            this.rbtnKolay.UseVisualStyleBackColor = true;
            // 
            // rbtnOrta
            // 
            this.rbtnOrta.AutoSize = true;
            this.rbtnOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnOrta.Location = new System.Drawing.Point(13, 107);
            this.rbtnOrta.Name = "rbtnOrta";
            this.rbtnOrta.Size = new System.Drawing.Size(102, 42);
            this.rbtnOrta.TabIndex = 1;
            this.rbtnOrta.TabStop = true;
            this.rbtnOrta.Text = "Orta";
            this.rbtnOrta.UseVisualStyleBackColor = true;
            // 
            // rbtnZor
            // 
            this.rbtnZor.AutoSize = true;
            this.rbtnZor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnZor.Location = new System.Drawing.Point(13, 155);
            this.rbtnZor.Name = "rbtnZor";
            this.rbtnZor.Size = new System.Drawing.Size(87, 42);
            this.rbtnZor.TabIndex = 2;
            this.rbtnZor.TabStop = true;
            this.rbtnZor.Text = "Zor";
            this.rbtnZor.UseVisualStyleBackColor = true;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDifficulty.Location = new System.Drawing.Point(6, 18);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(108, 38);
            this.lblDifficulty.TabIndex = 3;
            this.lblDifficulty.Text = "Zorluk";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnKolay);
            this.groupBox1.Controls.Add(this.rbtnOrta);
            this.groupBox1.Controls.Add(this.lblDifficulty);
            this.groupBox1.Controls.Add(this.rbtnZor);
            this.groupBox1.Location = new System.Drawing.Point(49, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 207);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBackgroundImage);
            this.groupBox2.Controls.Add(this.rbtnHangman);
            this.groupBox2.Controls.Add(this.rbtnEurope);
            this.groupBox2.Controls.Add(this.rbtnCities);
            this.groupBox2.Location = new System.Drawing.Point(320, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 207);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown_time);
            this.Controls.Add(this.lblTime);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown numericUpDown_time;
        private System.Windows.Forms.RadioButton rbtnHangman;
        private System.Windows.Forms.Label lblBackgroundImage;
        private System.Windows.Forms.RadioButton rbtnCities;
        private System.Windows.Forms.RadioButton rbtnEurope;
        private System.Windows.Forms.RadioButton rbtnKolay;
        private System.Windows.Forms.RadioButton rbtnOrta;
        private System.Windows.Forms.RadioButton rbtnZor;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}