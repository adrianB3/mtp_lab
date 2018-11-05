namespace lab4_lpf
{
    partial class adaugare_jucator_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.nume_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.post_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cnp_textBox = new System.Windows.Forms.TextBox();
            this.anulare_buton = new System.Windows.Forms.Button();
            this.adaugaJucator_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // nume_textBox
            // 
            this.nume_textBox.Location = new System.Drawing.Point(54, 10);
            this.nume_textBox.Name = "nume_textBox";
            this.nume_textBox.Size = new System.Drawing.Size(205, 20);
            this.nume_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Post";
            // 
            // post_comboBox
            // 
            this.post_comboBox.FormattingEnabled = true;
            this.post_comboBox.Items.AddRange(new object[] {
            "Atacant",
            "Mijlocas",
            "Fundas",
            "Portar"});
            this.post_comboBox.Location = new System.Drawing.Point(54, 37);
            this.post_comboBox.Name = "post_comboBox";
            this.post_comboBox.Size = new System.Drawing.Size(121, 21);
            this.post_comboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNP";
            // 
            // cnp_textBox
            // 
            this.cnp_textBox.Location = new System.Drawing.Point(54, 68);
            this.cnp_textBox.Name = "cnp_textBox";
            this.cnp_textBox.Size = new System.Drawing.Size(205, 20);
            this.cnp_textBox.TabIndex = 5;
            // 
            // anulare_buton
            // 
            this.anulare_buton.Location = new System.Drawing.Point(183, 95);
            this.anulare_buton.Name = "anulare_buton";
            this.anulare_buton.Size = new System.Drawing.Size(75, 23);
            this.anulare_buton.TabIndex = 6;
            this.anulare_buton.Text = "Cancel";
            this.anulare_buton.UseVisualStyleBackColor = true;
            // 
            // adaugaJucator_buton
            // 
            this.adaugaJucator_buton.Location = new System.Drawing.Point(100, 95);
            this.adaugaJucator_buton.Name = "adaugaJucator_buton";
            this.adaugaJucator_buton.Size = new System.Drawing.Size(75, 23);
            this.adaugaJucator_buton.TabIndex = 7;
            this.adaugaJucator_buton.Text = "Adauga";
            this.adaugaJucator_buton.UseVisualStyleBackColor = true;
            this.adaugaJucator_buton.Click += new System.EventHandler(this.adaugaJucator_buton_Click);
            // 
            // adaugare_jucator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 140);
            this.Controls.Add(this.adaugaJucator_buton);
            this.Controls.Add(this.anulare_buton);
            this.Controls.Add(this.cnp_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.post_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nume_textBox);
            this.Controls.Add(this.label1);
            this.Name = "adaugare_jucator_form";
            this.Text = "adaugare_jucator_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nume_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox post_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cnp_textBox;
        private System.Windows.Forms.Button anulare_buton;
        private System.Windows.Forms.Button adaugaJucator_buton;
    }
}