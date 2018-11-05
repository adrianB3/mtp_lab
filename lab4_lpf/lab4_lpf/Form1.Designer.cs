namespace lab4_lpf
{
    partial class Form1
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
            this.echipa_label = new System.Windows.Forms.Label();
            this.echipa_comboBox = new System.Windows.Forms.ComboBox();
            this.adaugaEchipa_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.adaugaJucator_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // echipa_label
            // 
            this.echipa_label.AutoSize = true;
            this.echipa_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.echipa_label.Location = new System.Drawing.Point(15, 17);
            this.echipa_label.Name = "echipa_label";
            this.echipa_label.Padding = new System.Windows.Forms.Padding(10);
            this.echipa_label.Size = new System.Drawing.Size(78, 40);
            this.echipa_label.TabIndex = 0;
            this.echipa_label.Text = "Echipa";
            this.echipa_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // echipa_comboBox
            // 
            this.echipa_comboBox.DropDownHeight = 150;
            this.echipa_comboBox.FormattingEnabled = true;
            this.echipa_comboBox.IntegralHeight = false;
            this.echipa_comboBox.ItemHeight = 13;
            this.echipa_comboBox.Location = new System.Drawing.Point(99, 27);
            this.echipa_comboBox.Name = "echipa_comboBox";
            this.echipa_comboBox.Size = new System.Drawing.Size(265, 21);
            this.echipa_comboBox.TabIndex = 1;
            // 
            // adaugaEchipa_button
            // 
            this.adaugaEchipa_button.Location = new System.Drawing.Point(370, 25);
            this.adaugaEchipa_button.Name = "adaugaEchipa_button";
            this.adaugaEchipa_button.Size = new System.Drawing.Size(132, 23);
            this.adaugaEchipa_button.TabIndex = 2;
            this.adaugaEchipa_button.Text = "Adauga Echipa Noua";
            this.adaugaEchipa_button.UseVisualStyleBackColor = true;
            this.adaugaEchipa_button.Click += new System.EventHandler(this.adaugaEchipa_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(483, 331);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // adaugaJucator_button
            // 
            this.adaugaJucator_button.Location = new System.Drawing.Point(370, 399);
            this.adaugaJucator_button.Name = "adaugaJucator_button";
            this.adaugaJucator_button.Size = new System.Drawing.Size(131, 39);
            this.adaugaJucator_button.TabIndex = 4;
            this.adaugaJucator_button.Text = "Adauga Jucator";
            this.adaugaJucator_button.UseVisualStyleBackColor = true;
            this.adaugaJucator_button.Click += new System.EventHandler(this.adaugaJucator_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adaugaJucator_button);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.adaugaEchipa_button);
            this.Controls.Add(this.echipa_comboBox);
            this.Controls.Add(this.echipa_label);
            this.Name = "Form1";
            this.Text = "LPF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label echipa_label;
        private System.Windows.Forms.ComboBox echipa_comboBox;
        private System.Windows.Forms.Button adaugaEchipa_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button adaugaJucator_button;
    }
}

