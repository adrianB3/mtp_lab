namespace magazin_electrocasnice
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Aparate Frigorifice");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Masini de spalat rufe");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Masini de spalat vase");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Aspiratoare");
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InserareBtn = new System.Windows.Forms.Button();
            this.stocTb = new System.Windows.Forms.TextBox();
            this.pretTb = new System.Windows.Forms.TextBox();
            this.producatorTb = new System.Windows.Forms.TextBox();
            this.categorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsListBox = new System.Windows.Forms.ListBox();
            this.electroDataSet = new magazin_electrocasnice.electroDataSet();
            this.electrocasniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electrocasniceTableAdapter = new magazin_electrocasnice.electroDataSetTableAdapters.ElectrocasniceTableAdapter();
            this.tableAdapterManager = new magazin_electrocasnice.electroDataSetTableAdapters.TableAdapterManager();
            this.stergereBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electrocasniceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(13, 13);
            this.treeView.Name = "treeView";
            treeNode1.Name = "apFrigo";
            treeNode1.Text = "Aparate Frigorifice";
            treeNode2.Name = "masRufe";
            treeNode2.Text = "Masini de spalat rufe";
            treeNode3.Name = "masVase";
            treeNode3.Text = "Masini de spalat vase";
            treeNode4.Name = "aspiratoare";
            treeNode4.Text = "Aspiratoare";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView.Size = new System.Drawing.Size(252, 425);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stergereBtn);
            this.groupBox1.Controls.Add(this.InserareBtn);
            this.groupBox1.Controls.Add(this.stocTb);
            this.groupBox1.Controls.Add(this.pretTb);
            this.groupBox1.Controls.Add(this.producatorTb);
            this.groupBox1.Controls.Add(this.categorie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(271, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserare";
            // 
            // InserareBtn
            // 
            this.InserareBtn.Location = new System.Drawing.Point(209, 177);
            this.InserareBtn.Name = "InserareBtn";
            this.InserareBtn.Size = new System.Drawing.Size(75, 23);
            this.InserareBtn.TabIndex = 8;
            this.InserareBtn.Text = "Inserare";
            this.InserareBtn.UseVisualStyleBackColor = true;
            this.InserareBtn.Click += new System.EventHandler(this.InserareBtn_Click);
            // 
            // stocTb
            // 
            this.stocTb.Location = new System.Drawing.Point(71, 97);
            this.stocTb.Name = "stocTb";
            this.stocTb.Size = new System.Drawing.Size(71, 20);
            this.stocTb.TabIndex = 7;
            // 
            // pretTb
            // 
            this.pretTb.Location = new System.Drawing.Point(71, 69);
            this.pretTb.Name = "pretTb";
            this.pretTb.Size = new System.Drawing.Size(72, 20);
            this.pretTb.TabIndex = 6;
            // 
            // producatorTb
            // 
            this.producatorTb.Location = new System.Drawing.Point(71, 40);
            this.producatorTb.Name = "producatorTb";
            this.producatorTb.Size = new System.Drawing.Size(213, 20);
            this.producatorTb.TabIndex = 5;
            // 
            // categorie
            // 
            this.categorie.FormattingEnabled = true;
            this.categorie.Items.AddRange(new object[] {
            "Aparat frigorific",
            "Masina de spalat rufe",
            "Masina de spalat vase",
            "Aspirator"});
            this.categorie.Location = new System.Drawing.Point(71, 13);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(213, 21);
            this.categorie.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stoc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie";
            // 
            // detailsListBox
            // 
            this.detailsListBox.FormattingEnabled = true;
            this.detailsListBox.Location = new System.Drawing.Point(271, 226);
            this.detailsListBox.Name = "detailsListBox";
            this.detailsListBox.Size = new System.Drawing.Size(290, 212);
            this.detailsListBox.TabIndex = 2;
            // 
            // electroDataSet
            // 
            this.electroDataSet.DataSetName = "electroDataSet";
            this.electroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // electrocasniceBindingSource
            // 
            this.electrocasniceBindingSource.DataMember = "Electrocasnice";
            this.electrocasniceBindingSource.DataSource = this.electroDataSet;
            // 
            // electrocasniceTableAdapter
            // 
            this.electrocasniceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ElectrocasniceTableAdapter = this.electrocasniceTableAdapter;
            this.tableAdapterManager.UpdateOrder = magazin_electrocasnice.electroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stergereBtn
            // 
            this.stergereBtn.Location = new System.Drawing.Point(9, 178);
            this.stergereBtn.Name = "stergereBtn";
            this.stergereBtn.Size = new System.Drawing.Size(75, 23);
            this.stergereBtn.TabIndex = 9;
            this.stergereBtn.Text = "Stergere";
            this.stergereBtn.UseVisualStyleBackColor = true;
            this.stergereBtn.Click += new System.EventHandler(this.stergereBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 444);
            this.Controls.Add(this.detailsListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Magazin Electrocasnice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electrocasniceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox detailsListBox;
        private System.Windows.Forms.TextBox stocTb;
        private System.Windows.Forms.TextBox pretTb;
        private System.Windows.Forms.TextBox producatorTb;
        private System.Windows.Forms.ComboBox categorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InserareBtn;
        private electroDataSet electroDataSet;
        private System.Windows.Forms.BindingSource electrocasniceBindingSource;
        private electroDataSetTableAdapters.ElectrocasniceTableAdapter electrocasniceTableAdapter;
        private electroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button stergereBtn;
    }
}

