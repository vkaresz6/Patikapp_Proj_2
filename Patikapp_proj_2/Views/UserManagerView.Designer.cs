namespace Patikapp_proj_2.Views
{
    partial class UserManagerView
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
            this.vpharmacies_databaseDataSet = new Patikapp_proj_2.vpharmacies_databaseDataSet();
            this.vpharmaciesdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.usersTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteButtun = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ResetPsw = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmaciesdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.vpharmaciesdatabaseDataSetBindingSource;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AutoGenerateColumns = false;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.UserDataGridView.DataSource = this.usersBindingSource;
            this.UserDataGridView.Location = new System.Drawing.Point(3, 43);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGridView.Size = new System.Drawing.Size(245, 395);
            this.UserDataGridView.TabIndex = 0;
            // 
            // DeleteButtun
            // 
            this.DeleteButtun.Location = new System.Drawing.Point(254, 357);
            this.DeleteButtun.Name = "DeleteButtun";
            this.DeleteButtun.Size = new System.Drawing.Size(118, 23);
            this.DeleteButtun.TabIndex = 1;
            this.DeleteButtun.Text = "Töröl";
            this.DeleteButtun.UseVisualStyleBackColor = true;
            this.DeleteButtun.Click += new System.EventHandler(this.DeleteButtun_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Enabled = false;
            this.DisplayButton.Location = new System.Drawing.Point(254, 386);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(118, 23);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Megtekint";
            this.DisplayButton.UseVisualStyleBackColor = true;
            // 
            // ResetPsw
            // 
            this.ResetPsw.Location = new System.Drawing.Point(255, 415);
            this.ResetPsw.Name = "ResetPsw";
            this.ResetPsw.Size = new System.Drawing.Size(118, 23);
            this.ResetPsw.TabIndex = 3;
            this.ResetPsw.Text = "Jelszó alaphelyzetbe";
            this.ResetPsw.UseVisualStyleBackColor = true;
            this.ResetPsw.Click += new System.EventHandler(this.ResetPsw_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.SeaShell;
            this.labelName.Location = new System.Drawing.Point(-1, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(92, 24);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Keresés:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.ResetPsw);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.DeleteButtun);
            this.Controls.Add(this.UserDataGridView);
            this.Name = "UserManagerView";
            this.Text = "UserManagerView";
            this.Load += new System.EventHandler(this.UserManagerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmaciesdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource vpharmaciesdatabaseDataSetBindingSource;
        private vpharmacies_databaseDataSet vpharmacies_databaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private vpharmacies_databaseDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.Button DeleteButtun;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ResetPsw;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;
    }
}