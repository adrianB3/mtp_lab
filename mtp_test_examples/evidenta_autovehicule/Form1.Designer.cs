namespace evidenta_autovehicule
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
            this.evidenta_autovehiculeDataSet = new evidenta_autovehicule.evidenta_autovehiculeDataSet();
            this.autovehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autovehiculeTableAdapter = new evidenta_autovehicule.evidenta_autovehiculeDataSetTableAdapters.AutovehiculeTableAdapter();
            this.tableAdapterManager = new evidenta_autovehicule.evidenta_autovehiculeDataSetTableAdapters.TableAdapterManager();
            this.expeditiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expeditiiTableAdapter = new evidenta_autovehicule.evidenta_autovehiculeDataSetTableAdapters.ExpeditiiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.evidenta_autovehiculeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expeditiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // evidenta_autovehiculeDataSet
            // 
            this.evidenta_autovehiculeDataSet.DataSetName = "evidenta_autovehiculeDataSet";
            this.evidenta_autovehiculeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autovehiculeBindingSource
            // 
            this.autovehiculeBindingSource.DataMember = "Autovehicule";
            this.autovehiculeBindingSource.DataSource = this.evidenta_autovehiculeDataSet;
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
            this.tableAdapterManager.UpdateOrder = evidenta_autovehicule.evidenta_autovehiculeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // expeditiiBindingSource
            // 
            this.expeditiiBindingSource.DataMember = "Expeditii";
            this.expeditiiBindingSource.DataSource = this.evidenta_autovehiculeDataSet;
            // 
            // expeditiiTableAdapter
            // 
            this.expeditiiTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Name = "Form1";
            this.Text = "Evidenta Autovehicule";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evidenta_autovehiculeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autovehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expeditiiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private evidenta_autovehiculeDataSet evidenta_autovehiculeDataSet;
        private System.Windows.Forms.BindingSource autovehiculeBindingSource;
        private evidenta_autovehiculeDataSetTableAdapters.AutovehiculeTableAdapter autovehiculeTableAdapter;
        private evidenta_autovehiculeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private evidenta_autovehiculeDataSetTableAdapters.ExpeditiiTableAdapter expeditiiTableAdapter;
        private System.Windows.Forms.BindingSource expeditiiBindingSource;
    }
}

