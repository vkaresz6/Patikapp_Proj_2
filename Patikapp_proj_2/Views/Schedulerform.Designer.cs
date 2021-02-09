namespace Patikapp_proj_2.Views
{
    partial class Schedulerform
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
            this.todoGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.hh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mm = new System.Windows.Forms.TextBox();
            this.exp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.vpharmacies_databaseDataSet = new Patikapp_proj_2.vpharmacies_databaseDataSet();
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoTableAdapter = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.todoTableAdapter();
            this.todoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.todoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // todoGridView
            // 
            this.todoGridView.AutoGenerateColumns = false;
            this.todoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.todoDataGridViewTextBoxColumn});
            this.todoGridView.DataSource = this.todoBindingSource;
            this.todoGridView.Location = new System.Drawing.Point(12, 12);
            this.todoGridView.Name = "todoGridView";
            this.todoGridView.Size = new System.Drawing.Size(590, 389);
            this.todoGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(713, 407);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Hozzáad";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(527, 407);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Töröl";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(608, 44);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(180, 168);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.SeaShell;
            this.labelName.Location = new System.Drawing.Point(641, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(112, 31);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Feladat";
            // 
            // hh
            // 
            this.hh.Location = new System.Drawing.Point(606, 251);
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(180, 20);
            this.hh.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(678, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "hh";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(678, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "mm";
            // 
            // mm
            // 
            this.mm.Location = new System.Drawing.Point(606, 308);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(180, 20);
            this.mm.TabIndex = 16;
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(606, 365);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(180, 20);
            this.exp.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(649, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lejárat";
            // 
            // vpharmacies_databaseDataSet
            // 
            this.vpharmacies_databaseDataSet.DataSetName = "vpharmacies_databaseDataSet";
            this.vpharmacies_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataMember = "todo";
            this.todoBindingSource.DataSource = this.vpharmacies_databaseDataSet;
            // 
            // todoTableAdapter
            // 
            this.todoTableAdapter.ClearBeforeFill = true;
            // 
            // todoDataGridViewTextBoxColumn
            // 
            this.todoDataGridViewTextBoxColumn.DataPropertyName = "todo";
            this.todoDataGridViewTextBoxColumn.HeaderText = "todo";
            this.todoDataGridViewTextBoxColumn.Name = "todoDataGridViewTextBoxColumn";
            // 
            // Schedulerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hh);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.todoGridView);
            this.Name = "Schedulerform";
            this.Text = "Schedulerform";
            this.Load += new System.EventHandler(this.Schedulerform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView todoGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox hh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mm;
        private System.Windows.Forms.DateTimePicker exp;
        private System.Windows.Forms.Label label3;
        private vpharmacies_databaseDataSet vpharmacies_databaseDataSet;
        private System.Windows.Forms.BindingSource todoBindingSource;
        private vpharmacies_databaseDataSetTableAdapters.todoTableAdapter todoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoDataGridViewTextBoxColumn;
    }
}