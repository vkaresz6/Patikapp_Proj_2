using Patikapp_proj_2.Repositories;
using Patikapp_proj_2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Presenters
{
    class UserManagerPresenter
    {
        IUserManagerView _v;
        IUserManagerRepo _r;

        public UserManagerPresenter(IUserManagerView v, IUserManagerRepo r)
        {
            _v = v;
            _r = r;
        }

        public void searchForSubStr(String param)
        {
            if (_v.TextBox1.Text.Length > 2)
            {
                _v.UserDataGridView1.DataSource = _r.searchForUsersBySubString(_v.TextBox1.Text);
            }
        }

        public void deleteUser(int id)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törli a felhasználót?", "Figyelem!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _r.deleteUser(Int32.Parse(_v.UserDataGridView1.SelectedCells[0].Value.ToString()));
                _v.UserDataGridView1.Refresh();
            }
            
        }

        public void resetPsw(int userID)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos alaphelyzetbe állítja a jelszót?", "Figyelem!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _r.resetPsw(userID, "1234");
            }
        }
    }
}
