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
    public partial class UserManagerView : Form, IUserManagerView
    {
        UserManagerPresenter presenter;
        public UserManagerView()
        {
            InitializeComponent();
            presenter = new UserManagerPresenter(this, new UserManagerRepo());
        }

        private void UserManagerView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.vpharmacies_databaseDataSet.users);

        }


        public DataGridView UserDataGridView1 { get => UserDataGridView; set => UserDataGridView = value; }
        public Button DeleteButtun1 { get => DeleteButtun; set => DeleteButtun = value; }
        public Button DisplayButton1 { get => DisplayButton; set => DisplayButton = value; }
        public Button ResetPsw1 { get => ResetPsw; set => ResetPsw = value; }
        public Label LabelName { get => labelName; set => labelName = value; }
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            presenter.searchForSubStr(TextBox1.Text);
        }

        private void DeleteButtun_Click(object sender, EventArgs e)
        {
            presenter.deleteUser(Int32.Parse(UserDataGridView.SelectedCells[0].Value.ToString()));
        }

        private void ResetPsw_Click(object sender, EventArgs e)
        {
            presenter.resetPsw(Int32.Parse(UserDataGridView.SelectedCells[0].Value.ToString()));

        }

        //private void DisplayButton_Click(object sender, EventArgs e)
        //{
        //    presenter.

        //}
    }
}
