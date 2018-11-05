namespace lab4_lpf
{
    partial class login_form
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
            this.utlizator_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.utilizator_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // utlizator_label
            // 
            this.utlizator_label.AutoSize = true;
            this.utlizator_label.Location = new System.Drawing.Point(84, 58);
            this.utlizator_label.Name = "utlizator_label";
            this.utlizator_label.Padding = new System.Windows.Forms.Padding(5);
            this.utlizator_label.Size = new System.Drawing.Size(57, 23);
            this.utlizator_label.TabIndex = 0;
            this.utlizator_label.Text = "Utilizator";
            this.utlizator_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(84, 84);
            this.pass_label.Name = "pass_label";
            this.pass_label.Padding = new System.Windows.Forms.Padding(5);
            this.pass_label.Size = new System.Drawing.Size(47, 23);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Parola";
            this.pass_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // utilizator_textBox
            // 
            this.utilizator_textBox.Location = new System.Drawing.Point(149, 60);
            this.utilizator_textBox.Name = "utilizator_textBox";
            this.utilizator_textBox.Size = new System.Drawing.Size(150, 20);
            this.utilizator_textBox.TabIndex = 2;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Location = new System.Drawing.Point(149, 87);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(150, 20);
            this.pass_textBox.TabIndex = 3;
            this.pass_textBox.UseSystemPasswordChar = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(87, 111);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(223, 141);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(142, 140);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 218);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.utilizator_textBox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.utlizator_label);
            this.Name = "login_form";
            this.Text = "login_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label utlizator_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox utilizator_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button login_btn;
    }
}