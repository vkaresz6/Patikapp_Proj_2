using Patikapp_proj_2.Modells.ViewModells;
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
    public partial class DisplayUser : Form
    {
        public DisplayUserModell param;
        public DisplayUser(DisplayUserModell param)
        {
            InitializeComponent();
            this.param = param;
        }

        


        private void DisplayUser_Load(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine + "Felhasználó : " + param.user.username;
            richTextBox1.Text += Environment.NewLine + "cím" + param.user_data.Adress;
            richTextBox1.Text += Environment.NewLine + "Email" + param.user_data.Email;
            richTextBox1.Text += Environment.NewLine + "Telegon" + param.user_data.Phone;
            richTextBox1.Text += Environment.NewLine + "Taj" + param.user_data.TAJ;
            
        }
    }
}
