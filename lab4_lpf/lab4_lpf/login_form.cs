using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_lpf
{
    public partial class login_form : Form
    {
        Timer timer = new Timer() { Interval = 100 };

        public login_form()
        {
            InitializeComponent();
            timer.Tick += timer_tick_handler;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(utilizator_textBox.Text.Equals("Adrian") && pass_textBox.Text.Equals("adi"))
            {
                timer.Start();            
            }
            else
            {
                this.DialogResult = DialogResult.Retry;
            }
        }

        private void timer_tick_handler(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
