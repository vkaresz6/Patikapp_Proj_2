using Patikapp_proj_2.Modells;
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
    public partial class CreateNewPharmacyActionForm : Form, ICreateNewPharmacyActionForm
    {
        CreatePharmacyActionPresenter presenter;
        public CreateNewPharmacyActionForm()
        {
            InitializeComponent();
            presenter = new CreatePharmacyActionPresenter(new CreateNewPharmacyActionRepo(), this);
        }

        private void CreateNewPharmacyActionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.vpharmacies_databaseDataSet.users);

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public TextBox WebTextBox1 { get => WebTextBox; set => WebTextBox = value; }
        public TextBox PhoneTextBox1 { get => PhoneTextBox; set => PhoneTextBox = value; }
        public TextBox FacebookTextBox1 { get => FacebookTextBox; set => FacebookTextBox = value; }
        public TextBox AdressTextBox1 { get => AdressTextBox; set => AdressTextBox = value; }       
        public BindingSource UsersBindingSource1 { get => usersBindingSource1; set => usersBindingSource1 = value; }
        public Button CreatePharmacyButton1 { get => CreatePharmacyButton; set => CreatePharmacyButton = value; }
        public TextBox NameTextBox1 { get => NameTextBox; set => NameTextBox = value; }

        private void CreatePharmacyButton_Click(object sender, EventArgs e)
        {
            pharmacies param1 = new pharmacies();
            param1.name = NameTextBox.Text;
            param1.id = 0;
            pharmacies_data param2 = new pharmacies_data();
            param2.website = WebTextBox.Text;
            param2.phone = PhoneTextBox.Text;
            param2.facebook = FacebookTextBox.Text;
            param2.adress = AdressTextBox.Text;
            param2.pharmacy_id = presenter.getLasttIndex();
            presenter.insertAction(param1, param2);
        }
    }
}
