namespace Patikapp_proj_2.Views
{
    partial class TartozasPatikanak_Patikavalaszto
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
            this.pharmacyPickerGridView = new System.Windows.Forms.DataGridView();
            this.vpharmacies_databaseDataSet = new Patikapp_proj_2.vpharmacies_databaseDataSet();
            this.pharmaciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaciesTableAdapter = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.pharmaciesTableAdapter();
            this.pharmaciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyPickerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyPickerGridView
            // 
            this.pharmacyPickerGridView.AutoGenerateColumns = false;
            this.pharmacyPickerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacyPickerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.pharmacyPickerGridView.DataSource = this.pharmaciesBindingSource1;
            this.pharmacyPickerGridView.Location = new System.Drawing.Point(0, 0);
            this.pharmacyPickerGridView.Name = "pharmacyPickerGridView";
            this.pharmacyPickerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pharmacyPickerGridView.Size = new System.Drawing.Size(244, 269);
            this.pharmacyPickerGridView.TabIndex = 0;
            this.pharmacyPickerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pharmacyPickerGridView_CellContentClick);
            // 
            // vpharmacies_databaseDataSet
            // 
            this.vpharmacies_databaseDataSet.DataSetName = "vpharmacies_databaseDataSet";
            this.vpharmacies_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmaciesBindingSource
            // 
            this.pharmaciesBindingSource.DataMember = "pharmacies";
            this.pharmaciesBindingSource.DataSource = this.vpharmacies_databaseDataSet;
            // 
            // pharmaciesTableAdapter
            // 
            this.pharmaciesTableAdapter.ClearBeforeFill = true;
            // 
            // pharmaciesBindingSource1
            // 
            this.pharmaciesBindingSource1.DataMember = "pharmacies";
            this.pharmaciesBindingSource1.DataSource = this.vpharmacies_databaseDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // TartozasPatikanak_Patikavalaszto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(242, 270);
            this.Controls.Add(this.pharmacyPickerGridView);
            this.Name = "TartozasPatikanak_Patikavalaszto";
            this.Text = "TartozasPatikanak_Patikavalaszto";
            this.Load += new System.EventHandler(this.TartozasPatikanak_Patikavalaszto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyPickerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pharmacyPickerGridView;
        private vpharmacies_databaseDataSet vpharmacies_databaseDataSet;
        private System.Windows.Forms.BindingSource pharmaciesBindingSource;
        private vpharmacies_databaseDataSetTableAdapters.pharmaciesTableAdapter pharmaciesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pharmaciesBindingSource1;
    }
}