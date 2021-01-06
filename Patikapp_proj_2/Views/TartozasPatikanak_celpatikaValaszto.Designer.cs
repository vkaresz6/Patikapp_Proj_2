using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    partial class TartozasPatikanak_celpatikaValaszto
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
            this.PhNameLabel = new System.Windows.Forms.Label();
            this.pharmaciesDataGridView = new System.Windows.Forms.DataGridView();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PhNameLabel
            // 
            this.PhNameLabel.AutoSize = true;
            this.PhNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhNameLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.PhNameLabel.Location = new System.Drawing.Point(23, 22);
            this.PhNameLabel.Name = "PhNameLabel";
            this.PhNameLabel.Size = new System.Drawing.Size(145, 31);
            this.PhNameLabel.TabIndex = 34;
            this.PhNameLabel.Text = "Cél patika";
            // 
            // pharmaciesDataGridView
            // 
            this.pharmaciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmaciesDataGridView.Location = new System.Drawing.Point(12, 68);
            this.pharmaciesDataGridView.Name = "pharmaciesDataGridView";
            this.pharmaciesDataGridView.Size = new System.Drawing.Size(170, 273);
            this.pharmaciesDataGridView.TabIndex = 35;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(12, 347);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(170, 20);
            this.amountTextBox.TabIndex = 36;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 373);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 23);
            this.saveButton.TabIndex = 37;
            this.saveButton.Text = "Mentés";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // TartozasPatikanak_celpatikaValaszto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(195, 411);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.pharmaciesDataGridView);
            this.Controls.Add(this.PhNameLabel);
            this.Name = "TartozasPatikanak_celpatikaValaszto";
            this.Text = "TartozasPatikanak_celpatikaValaszto";
            this.Load += new System.EventHandler(this.TartozasPatikanak_celpatikaValaszto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhNameLabel;
        private System.Windows.Forms.DataGridView pharmaciesDataGridView;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button saveButton;

        
    }
}