namespace MMihaiPerfect
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
            this.components = new System.ComponentModel.Container();
            this.bazaDateMihaiDataSet = new MMihaiPerfect.BazaDateMihaiDataSet();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientiTableAdapter = new MMihaiPerfect.BazaDateMihaiDataSetTableAdapters.PacientiTableAdapter();
            this.tableAdapterManager = new MMihaiPerfect.BazaDateMihaiDataSetTableAdapters.TableAdapterManager();
            this.salveazaButton = new System.Windows.Forms.Button();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pacientiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiografiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radiografiiTableAdapter = new MMihaiPerfect.BazaDateMihaiDataSetTableAdapters.RadiografiiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cautareTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateMihaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bazaDateMihaiDataSet
            // 
            this.bazaDateMihaiDataSet.DataSetName = "BazaDateMihaiDataSet";
            this.bazaDateMihaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.bazaDateMihaiDataSet;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientiTableAdapter = this.pacientiTableAdapter;
            this.tableAdapterManager.RadiografiiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MMihaiPerfect.BazaDateMihaiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salveazaButton
            // 
            this.salveazaButton.Location = new System.Drawing.Point(16, 410);
            this.salveazaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salveazaButton.Name = "salveazaButton";
            this.salveazaButton.Size = new System.Drawing.Size(173, 28);
            this.salveazaButton.TabIndex = 2;
            this.salveazaButton.Text = "Salveaza modificari";
            this.salveazaButton.UseVisualStyleBackColor = true;
            this.salveazaButton.Click += new System.EventHandler(this.salveazaButton_Click);
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(303, 410);
            this.adaugaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(173, 28);
            this.adaugaButton.TabIndex = 3;
            this.adaugaButton.Text = "Adauga radiogrfie";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(484, 22);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 416);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(705, 347);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(360, 90);
            this.textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(705, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 313);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 431);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pacientiDataGridView
            // 
            this.pacientiDataGridView.AutoGenerateColumns = false;
            this.pacientiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pacientiDataGridView.DataSource = this.pacientiBindingSource;
            this.pacientiDataGridView.Location = new System.Drawing.Point(16, 71);
            this.pacientiDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pacientiDataGridView.Name = "pacientiDataGridView";
            this.pacientiDataGridView.Size = new System.Drawing.Size(460, 331);
            this.pacientiDataGridView.TabIndex = 6;
            this.pacientiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientiDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // radiografiiBindingSource
            // 
            this.radiografiiBindingSource.DataMember = "Radiografii";
            this.radiografiiBindingSource.DataSource = this.bazaDateMihaiDataSet;
            // 
            // radiografiiTableAdapter
            // 
            this.radiografiiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cautare dupa nume";
            // 
            // cautareTextBox
            // 
            this.cautareTextBox.Location = new System.Drawing.Point(157, 22);
            this.cautareTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cautareTextBox.Name = "cautareTextBox";
            this.cautareTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cautareTextBox.Size = new System.Drawing.Size(317, 22);
            this.cautareTextBox.TabIndex = 8;
            this.cautareTextBox.TextChanged += new System.EventHandler(this.cautareTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 458);
            this.Controls.Add(this.cautareTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pacientiDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.salveazaButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateMihaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaDateMihaiDataSet bazaDateMihaiDataSet;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private BazaDateMihaiDataSetTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private BazaDateMihaiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button salveazaButton;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView pacientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource radiografiiBindingSource;
        private BazaDateMihaiDataSetTableAdapters.RadiografiiTableAdapter radiografiiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cautareTextBox;
    }
}

