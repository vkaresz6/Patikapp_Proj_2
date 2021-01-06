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
    public partial class TartozasBetegnek : Form, ITartozasBetegnek
    {
        int selectedPid;
        String dialogbox_txtresult;
        TartozasBEtegnekPresenter presenter;
        public TartozasBetegnek(int selectedPid)
        {
            
            InitializeComponent();
            this.selectedPid = selectedPid;
            presenter  = new TartozasBEtegnekPresenter(this, new TartozasBetegnekRepo(selectedPid));
        }

        private void TartozasBetegnek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.gyogysz' table. You can move, or remove it, as needed.
            this.gyogyszTableAdapter.Fill(this.vpharmacies_databaseDataSet.gyogysz);
            this.usersTableAdapter.Fill(this.vpharmacies_databaseDataSet.users);
            presenter.fillActiveDebtGridView();

        }


        public DataGridView UserPickerGridView1 { get => UserPickerGridView; set => UserPickerGridView = value; }
        public BindingSource UsersBindingSource { get => usersBindingSource; set => usersBindingSource = value; }
        public DataGridView ActiveDebtGridView1 { get => ActiveDebtGridView; set => ActiveDebtGridView = value; }
        public DataGridView GyogyszDataGridView { get => gyogyszDataGridView; set => gyogyszDataGridView = value; }
        public Button AddDebt1 { get => AddDebt; set => AddDebt = value; }
        public Button DeleteDebt1 { get => DeleteDebt; set => DeleteDebt = value; }
        public NumericUpDown AmountPicker1 { get => AmountPicker; set => AmountPicker = value; }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3)
            {

            }
        }

        private void gyogyszDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddDebt_Click(object sender, EventArgs e)
        {
            presenter.addDebt(Int32.Parse(gyogyszDataGridView.SelectedCells[0].Value.ToString()));

        }

        private void DeleteDebt_Click(object sender, EventArgs e)
        {
            presenter.deleteDebt();
        }

        private void UserPickerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void UserPickerGridView_SelectionChanged(object sender, EventArgs e)
        {
            ActiveDebtGridView1.DataSource = 
        }
    }
}
