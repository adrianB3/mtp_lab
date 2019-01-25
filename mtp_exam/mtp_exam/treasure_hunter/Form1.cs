using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treasure_hunter
{
    public partial class Form1 : Form
    {
        private int leftTries = 10;
        private int rndRow = 0;
        private int rndCol = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Text = leftTries.ToString();
            var rnd = new Random();
            rndRow = rnd.Next(0, 4);
            rndCol = rnd.Next(0, 4);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var btn = new Button() { Text = "(" + (i+1) + ", " + (j+1) + ")" , Dock=DockStyle.Fill, Name = i + ", " + j };
                    btn.Click += Clicked;
                    tableLayoutPanel1.Controls.Add(btn);
                }
            }
        }

        private void Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var name = btn.Name.Split(',');
            leftTries--;
            label2.Text = leftTries.ToString();
            if(leftTries == 0)
            {
                MessageBox.Show("Try again!");
                var rnd = new Random();
                rndRow = rnd.Next(0, 4);
                rndCol = rnd.Next(0, 4);
                leftTries = 10;
                label2.Text = leftTries.ToString();
            }
            else
            {
                if(rndRow == int.Parse(name[0]) && rndCol == int.Parse(name[1]))
                {
                    MessageBox.Show("Well Done");
                    var rnd = new Random();
                    rndRow = rnd.Next(0, 4);
                    rndCol = rnd.Next(0, 4);
                    leftTries = 10;
                    label2.Text = leftTries.ToString();
                }
            }
        }
    }
}
