using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Interfaces.ViewInterfaces
{
    public partial class ChatForm : Form, IChatForm
    {
        chatPresenter presenter;
        public ChatForm()
        {
            InitializeComponent();
            presenter = new chatPresenter(this, new Repositories.chatRepo());
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.vpharmacies_databaseDataSet.users);
            timer1.Start();
        }
        public TextBox chatBox { get => textBox1; set => textBox1 = value; }
        public TextBox msgBox { get => textBox2; set => textBox2 = value; }
        public DataGridView userGridView { get => dataGridView1; set => dataGridView1 = value; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            presenter.refreshChatBox();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                presenter.sendMsg();
                msgBox.Text = "";
               
            }
        }
    }
}

