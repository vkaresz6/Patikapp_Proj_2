namespace Patikapp_proj_2.Views
{
    partial class TartozasBetegnek
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
            this.UserPickerGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vpharmacies_databaseDataSet = new Patikapp_proj_2.vpharmacies_databaseDataSet();
            this.vpharmaciesdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.usersTableAdapter();
            this.ActiveDebtGridView = new System.Windows.Forms.DataGridView();
            this.gyogyszDataGridView = new System.Windows.Forms.DataGridView();
            this.oEPTTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oEPNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oEPKSZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kISZMENNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyogyszBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddDebt = new System.Windows.Forms.Button();
            this.DeleteDebt = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gyogyszTableAdapter = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.gyogyszTableAdapter();
            this.AmountPicker = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UserPickerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmaciesdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveDebtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyogyszDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyogyszBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPickerGridView
            // 
            this.UserPickerGridView.AutoGenerateColumns = false;
            this.UserPickerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserPickerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.UserPickerGridView.DataSource = this.usersBindingSource;
            this.UserPickerGridView.Location = new System.Drawing.Point(15, 130);
            this.UserPickerGridView.Name = "UserPickerGridView";
            this.UserPickerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserPickerGridView.Size = new System.Drawing.Size(240, 396);
            this.UserPickerGridView.TabIndex = 0;
            this.UserPickerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserPickerGridView_CellContentClick);
            //this.UserPickerGridView.SelectionChanged += new System.EventHandler(this.UserPickerGridView_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.vpharmacies_databaseDataSet;
            // 
            // vpharmacies_databaseDataSet
            // 
            this.vpharmacies_databaseDataSet.DataSetName = "vpharmacies_databaseDataSet";
            this.vpharmacies_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vpharmaciesdatabaseDataSetBindingSource
            // 
            this.vpharmaciesdatabaseDataSetBindingSource.DataSource = this.vpharmacies_databaseDataSet;
            this.vpharmaciesdatabaseDataSetBindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ActiveDebtGridView
            // 
            this.ActiveDebtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveDebtGridView.Location = new System.Drawing.Point(551, 130);
            this.ActiveDebtGridView.Name = "ActiveDebtGridView";
            this.ActiveDebtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActiveDebtGridView.Size = new System.Drawing.Size(240, 396);
            this.ActiveDebtGridView.TabIndex = 1;
            // 
            // gyogyszDataGridView
            // 
            this.gyogyszDataGridView.AutoGenerateColumns = false;
            this.gyogyszDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gyogyszDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oEPTTTDataGridViewTextBoxColumn,
            this.oEPNEVDataGridViewTextBoxColumn,
            this.oEPKSZDataGridViewTextBoxColumn,
            this.kISZMENNYDataGridViewTextBoxColumn});
            this.gyogyszDataGridView.DataSource = this.gyogyszBindingSource;
            this.gyogyszDataGridView.Location = new System.Drawing.Point(277, 130);
            this.gyogyszDataGridView.Name = "gyogyszDataGridView";
            this.gyogyszDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gyogyszDataGridView.Size = new System.Drawing.Size(240, 396);
            this.gyogyszDataGridView.TabIndex = 2;
            this.gyogyszDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gyogyszDataGridView_CellContentClick);
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
            // oEPKSZDataGridViewTextBoxColumn
            // 
            this.oEPKSZDataGridViewTextBoxColumn.DataPropertyName = "OEP_KSZ";
            this.oEPKSZDataGridViewTextBoxColumn.HeaderText = "OEP_KSZ";
            this.oEPKSZDataGridViewTextBoxColumn.Name = "oEPKSZDataGridViewTextBoxColumn";
            // 
            // kISZMENNYDataGridViewTextBoxColumn
            // 
            this.kISZMENNYDataGridViewTextBoxColumn.DataPropertyName = "KISZ_MENNY";
            this.kISZMENNYDataGridViewTextBoxColumn.HeaderText = "KISZ_MENNY";
            this.kISZMENNYDataGridViewTextBoxColumn.Name = "kISZMENNYDataGridViewTextBoxColumn";
            // 
            // gyogyszBindingSource
            // 
            this.gyogyszBindingSource.DataMember = "gyogysz";
            this.gyogyszBindingSource.DataSource = this.vpharmacies_databaseDataSet;
            // 
            // AddDebt
            // 
            this.AddDebt.Location = new System.Drawing.Point(277, 539);
            this.AddDebt.Name = "AddDebt";
            this.AddDebt.Size = new System.Drawing.Size(240, 23);
            this.AddDebt.TabIndex = 3;
            this.AddDebt.Text = ">>";
            this.AddDebt.UseVisualStyleBackColor = true;
            this.AddDebt.Click += new System.EventHandler(this.AddDebt_Click);
            // 
            // DeleteDebt
            // 
            this.DeleteDebt.Location = new System.Drawing.Point(551, 539);
            this.DeleteDebt.Name = "DeleteDebt";
            this.DeleteDebt.Size = new System.Drawing.Size(240, 23);
            this.DeleteDebt.TabIndex = 4;
            this.DeleteDebt.Text = "<<";
            this.DeleteDebt.UseVisualStyleBackColor = true;
            this.DeleteDebt.Click += new System.EventHandler(this.DeleteDebt_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.SeaShell;
            this.labelName.Location = new System.Drawing.Point(230, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(337, 31);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Tartozások betegek felé.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(46, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Felhasználók";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(283, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gyógyszertörzs";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(567, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aktív tartozások";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(273, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Keresés";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gyogyszTableAdapter
            // 
            this.gyogyszTableAdapter.ClearBeforeFill = true;
            // 
            // AmountPicker
            // 
            this.AmountPicker.Location = new System.Drawing.Point(339, 568);
            this.AmountPicker.Name = "AmountPicker";
            this.AmountPicker.Size = new System.Drawing.Size(120, 20);
            this.AmountPicker.TabIndex = 11;
            // 
            // TartozasBetegnek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.AmountPicker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.DeleteDebt);
            this.Controls.Add(this.AddDebt);
            this.Controls.Add(this.gyogyszDataGridView);
            this.Controls.Add(this.ActiveDebtGridView);
            this.Controls.Add(this.UserPickerGridView);
            this.Name = "TartozasBetegnek";
            this.Text = " ";
            this.Load += new System.EventHandler(this.TartozasBetegnek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPickerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmaciesdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveDebtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyogyszDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyogyszBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserPickerGridView;
        private System.Windows.Forms.BindingSource vpharmaciesdatabaseDataSetBindingSource;
        private vpharmacies_databaseDataSet vpharmacies_databaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private vpharmacies_databaseDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ActiveDebtGridView;
        private System.Windows.Forms.DataGridView gyogyszDataGridView;
        private System.Windows.Forms.Button AddDebt;
        private System.Windows.Forms.Button DeleteDebt;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource gyogyszBindingSource;
        private vpharmacies_databaseDataSetTableAdapters.gyogyszTableAdapter gyogyszTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oEPTTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oEPNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oEPKSZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kISZMENNYDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown AmountPicker;
    }
}