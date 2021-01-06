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
    public partial class TartozasPatikanak : Form, ITartozasPatikanak
    {
        TartozasPatikanakPresenter presenter;
        int selectedPharmacyId;
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="pid">pharmacy Id</param>
        public TartozasPatikanak(int pid)
        {
            InitializeComponent();
            selectedPharmacyId = pid;
            presenter = new TartozasPatikanakPresenter(this, new TartozasPatikanakRepo(selectedPharmacyId), selectedPharmacyId);
        }

        private void TartozasPatikanak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.debtphtoph' table. You can move, or remove it, as needed.
            this.debtphtophTableAdapter.Fill(this.vpharmacies_databaseDataSet.debtphtoph);
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.gyogysz' table. You can move, or remove it, as needed.
            this.gyogyszTableAdapter.Fill(this.vpharmacies_databaseDataSet.gyogysz);
            presenter.fillDebtGridView();
        }


        public DataGridView GyogyszTorzsGridView { get => gyogyszTorzsGridView; set => gyogyszTorzsGridView = value; }
        public Label PhNameLabel1 { get => PhNameLabel; set => PhNameLabel = value; }
        public TextBox SearchTextBox1 { get => SearchTextBox; set => SearchTextBox = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Button AddButton1 { get => AddButton; set => AddButton = value; }
        public Button RemoveButton1 { get => RemoveButton; set => RemoveButton = value; }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox1.Text.Length >= 3)
            {
                presenter.searchResult(SearchTextBox1.Text); 
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            presenter.deleteDebt();
            presenter.fillDebtGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form v = new TartozasPatikanak_celpatikaValaszto(selectedPharmacyId, Int32.Parse( GyogyszTorzsGridView.SelectedCells[0].Value.ToString()));
            v.MdiParent = this.MdiParent;
            v.Show();
            this.Hide();
            this.Close();
            
        }

        private void TartozasPatikanak_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void TartozasPatikanak_MdiChildActivate(object sender, EventArgs e)
        {

        }
    }
}
