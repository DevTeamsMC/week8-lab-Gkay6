using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PreLab06
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


            rbtnKolay.CheckedChanged += radioButton_CheckedChanged;
            rbtnOrta.CheckedChanged += radioButton_CheckedChanged;
            rbtnZor.CheckedChanged += radioButton_CheckedChanged;
            rbtnHangman.CheckedChanged += radioButton_CheckedChangedImg;
            rbtnCities.CheckedChanged += radioButton_CheckedChangedImg;
            rbtnEurope.CheckedChanged += radioButton_CheckedChangedImg;



            string difficulty = Properties.Settings.Default.Difficulty;
            if (difficulty == "easy") rbtnKolay.Checked = true;
            else if (difficulty == "medium") rbtnOrta.Checked = true;
            else if (difficulty == "hard") rbtnZor.Checked = true;
            else
            {
                MessageBox.Show("Error");
            }

            string backgroundImg = Properties.Settings.Default.BackgroundImg;
            string bgImgPath = "";
            if (backgroundImg == "hangman") rbtnHangman.Checked = true;
            else if (backgroundImg == "cities") rbtnCities.Checked = true;
            else if (backgroundImg == "europe") rbtnEurope.Checked = true;

            int time = Properties.Settings.Default.Time;
            numericUpDown_time.Value = time;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton rb = sender as System.Windows.Forms.RadioButton;

            if (rb != null && rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbtnKolay":
                        Properties.Settings.Default.Difficulty = "easy";
                        break;
                    case "rbtnOrta":
                        Properties.Settings.Default.Difficulty = "medium";
                        break;
                    case "rbtnZor":
                        Properties.Settings.Default.Difficulty = "hard";
                        break;
                }
            }
        }

        private void radioButton_CheckedChangedImg(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton rb = sender as System.Windows.Forms.RadioButton;

            if (rb != null && rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbtnHangman":
                        Properties.Settings.Default.BackgroundImg = "hangman";
                        break;
                    case "rbtnCities":
                        Properties.Settings.Default.BackgroundImg = "cities";
                        break;
                    case "rbtnEurope":
                        Properties.Settings.Default.BackgroundImg = "europe";
                        break;
                }
            }
        }

        private void numericUpDown_time_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Time = (int)numericUpDown_time.Value;
        }

    }
}
