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
    public partial class AssociateEmployeeForm : Form, IAssiciateEmployeeForm
    {
        int selectedPharmacyId;
        AssociatePresenter presenter;
        public AssociateEmployeeForm(int pid)
        {
            InitializeComponent();
            selectedPharmacyId = pid;
            presenter = new AssociatePresenter(new AssociateEmployeeRepo(selectedPharmacyId), this);
        }

        private void AssiciateEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.vpharmacies_databaseDataSet.users);
            this.employeeGridView.DataSource = presenter.fillAssociatedGridView();
        }

        public Label TitleLabel1 { get => TitleLabel; set => TitleLabel = value; }
        public DataGridView UsersGridView { get => usersGridView; set => usersGridView = value; }
        public DataGridView employeeGridView { get => employeeGridView1; set => employeeGridView1 = value; }
        public Button AssociateButton1 { get => AssociateButton; set => AssociateButton = value; }
        public Button DissociateButton1 { get => DissociateButton; set => DissociateButton = value; }

        private void employeeGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AssociateButton_Click(object sender, EventArgs e)
        {
            presenter.assoc(Int32.Parse(usersGridView.SelectedCells[0].Value.ToString()));
            this.employeeGridView.DataSource = presenter.fillAssociatedGridView();
        }

        private void DissociateButton_Click(object sender, EventArgs e)
        {
            presenter.dissoc(Int32.Parse(employeeGridView.SelectedCells[0].Value.ToString()));
            this.employeeGridView.DataSource = presenter.fillAssociatedGridView();


        }
    }
}
