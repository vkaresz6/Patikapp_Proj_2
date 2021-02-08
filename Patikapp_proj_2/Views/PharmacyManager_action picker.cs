using Patikapp_proj_2.Presenters;
using Patikapp_proj_2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public partial class PharmacyManager_action_picker : Form, IPharmacyManager_action_picker
    {
        IPharmaciesManager parentView;
        MainWindow parentForm;
        int selected_pharmacy_id;
        String selected_pharmacy_name;
        pharmacymanager_actionpicker_presenter presenter;
        PharmaciesManager phMng;
        public PharmacyManager_action_picker(int id, String name, PharmaciesManager phMng)
        {
            InitializeComponent();
            selected_pharmacy_id = id;
            selected_pharmacy_name = name;
            presenter = new pharmacymanager_actionpicker_presenter(this, new pharmacymanager_actionpicker_repo());
            this.phMng = phMng;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Selected_Click(object sender, EventArgs e)
        {

        }

        private void PharmacyManager_action_picker_Load(object sender, EventArgs e)
        {
            Selected1.Text = selected_pharmacy_name;
        }
        public Button PharmacyManager_DeleteAction1 { get => PharmacyManager_DeleteAction; set => PharmacyManager_DeleteAction = value; }
        public Button PharmacyManager_ModifyAction { get => pharmacyManager_ModifyAction; set => pharmacyManager_ModifyAction = value; }
        public Button PharmacyManager_createNewAction { get => pharmacyManager_createNewAction; set => pharmacyManager_createNewAction = value; }
        public Button PharmacyManager_AssociateEmployeeAction { get => pharmacyManager_AssociateEmployeeAction; set => pharmacyManager_AssociateEmployeeAction = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Selected1 { get => Selected; set => Selected = value; }

        private void PharmacyManager_DeleteAction_Click(object sender, EventArgs e)
        {
            presenter.delete_action(selected_pharmacy_id);
            this.Close();
            this.Hide();
            
        }

        private void pharmacyManager_createNewAction_Click(object sender, EventArgs e)
        {
            CreateNewPharmacyActionForm v = new CreateNewPharmacyActionForm();
            v.MdiParent = this.MdiParent;
            v.Show();
            this.Hide();
            this.Close();
        }

        private void pharmacyManager_ModifyAction_Click(object sender, EventArgs e)
        {
            UpdatePharmacy v = new UpdatePharmacy(selected_pharmacy_id, phMng);
            v.MdiParent = this.MdiParent;
            v.Show();
            this.Hide();
            this.Close();
        }

        private void pharmacyManager_AssociateEmployeeAction_Click(object sender, EventArgs e)
        {
            AssociateEmployeeForm v = new AssociateEmployeeForm(selected_pharmacy_id);
            v.MdiParent = this.MdiParent;
            v.Show();
            PharmaciesManager view = new PharmaciesManager();
            view.MdiParent = this.MdiParent;
            view.Show();
            this.Hide();
            this.Close();

        }
    }
}
