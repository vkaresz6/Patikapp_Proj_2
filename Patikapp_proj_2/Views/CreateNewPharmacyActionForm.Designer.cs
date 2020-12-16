namespace Patikapp_proj_2.Views
{
    partial class CreateNewPharmacyActionForm
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
            this.WebTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.WebLabel = new System.Windows.Forms.Label();
            this.FacebookLabel = new System.Windows.Forms.Label();
            this.FacebookTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vpharmaciesdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vpharmacies_databaseDataSet = new Patikapp_proj_2.vpharmacies_databaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Patikapp_proj_2.vpharmacies_databaseDataSetTableAdapters.usersTableAdapter();
            this.CreatePharmacyButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmaciesdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WebTextBox
            // 
            this.WebTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebTextBox.Location = new System.Drawing.Point(11, 295);
            this.WebTextBox.Name = "WebTextBox";
            this.WebTextBox.Size = new System.Drawing.Size(740, 20);
            this.WebTextBox.TabIndex = 21;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(11, 175);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(740, 20);
            this.PhoneTextBox.TabIndex = 20;
            // 
            // WebLabel
            // 
            this.WebLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebLabel.AutoSize = true;
            this.WebLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WebLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.WebLabel.Location = new System.Drawing.Point(312, 261);
            this.WebLabel.Name = "WebLabel";
            this.WebLabel.Size = new System.Drawing.Size(134, 31);
            this.WebLabel.TabIndex = 19;
            this.WebLabel.Text = "Weboldal";
            // 
            // FacebookLabel
            // 
            this.FacebookLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacebookLabel.AutoSize = true;
            this.FacebookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FacebookLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.FacebookLabel.Location = new System.Drawing.Point(304, 198);
            this.FacebookLabel.Name = "FacebookLabel";
            this.FacebookLabel.Size = new System.Drawing.Size(142, 31);
            this.FacebookLabel.TabIndex = 18;
            this.FacebookLabel.Text = "Facebook";
            // 
            // FacebookTextBox
            // 
            this.FacebookTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacebookTextBox.Location = new System.Drawing.Point(11, 232);
            this.FacebookTextBox.Name = "FacebookTextBox";
            this.FacebookTextBox.Size = new System.Drawing.Size(740, 20);
            this.FacebookTextBox.TabIndex = 17;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.PhoneLabel.Location = new System.Drawing.Point(288, 134);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(181, 31);
            this.PhoneLabel.TabIndex = 16;
            this.PhoneLabel.Text = "Telefonszám";
            // 
            // labelAdress
            // 
            this.labelAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdress.ForeColor = System.Drawing.Color.SeaShell;
            this.labelAdress.Location = new System.Drawing.Point(341, 73);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(65, 31);
            this.labelAdress.TabIndex = 15;
            this.labelAdress.Text = "Cím";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressTextBox.Location = new System.Drawing.Point(11, 107);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(740, 20);
            this.AdressTextBox.TabIndex = 14;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.SeaShell;
            this.labelName.Location = new System.Drawing.Point(341, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 31);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Név";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.vpharmaciesdatabaseDataSetBindingSource;
            // 
            // vpharmaciesdatabaseDataSetBindingSource
            // 
            this.vpharmaciesdatabaseDataSetBindingSource.DataSource = this.vpharmacies_databaseDataSet;
            this.vpharmaciesdatabaseDataSetBindingSource.Position = 0;
            // 
            // vpharmacies_databaseDataSet
            // 
            this.vpharmacies_databaseDataSet.DataSetName = "vpharmacies_databaseDataSet";
            this.vpharmacies_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // CreatePharmacyButton
            // 
            this.CreatePharmacyButton.Location = new System.Drawing.Point(275, 333);
            this.CreatePharmacyButton.Name = "CreatePharmacyButton";
            this.CreatePharmacyButton.Size = new System.Drawing.Size(194, 23);
            this.CreatePharmacyButton.TabIndex = 28;
            this.CreatePharmacyButton.Text = "Létrehoz";
            this.CreatePharmacyButton.UseVisualStyleBackColor = true;
            this.CreatePharmacyButton.Click += new System.EventHandler(this.CreatePharmacyButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(12, 50);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(740, 20);
            this.NameTextBox.TabIndex = 29;
            // 
            // CreateNewPharmacyActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(759, 379);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CreatePharmacyButton);
            this.Controls.Add(this.WebTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.WebLabel);
            this.Controls.Add(this.FacebookLabel);
            this.Controls.Add(this.FacebookTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.labelName);
            this.Name = "CreateNewPharmacyActionForm";
            this.Text = "CreateNewPharmacyActionForm";
            this.Load += new System.EventHandler(this.CreateNewPharmacyActionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmaciesdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpharmacies_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox WebTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label WebLabel;
        private System.Windows.Forms.Label FacebookLabel;
        private System.Windows.Forms.TextBox FacebookTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.BindingSource vpharmaciesdatabaseDataSetBindingSource;
        private vpharmacies_databaseDataSet vpharmacies_databaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private vpharmacies_databaseDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.Button CreatePharmacyButton;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}