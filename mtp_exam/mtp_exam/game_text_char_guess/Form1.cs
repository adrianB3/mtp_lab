using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace game_text_char_guess
{
    public partial class Main : Form
    {
        private string text;
        private int count = 0;
        private float score = 0;
        public Main()
        {
            InitializeComponent();
            inputLabel.Text = "Input new character (just one!)";
            var fs = new StreamReader(new FileStream("rand_text.txt", FileMode.Open));
            text = fs.ReadToEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(count < text.Length)
            {
                if (inputTb.Text.ToString().ToLower().Equals(text.ElementAt(count).ToString().ToLower()))
                {
                    validationLabel.Text = "Yep";
                    textBox1.AppendText(text[count].ToString());
                    score++;
                    float scorePrc = (100 * score) / text.Length;
                    scorLabel.Text = scorePrc.ToString() + " %";
                }
                else
                {
                    validationLabel.Text = "Nope";
                    textBox1.AppendText(text[count].ToString());
                }
                count++;
                inputTb.Clear();
                inputTb.Focus();
            }
            if(count == text.Length)
            {
                button1.Enabled = false;
                validationLabel.Text = "End of text";
            }
        }
    }
}
