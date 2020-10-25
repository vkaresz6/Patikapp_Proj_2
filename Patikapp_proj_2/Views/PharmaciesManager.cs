using Patikapp_proj_2.Presenters;
using Patikapp_proj_2.Repositories;
using Patikapp_proj_2.Resorurces.CustomControlls;
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
    public partial class PharmaciesManager : Form, IPharmaciesManager
    {
        PharmacieManagerPresenter presenter;
        public PharmaciesManager()
        {
            InitializeComponent();
            presenter = new PharmacieManagerPresenter(this, new PharmaciesManagerViewRepo());
        }

        public ComboBox NameCombobox1 { get => NameCombobox; set => NameCombobox = value; }
        public TextBox AdressTextBox1 { get => AdressTextBox; set => AdressTextBox = value; }
        public TextBox FacebookTextBox1 { get => FacebookTextBox; set => FacebookTextBox = value; }
        public TextBox PhoneTextBox1 { get => PhoneTextBox; set => PhoneTextBox = value; }
        public TextBox WebTextBox1 { get => WebTextBox; set => WebTextBox = value; }

        private void PharmaciesManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.pharmacies' table. You can move, or remove it, as needed.
            this.pharmaciesTableAdapter.Fill(this.vpharmacies_databaseDataSet.pharmacies);
            presenter.fillView();
        }

        private void NameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.fillView();
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            Form child = new PharmacyManagerTool(null);
            child.MdiParent = this.ParentForm;
            child.Show();
        }

        private void createpharmacyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
