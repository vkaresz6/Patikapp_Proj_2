using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    partial class PharmacyManager_action_picker
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
            this.PharmacyManager_DeleteAction = new System.Windows.Forms.Button();
            this.pharmacyManager_ModifyAction = new System.Windows.Forms.Button();
            this.pharmacyManager_AssociateEmployeeAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Selected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PharmacyManager_DeleteAction
            // 
            this.PharmacyManager_DeleteAction.Location = new System.Drawing.Point(35, 111);
            this.PharmacyManager_DeleteAction.Name = "PharmacyManager_DeleteAction";
            this.PharmacyManager_DeleteAction.Size = new System.Drawing.Size(178, 34);
            this.PharmacyManager_DeleteAction.TabIndex = 0;
            this.PharmacyManager_DeleteAction.Text = "Törlés";
            this.PharmacyManager_DeleteAction.UseVisualStyleBackColor = true;
            this.PharmacyManager_DeleteAction.Click += new System.EventHandler(this.PharmacyManager_DeleteAction_Click);
            // 
            // pharmacyManager_ModifyAction
            // 
            this.pharmacyManager_ModifyAction.Location = new System.Drawing.Point(35, 151);
            this.pharmacyManager_ModifyAction.Name = "pharmacyManager_ModifyAction";
            this.pharmacyManager_ModifyAction.Size = new System.Drawing.Size(178, 34);
            this.pharmacyManager_ModifyAction.TabIndex = 1;
            this.pharmacyManager_ModifyAction.Text = "Módosítás";
            this.pharmacyManager_ModifyAction.UseVisualStyleBackColor = true;
            this.pharmacyManager_ModifyAction.Click += new System.EventHandler(this.pharmacyManager_ModifyAction_Click);
            // 
            // pharmacyManager_AssociateEmployeeAction
            // 
            this.pharmacyManager_AssociateEmployeeAction.Location = new System.Drawing.Point(35, 191);
            this.pharmacyManager_AssociateEmployeeAction.Name = "pharmacyManager_AssociateEmployeeAction";
            this.pharmacyManager_AssociateEmployeeAction.Size = new System.Drawing.Size(178, 34);
            this.pharmacyManager_AssociateEmployeeAction.TabIndex = 3;
            this.pharmacyManager_AssociateEmployeeAction.Text = "Dolgozó hozzárendelése";
            this.pharmacyManager_AssociateEmployeeAction.UseVisualStyleBackColor = true;
            this.pharmacyManager_AssociateEmployeeAction.Click += new System.EventHandler(this.pharmacyManager_AssociateEmployeeAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kijelölt :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Selected
            // 
            this.Selected.AutoSize = true;
            this.Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Selected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Selected.Location = new System.Drawing.Point(61, 64);
            this.Selected.Name = "Selected";
            this.Selected.Size = new System.Drawing.Size(0, 24);
            this.Selected.TabIndex = 5;
            this.Selected.Click += new System.EventHandler(this.Selected_Click);
            // 
            // PharmacyManager_action_picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(250, 236);
            this.Controls.Add(this.Selected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pharmacyManager_AssociateEmployeeAction);
            this.Controls.Add(this.pharmacyManager_ModifyAction);
            this.Controls.Add(this.PharmacyManager_DeleteAction);
            this.Name = "PharmacyManager_action_picker";
            this.Text = "PharmacyManager_action_picker";
            this.Load += new System.EventHandler(this.PharmacyManager_action_picker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PharmacyManager_DeleteAction;
        private System.Windows.Forms.Button pharmacyManager_ModifyAction;
        private System.Windows.Forms.Button pharmacyManager_AssociateEmployeeAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Selected;
    }
}