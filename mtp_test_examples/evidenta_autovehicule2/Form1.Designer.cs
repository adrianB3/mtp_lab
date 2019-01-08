namespace evidenta_autovehicule2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.autovehiculeDataSet = new evidenta_autovehicule2.autovehiculeDataSet();
            this.autovehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autovehiculeTableAdapter = new evidenta_autovehicule2.autovehiculeDataSetTableAdapters.AutovehiculeTableAdapter();
            this.tableAdapterManager = new evidenta_autovehicule2.autovehiculeDataSetTableAdapters.TableAdapterManager();
            this.autovehiculeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.autovehiculeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.autovehiculeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expeditiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expeditiiTableAdapter = new evidenta_autovehicule2.autovehiculeDataSetTableAdapters.ExpeditiiTableAdapter();
            this.expeditiiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.totalkmlabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeBindingNavigator)).BeginInit();
            this.autovehiculeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expeditiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expeditiiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // autovehiculeDataSet
            // 
            this.autovehiculeDataSet.DataSetName = "autovehiculeDataSet";
            this.autovehiculeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autovehiculeBindingSource
            // 
            this.autovehiculeBindingSource.DataMember = "Autovehicule";
            this.autovehiculeBindingSource.DataSource = this.autovehiculeDataSet;
            // 
            // autovehiculeTableAdapter
            // 
            this.autovehiculeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutovehiculeTableAdapter = this.autovehiculeTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExpeditiiTableAdapter = this.expeditiiTableAdapter;
            this.tableAdapterManager.UpdateOrder = evidenta_autovehicule2.autovehiculeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // autovehiculeBindingNavigator
            // 
            this.autovehiculeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.autovehiculeBindingNavigator.BindingSource = this.autovehiculeBindingSource;
            this.autovehiculeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.autovehiculeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.autovehiculeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.autovehiculeBindingNavigatorSaveItem});
            this.autovehiculeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.autovehiculeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.autovehiculeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.autovehiculeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.autovehiculeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.autovehiculeBindingNavigator.Name = "autovehiculeBindingNavigator";
            this.autovehiculeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.autovehiculeBindingNavigator.Size = new System.Drawing.Size(1029, 25);
            this.autovehiculeBindingNavigator.TabIndex = 0;
            this.autovehiculeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // autovehiculeBindingNavigatorSaveItem
            // 
            this.autovehiculeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autovehiculeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("autovehiculeBindingNavigatorSaveItem.Image")));
            this.autovehiculeBindingNavigatorSaveItem.Name = "autovehiculeBindingNavigatorSaveItem";
            this.autovehiculeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.autovehiculeBindingNavigatorSaveItem.Text = "Save Data";
            this.autovehiculeBindingNavigatorSaveItem.Click += new System.EventHandler(this.autovehiculeBindingNavigatorSaveItem_Click);
            // 
            // autovehiculeDataGridView
            // 
            this.autovehiculeDataGridView.AutoGenerateColumns = false;
            this.autovehiculeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autovehiculeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.autovehiculeDataGridView.DataSource = this.autovehiculeBindingSource;
            this.autovehiculeDataGridView.Location = new System.Drawing.Point(12, 31);
            this.autovehiculeDataGridView.Name = "autovehiculeDataGridView";
            this.autovehiculeDataGridView.Size = new System.Drawing.Size(338, 220);
            this.autovehiculeDataGridView.TabIndex = 1;
            this.autovehiculeDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.autovehiculeDataGridView_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nr_inmatriculare";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nr_inmatriculare";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // expeditiiBindingSource
            // 
            this.expeditiiBindingSource.DataMember = "Id_autovehicul";
            this.expeditiiBindingSource.DataSource = this.autovehiculeBindingSource;
            // 
            // expeditiiTableAdapter
            // 
            this.expeditiiTableAdapter.ClearBeforeFill = true;
            // 
            // expeditiiDataGridView
            // 
            this.expeditiiDataGridView.AutoGenerateColumns = false;
            this.expeditiiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expeditiiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.expeditiiDataGridView.DataSource = this.expeditiiBindingSource;
            this.expeditiiDataGridView.Location = new System.Drawing.Point(356, 31);
            this.expeditiiDataGridView.Name = "expeditiiDataGridView";
            this.expeditiiDataGridView.Size = new System.Drawing.Size(661, 220);
            this.expeditiiDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id_autovehicul";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id_autovehicul";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Distanta";
            this.dataGridViewTextBoxColumn7.HeaderText = "Distanta";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Combustibil";
            this.dataGridViewTextBoxColumn8.HeaderText = "Combustibil";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total kilometrii parcursi: ";
            // 
            // totalkmlabel
            // 
            this.totalkmlabel.AutoSize = true;
            this.totalkmlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.totalkmlabel.Location = new System.Drawing.Point(140, 258);
            this.totalkmlabel.Name = "totalkmlabel";
            this.totalkmlabel.Size = new System.Drawing.Size(13, 13);
            this.totalkmlabel.TabIndex = 4;
            this.totalkmlabel.Text = "0";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(16, 274);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 410);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.totalkmlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expeditiiDataGridView);
            this.Controls.Add(this.autovehiculeDataGridView);
            this.Controls.Add(this.autovehiculeBindingNavigator);
            this.Name = "Form1";
            this.Text = "Evidenta Autovehicule";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeBindingNavigator)).EndInit();
            this.autovehiculeBindingNavigator.ResumeLayout(false);
            this.autovehiculeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expeditiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expeditiiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autovehiculeDataSet autovehiculeDataSet;
        private System.Windows.Forms.BindingSource autovehiculeBindingSource;
        private autovehiculeDataSetTableAdapters.AutovehiculeTableAdapter autovehiculeTableAdapter;
        private autovehiculeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator autovehiculeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton autovehiculeBindingNavigatorSaveItem;
        private autovehiculeDataSetTableAdapters.ExpeditiiTableAdapter expeditiiTableAdapter;
        private System.Windows.Forms.DataGridView autovehiculeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource expeditiiBindingSource;
        private System.Windows.Forms.DataGridView expeditiiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalkmlabel;
        private System.Windows.Forms.Button updateButton;
    }
}

