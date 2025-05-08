using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace PreLab06
{

    public partial class Form2 : Form
    {
        private List<string> wordList = new List<string>();
        private List<string> clues = new List<string>();


        string selectedWord = "";
        int selectedWordIndex = 0;
        string displayWord = "";
        int wrongGuesses = 0;

        bool[] wrongLetters = new bool[32];
        char[] current_guess_state;

        int time_s = 0;

        string question_category = "matematik";
        string question_difficulty = "easy";
        string selected_img = "hangman";

        private List<Image> game_img = new List<Image>();
        public Form2()
        {
            InitializeComponent();

            question_difficulty = Properties.Settings.Default.Difficulty;
            LoadQuestions();

            selected_img = Properties.Settings.Default.BackgroundImg;
            LoadBackgroundImgs();

            display_image();

            StartGame();
        }


        public void LoadBackgroundImgs()
        {
            string bgImgPath = "";
            if (selected_img == "hangman") bgImgPath = "hangman_imgs/";
            else if (selected_img == "cities") bgImgPath = "cities_imgs/";
            else if (selected_img == "europe") bgImgPath = "europe_imgs/";

            for (int i = 1; i <= 10; i++)
            {
                game_img.Add(Image.FromFile(bgImgPath + i + ".jpg"));
            }
        }
        public void LoadQuestions()
        {
            string filePath = "questions.csv";
            string question_category = Properties.Settings.Default.Category;

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split(',');
                    // Kelime, Zorluk, Kategori, Ipucu
                    if (parts.Length >= 4 &&
                        parts[1] == question_difficulty &&
                        parts[2] == question_category)
                    {
                        wordList.Add(parts[0]);
                        clues.Add(parts[3]);
                    }
                }

            }
            else
            {
                MessageBox.Show("Sorular Bulunamadı");
            }
        }

        public void display_image()
        {
            if (wrongGuesses < 10 && wrongGuesses >= 0)
            {
                pictureBox_hangman.Image = game_img[wrongGuesses];
            }
        }

        void StartGame()
        {
            Random rnd = new Random();
            int index = rnd.Next(wordList.Count);
            selectedWord = wordList[index];
            selectedWordIndex = index;

            lbl_timer1.Text = "Süre: " + Properties.Settings.Default.Time.ToString();
            lbl_kategori.Text = "Kategori: " + Properties.Settings.Default.Category;


            if (question_difficulty == "easy") lbl_seviye.Text = "Zorluk: Kolay";
            else if (question_difficulty == "medium") lbl_seviye.Text = "Zorluk: Orta";
            else if (question_difficulty == "hard") lbl_seviye.Text = "Zorluk: Zor";

            lbl_ipucu.Text = "";
            lbl_kelime_uzunlugu.Text = "Kelime Uzunluğu: " + selectedWord.Length.ToString();
            lbl_kelime.Text = "";

            current_guess_state = new char[selectedWord.Length];
            for (int i = 0; i < selectedWord.Length; i++) {
                lbl_kelime.Text += "_ ";
                current_guess_state[i] = '_';
            }

            lbl_puan.Text = "PUAN: 100";
            lbl_yanlis_tahmin.Text = "Yanlış Tahminler: ";
            time_s = 0;
            timer1.Start();

            display_image();
        }
 
       

        private void btn_bitir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Oyundan Çık", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }



        public bool make_guess(char ch)
        {
            bool letter_in_word = false;

            for (int i = 0; i < selectedWord.Length; i++)
            {

                if (selectedWord[i] == ch)
                {
                    current_guess_state[i] = ch;
                    letter_in_word = true;
                }
            }

            lbl_kelime.Text = "";
            for (int i = 0; i < selectedWord.Length; i++)
            {
                lbl_kelime.Text += current_guess_state[i] + " ";

            }

            return letter_in_word;
        }

        private void btn_tahmin_Click(object sender, EventArgs e)
        {


            string guess_s = textBox_tahmin.Text.ToString();

            if (guess_s.Length != 1 || !((guess_s[0] >= 'a' && guess_s[0] <= 'z') || (guess_s[0] >= 'A' && guess_s[0] <= 'Z')))
            {
                MessageBox.Show("Geçerli karakter değil");
                return;
            }

            char guess = guess_s[0];
            if ((guess_s[0] >= 'A' && guess_s[0] <= 'Z'))
            {
                guess = (char)(guess_s[0] + 32);
            }


            if (!make_guess(guess))
            {
                if (wrongLetters[guess - 'a'] == false)
                {

                    wrongGuesses++;
                    wrongLetters[guess - 'a'] = true;
                }else
                {
                    MessageBox.Show("Bu harf zaten denendi");
                }
            }


            lbl_puan.Text = "PUAN: " + (100 - wrongGuesses*10).ToString();
            lbl_yanlis_tahmin.Text = "Yanliş Tahminler: ";

            for (int i = 0; i < 32; i++)
            {
                if (wrongLetters[i])
                {
                    lbl_yanlis_tahmin.Text += (char)('a' + i) + " ";
                }
            }

            display_image();

            if (wrongGuesses >= 9)
            {
                timer1.Stop();
                btn_tahmin.Enabled = false;
                this.BackColor = Color.Red;
                MessageBox.Show("Yenildiniz! Kelimeniz: " + selectedWord);
                Application.Restart();
            }
            else
            {
                bool win = true;
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (current_guess_state[i] == '_')
                    {
                        win = false;
                        break;
                    }
                }

                if (win)
                {
                    btn_tahmin.Enabled = false;
                    timer1.Stop();
                    this.BackColor = Color.Green;
                    MessageBox.Show("Kazandınız");
                    Application.Restart();
                }
            }
        }


        private void btn_ipucu_Click(object sender, EventArgs e)
        {
            lbl_ipucu.Text = "İpucu: " + clues[selectedWordIndex];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_s++;
            lbl_timer1.Text = "Süre: " + (Properties.Settings.Default.Time - time_s).ToString();

            if (Properties.Settings.Default.Time - time_s <= 0)
            {
                btn_tahmin.Enabled = false;
                timer1.Stop();
                this.BackColor = Color.Red;
                MessageBox.Show("Süreniz bitti! Kelimeniz: " + selectedWord);
                Application.Restart();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
