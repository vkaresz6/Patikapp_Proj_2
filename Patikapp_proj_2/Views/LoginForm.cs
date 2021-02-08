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
    public partial class LoginForm : Form
    {
        ILoginRepo _r;
        IMainWindow _mV;
        public LoginForm(MainWindow mV)
        {
            InitializeComponent();
            _r = new LoginRepo();
            _mV = mV;
            _mV.disableAll();
            


        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            if (_r.logIn(username.Text, psw.Text))
            {
                _r.logIn(username.Text, psw.Text);
                MessageBox.Show("Sikeres bejelentkezés!");
                _mV.enableAll();

                
                this.Hide();
                this.Close();

            }
            else
            {
                MessageBox.Show("Hibás flehasználónév vagy jelszó!");
                this.username.Text = "";
                this.psw.Text = "";
            }
        }

        private void psw_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void psw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginBtn_Click(this, new EventArgs());
            }
        }
    }
}
