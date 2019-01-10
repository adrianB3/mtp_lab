namespace ex_3_fisiere
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
            this.label1 = new System.Windows.Forms.Label();
            this.pathTb = new System.Windows.Forms.TextBox();
            this.buttonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATH:";
            // 
            // pathTb
            // 
            this.pathTb.Location = new System.Drawing.Point(58, 10);
            this.pathTb.Name = "pathTb";
            this.pathTb.Size = new System.Drawing.Size(350, 20);
            this.pathTb.TabIndex = 1;
            // 
            // buttonFlowLayoutPanel
            // 
            this.buttonFlowLayoutPanel.Location = new System.Drawing.Point(16, 42);
            this.buttonFlowLayoutPanel.Name = "buttonFlowLayoutPanel";
            this.buttonFlowLayoutPanel.Size = new System.Drawing.Size(392, 396);
            this.buttonFlowLayoutPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "GetFiles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLayoutPanel
            // 
            this.textBoxLayoutPanel.Location = new System.Drawing.Point(425, 42);
            this.textBoxLayoutPanel.Name = "textBoxLayoutPanel";
            this.textBoxLayoutPanel.Size = new System.Drawing.Size(363, 371);
            this.textBoxLayoutPanel.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxLayoutPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFlowLayoutPanel);
            this.Controls.Add(this.pathTb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Things";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel textBoxLayoutPanel;
        private System.Windows.Forms.Button button2;
    }
}

