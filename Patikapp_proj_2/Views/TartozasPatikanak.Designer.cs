namespace Patikapp_proj_2.Views
{
    partial class TartozasPatikanak
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
            this.gyogyszTorzsGridView = new System.Windows.Forms.DataGridView();
            this.vpharmacies_databaseDataSet = new Patikapp_proj_2.vpharmacies_databaseDataSet();
            this.gyogyszBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gyogyszTableAdapter = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.gyogyszTableAdapter();
            this.PhNameLabel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.oEPTTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oEPNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gYFORMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kISZMENNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.debtphtophBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtphtophTableAdapter = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.debtphtophTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gyogyszTorzsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyogyszBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtphtophBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gyogyszTorzsGridView
            // 
            this.gyogyszTorzsGridView.AutoGenerateColumns = false;
            this.gyogyszTorzsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gyogyszTorzsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oEPTTTDataGridViewTextBoxColumn,
            this.oEPNEVDataGridViewTextBoxColumn,
            this.gYFORMADataGridViewTextBoxColumn,
            this.kISZMENNYDataGridViewTextBoxColumn});
            this.gyogyszTorzsGridView.DataSource = this.gyogyszBindingSource;
            this.gyogyszTorzsGridView.Location = new System.Drawing.Point(12, 85);
            this.gyogyszTorzsGridView.Name = "gyogyszTorzsGridView";
            this.gyogyszTorzsGridView.Size = new System.Drawing.Size(443, 353);
            this.gyogyszTorzsGridView.TabIndex = 0;
            // 
            // vpharmacies_databaseDataSet
            // 
            this.vpharmacies_databaseDataSet.DataSetName = "vpharmacies_databaseDataSet";
            this.vpharmacies_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gyogyszBindingSource
            // 
            this.gyogyszBindingSource.DataMember = "gyogysz";
            this.gyogyszBindingSource.DataSource = this.vpharmacies_databaseDataSet;
            // 
            // gyogyszTableAdapter
            // 
            this.gyogyszTableAdapter.ClearBeforeFill = true;
            // 
            // PhNameLabel
            // 
            this.PhNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhNameLabel.AutoSize = true;
            this.PhNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhNameLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.PhNameLabel.Location = new System.Drawing.Point(93, 9);
            this.PhNameLabel.Name = "PhNameLabel";
            this.PhNameLabel.Size = new System.Drawing.Size(219, 31);
            this.PhNameLabel.TabIndex = 33;
            this.PhNameLabel.Text = "Gyógyszertörzs";
            // 
            // Label
            // 
            this.Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label.ForeColor = System.Drawing.Color.SeaShell;
            this.Label.Location = new System.Drawing.Point(-11, 57);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(92, 24);
            this.Label.TabIndex = 34;
            this.Label.Text = "Keresés:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(102, 62);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(353, 20);
            this.SearchTextBox.TabIndex = 35;
            // 
            // oEPTTTDataGridViewTextBoxColumn
            // 
            this.oEPTTTDataGridViewTextBoxColumn.DataPropertyName = "OEP_TTT";
            this.oEPTTTDataGridViewTextBoxColumn.HeaderText = "OEP_TTT";
            this.oEPTTTDataGridViewTextBoxColumn.Name = "oEPTTTDataGridViewTextBoxColumn";
            // 
            // oEPNEVDataGridViewTextBoxColumn
            // 
            this.oEPNEVDataGridViewTextBoxColumn.DataPropertyName = "OEP_NEV";
            this.oEPNEVDataGridViewTextBoxColumn.HeaderText = "OEP_NEV";
            this.oEPNEVDataGridViewTextBoxColumn.Name = "oEPNEVDataGridViewTextBoxColumn";
            // 
            // gYFORMADataGridViewTextBoxColumn
            // 
            this.gYFORMADataGridViewTextBoxColumn.DataPropertyName = "GYFORMA";
            this.gYFORMADataGridViewTextBoxColumn.HeaderText = "GYFORMA";
            this.gYFORMADataGridViewTextBoxColumn.Name = "gYFORMADataGridViewTextBoxColumn";
            // 
            // kISZMENNYDataGridViewTextBoxColumn
            // 
            this.kISZMENNYDataGridViewTextBoxColumn.DataPropertyName = "KISZ_MENNY";
            this.kISZMENNYDataGridViewTextBoxColumn.HeaderText = "KISZ_MENNY";
            this.kISZMENNYDataGridViewTextBoxColumn.Name = "kISZMENNYDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.debtphtophBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(503, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 353);
            this.dataGridView1.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OEP_TTT";
            this.dataGridViewTextBoxColumn1.HeaderText = "OEP_TTT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(578, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "Aktív tartozások";
            // 
            // debtphtophBindingSource
            // 
            this.debtphtophBindingSource.DataMember = "debtphtoph";
            this.debtphtophBindingSource.DataSource = this.vpharmacies_databaseDataSet;
            // 
            // debtphtophTableAdapter
            // 
            this.debtphtophTableAdapter.ClearBeforeFill = true;
            // 
            // TartozasPatikanak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.PhNameLabel);
            this.Controls.Add(this.gyogyszTorzsGridView);
            this.Name = "TartozasPatikanak";
            this.Text = "TartozasPatikanak";
            this.Load += new System.EventHandler(this.TartozasPatikanak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gyogyszTorzsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyogyszBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtphtophBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gyogyszTorzsGridView;
        private vpharmacies_databaseDataSet vpharmacies_databaseDataSet;
        private System.Windows.Forms.BindingSource gyogyszBindingSource;
        private vpharmacies_databaseDataSetTableAdapters.gyogyszTableAdapter gyogyszTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oEPTTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oEPNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gYFORMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kISZMENNYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label PhNameLabel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource debtphtophBindingSource;
        private vpharmacies_databaseDataSetTableAdapters.debtphtophTableAdapter debtphtophTableAdapter;
    }
}