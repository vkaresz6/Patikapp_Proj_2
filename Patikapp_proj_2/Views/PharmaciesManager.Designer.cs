namespace Patikapp_proj_2.Views
{
    partial class PharmaciesManager
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
            this.labelName = new System.Windows.Forms.Label();
            this.NameCombobox = new System.Windows.Forms.ComboBox();
            this.pharmaciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vpharmacies_databaseDataSet = new Patikapp_proj_2.vpharmacies_databaseDataSet();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.FacebookLabel = new System.Windows.Forms.Label();
            this.FacebookTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.WebLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.WebTextBox = new System.Windows.Forms.TextBox();
            this.pharmaciesTableAdapter = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.pharmaciesTableAdapter();
            this.application_base_controll_variablesTableAdapter1 = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.application_base_controll_variablesTableAdapter();
            this.ManageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.SeaShell;
            this.labelName.Location = new System.Drawing.Point(342, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 31);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Név";
            // 
            // NameCombobox
            // 
            this.NameCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameCombobox.DataSource = this.pharmaciesBindingSource;
            this.NameCombobox.DisplayMember = "name";
            this.NameCombobox.FormattingEnabled = true;
            this.NameCombobox.Location = new System.Drawing.Point(12, 43);
            this.NameCombobox.Name = "NameCombobox";
            this.NameCombobox.Size = new System.Drawing.Size(776, 21);
            this.NameCombobox.TabIndex = 1;
            this.NameCombobox.ValueMember = "id";
            this.NameCombobox.SelectedIndexChanged += new System.EventHandler(this.NameCombobox_SelectedIndexChanged);
            // 
            // pharmaciesBindingSource
            // 
            this.pharmaciesBindingSource.DataMember = "pharmacies";
            this.pharmaciesBindingSource.DataSource = this.vpharmacies_databaseDataSet;
            // 
            // vpharmacies_databaseDataSet
            // 
            this.vpharmacies_databaseDataSet.DataSetName = "vpharmacies_databaseDataSet";
            this.vpharmacies_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressTextBox.Location = new System.Drawing.Point(12, 107);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(776, 20);
            this.AdressTextBox.TabIndex = 2;
            // 
            // labelAdress
            // 
            this.labelAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdress.ForeColor = System.Drawing.Color.SeaShell;
            this.labelAdress.Location = new System.Drawing.Point(342, 73);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(65, 31);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "Cím";
            // 
            // FacebookLabel
            // 
            this.FacebookLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacebookLabel.AutoSize = true;
            this.FacebookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FacebookLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.FacebookLabel.Location = new System.Drawing.Point(305, 198);
            this.FacebookLabel.Name = "FacebookLabel";
            this.FacebookLabel.Size = new System.Drawing.Size(142, 31);
            this.FacebookLabel.TabIndex = 7;
            this.FacebookLabel.Text = "Facebook";
            // 
            // FacebookTextBox
            // 
            this.FacebookTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FacebookTextBox.Location = new System.Drawing.Point(12, 232);
            this.FacebookTextBox.Name = "FacebookTextBox";
            this.FacebookTextBox.Size = new System.Drawing.Size(776, 20);
            this.FacebookTextBox.TabIndex = 6;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.PhoneLabel.Location = new System.Drawing.Point(289, 134);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(181, 31);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "Telefonszám";
            // 
            // WebLabel
            // 
            this.WebLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebLabel.AutoSize = true;
            this.WebLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WebLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.WebLabel.Location = new System.Drawing.Point(313, 261);
            this.WebLabel.Name = "WebLabel";
            this.WebLabel.Size = new System.Drawing.Size(134, 31);
            this.WebLabel.TabIndex = 8;
            this.WebLabel.Text = "Weboldal";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(12, 175);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(776, 20);
            this.PhoneTextBox.TabIndex = 9;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // WebTextBox
            // 
            this.WebTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WebTextBox.Location = new System.Drawing.Point(12, 295);
            this.WebTextBox.Name = "WebTextBox";
            this.WebTextBox.Size = new System.Drawing.Size(776, 20);
            this.WebTextBox.TabIndex = 10;
            // 
            // pharmaciesTableAdapter
            // 
            this.pharmaciesTableAdapter.ClearBeforeFill = true;
            // 
            // application_base_controll_variablesTableAdapter1
            // 
            this.application_base_controll_variablesTableAdapter1.ClearBeforeFill = true;
            // 
            // ManageButton
            // 
            this.ManageButton.Location = new System.Drawing.Point(253, 335);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(267, 35);
            this.ManageButton.TabIndex = 11;
            this.ManageButton.Text = "Kezelés";
            this.ManageButton.UseVisualStyleBackColor = true;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click_1);
            // 
            // PharmaciesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(796, 382);
            this.Controls.Add(this.ManageButton);
            this.Controls.Add(this.WebTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.WebLabel);
            this.Controls.Add(this.FacebookLabel);
            this.Controls.Add(this.FacebookTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.NameCombobox);
            this.Controls.Add(this.labelName);
            this.Name = "PharmaciesManager";
            this.Text = "PharmaciesManager";
            this.Load += new System.EventHandler(this.PharmaciesManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox NameCombobox;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label FacebookLabel;
        private System.Windows.Forms.TextBox FacebookTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label WebLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox WebTextBox;
        private vpharmacies_databaseDataSet vpharmacies_databaseDataSet;
        private System.Windows.Forms.BindingSource pharmaciesBindingSource;
        private vpharmacies_databaseDataSetTableAdapters.pharmaciesTableAdapter pharmaciesTableAdapter;
        private vpharmacies_databaseDataSetTableAdapters.application_base_controll_variablesTableAdapter application_base_controll_variablesTableAdapter1;
        private System.Windows.Forms.Button ManageButton;
    }
}