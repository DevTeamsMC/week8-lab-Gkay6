using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLab06
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Image cover = Image.FromFile("hangman_imgs/cover2.jpg");
            this.BackgroundImage = cover;
            comboBox_kategori.SelectedIndex = 0;

        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Category = comboBox_kategori.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form3 settings_form = new Form3();
            settings_form.ShowDialog();
        }
    }
}
