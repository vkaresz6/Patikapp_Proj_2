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
    public partial class TartozasPatikanak_celpatikaValaszto : Form, ITartozasPatikanak_celpatikaValaszto
    {
        int selectedPharmacyId;
        int targetPharmacyId;
        int selectedmed_OEPTTT;
        View parent;
        TartozasPatikanak_celpatikaValaszto_presenter presenter;
        public TartozasPatikanak_celpatikaValaszto(int selectedPharmacyId, int selectedmed_OEPTTT)
        {
            InitializeComponent();
            this.selectedPharmacyId = selectedPharmacyId;
            presenter = new TartozasPatikanak_celpatikaValaszto_presenter(this, new TartozasPatikanak_celpatikaValaszto_Repo());
            this.selectedmed_OEPTTT = selectedmed_OEPTTT;
        }

        public DataGridView pharmaciesDataGridView1 { get => pharmaciesDataGridView; set => pharmaciesDataGridView = value; }
        public TextBox amountTextBox1 { get => amountTextBox; set =>amountTextBox = value; }
        public Button saveButton1 { get => saveButton; set => saveButton = value; }

        private void TartozasPatikanak_celpatikaValaszto_Load(object sender, EventArgs e)
        {
            presenter.fillPharmacies(selectedPharmacyId);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            presenter.addDebt(selectedPharmacyId, Int32.Parse(pharmaciesDataGridView1.SelectedCells[0].Value.ToString()), selectedmed_OEPTTT, Int32.Parse(amountTextBox1.Text));
            this.Hide();
            this.Close();
            Form v = new TartozasPatikanak(selectedPharmacyId);
            v.MdiParent = this.MdiParent;
            v.Show();
        }
    }
}

