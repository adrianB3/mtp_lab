namespace lab2_agenda
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.inputPersGB = new System.Windows.Forms.GroupBox();
            this.adaugaPersoana = new System.Windows.Forms.Button();
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cautareGroupBox = new System.Windows.Forms.GroupBox();
            this.cautareButton = new System.Windows.Forms.Button();
            this.cautareNume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.salveazaFisier = new System.Windows.Forms.Button();
            this.stergeButton = new System.Windows.Forms.Button();
            this.inputPersGB.SuspendLayout();
            this.cautareGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPersGB
            // 
            this.inputPersGB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputPersGB.Controls.Add(this.adaugaPersoana);
            this.inputPersGB.Controls.Add(this.categorieComboBox);
            this.inputPersGB.Controls.Add(this.label5);
            this.inputPersGB.Controls.Add(this.adresaTextBox);
            this.inputPersGB.Controls.Add(this.label4);
            this.inputPersGB.Controls.Add(this.telefonTextBox);
            this.inputPersGB.Controls.Add(this.label3);
            this.inputPersGB.Controls.Add(this.dateTimePicker1);
            this.inputPersGB.Controls.Add(this.label2);
            this.inputPersGB.Controls.Add(this.numeTextBox);
            this.inputPersGB.Controls.Add(this.label1);
            this.inputPersGB.Location = new System.Drawing.Point(13, 13);
            this.inputPersGB.Name = "inputPersGB";
            this.inputPersGB.Size = new System.Drawing.Size(299, 216);
            this.inputPersGB.TabIndex = 0;
            this.inputPersGB.TabStop = false;
            this.inputPersGB.Text = "Inserare Persoana";
            // 
            // adaugaPersoana
            // 
            this.adaugaPersoana.Location = new System.Drawing.Point(82, 152);
            this.adaugaPersoana.Name = "adaugaPersoana";
            this.adaugaPersoana.Size = new System.Drawing.Size(200, 47);
            this.adaugaPersoana.TabIndex = 10;
            this.adaugaPersoana.Text = "Adauga";
            this.adaugaPersoana.UseVisualStyleBackColor = true;
            this.adaugaPersoana.Click += new System.EventHandler(this.adaugaPersoana_Click);
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Items.AddRange(new object[] {
            "Prieteni",
            "Colegi",
            "Rude",
            "Diversi"});
            this.categorieComboBox.Location = new System.Drawing.Point(82, 124);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(200, 21);
            this.categorieComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categorie";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(82, 97);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresaTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adresa";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(82, 69);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Nasterii";
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(82, 17);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // cautareGroupBox
            // 
            this.cautareGroupBox.Controls.Add(this.cautareButton);
            this.cautareGroupBox.Controls.Add(this.cautareNume);
            this.cautareGroupBox.Controls.Add(this.label6);
            this.cautareGroupBox.Location = new System.Drawing.Point(13, 236);
            this.cautareGroupBox.Name = "cautareGroupBox";
            this.cautareGroupBox.Size = new System.Drawing.Size(299, 100);
            this.cautareGroupBox.TabIndex = 1;
            this.cautareGroupBox.TabStop = false;
            this.cautareGroupBox.Text = "Cautare";
            // 
            // cautareButton
            // 
            this.cautareButton.Location = new System.Drawing.Point(207, 50);
            this.cautareButton.Name = "cautareButton";
            this.cautareButton.Size = new System.Drawing.Size(75, 23);
            this.cautareButton.TabIndex = 4;
            this.cautareButton.Text = "Cauta";
            this.cautareButton.UseVisualStyleBackColor = true;
            this.cautareButton.Click += new System.EventHandler(this.cautareButton_Click);
            // 
            // cautareNume
            // 
            this.cautareNume.Location = new System.Drawing.Point(82, 24);
            this.cautareNume.Name = "cautareNume";
            this.cautareNume.Size = new System.Drawing.Size(200, 20);
            this.cautareNume.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nume";
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList1;
            this.treeView.Location = new System.Drawing.Point(13, 342);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(299, 233);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "colegi.png");
            this.imageList1.Images.SetKeyName(1, "diversi.png");
            this.imageList1.Images.SetKeyName(2, "folder.png");
            this.imageList1.Images.SetKeyName(3, "prieteni.png");
            this.imageList1.Images.SetKeyName(4, "rude.png");
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(342, 13);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(446, 562);
            this.propertyGrid.TabIndex = 3;
            // 
            // salveazaFisier
            // 
            this.salveazaFisier.Location = new System.Drawing.Point(220, 581);
            this.salveazaFisier.Name = "salveazaFisier";
            this.salveazaFisier.Size = new System.Drawing.Size(92, 23);
            this.salveazaFisier.TabIndex = 5;
            this.salveazaFisier.Text = "Salveaza Fisier";
            this.salveazaFisier.UseVisualStyleBackColor = true;
            this.salveazaFisier.Click += new System.EventHandler(this.salveazaFisier_Click);
            // 
            // stergeButton
            // 
            this.stergeButton.Location = new System.Drawing.Point(716, 581);
            this.stergeButton.Name = "stergeButton";
            this.stergeButton.Size = new System.Drawing.Size(75, 23);
            this.stergeButton.TabIndex = 6;
            this.stergeButton.Text = "Sterge";
            this.stergeButton.UseVisualStyleBackColor = true;
            this.stergeButton.Click += new System.EventHandler(this.stergeButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.stergeButton);
            this.Controls.Add(this.salveazaFisier);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.cautareGroupBox);
            this.Controls.Add(this.inputPersGB);
            this.Name = "mainWindow";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.inputPersGB.ResumeLayout(false);
            this.inputPersGB.PerformLayout();
            this.cautareGroupBox.ResumeLayout(false);
            this.cautareGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputPersGB;
        private System.Windows.Forms.Button adaugaPersoana;
        private System.Windows.Forms.ComboBox categorieComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox cautareGroupBox;
        private System.Windows.Forms.Button cautareButton;
        private System.Windows.Forms.TextBox cautareNume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button salveazaFisier;
        private System.Windows.Forms.Button stergeButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}

