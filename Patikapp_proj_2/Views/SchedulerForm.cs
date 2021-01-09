using Patikapp_proj_2.Modells;
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
    public partial class Schedulerform : Form, ISchedulerform
    {
        SchedulerPresenter presenter;
        int pid;
        public Schedulerform(int pid)
        {
            InitializeComponent();
            this.pid = pid;
            presenter = new SchedulerPresenter(new SchedulerRepo(), this, pid);
        }

        public DataGridView DataGridView1 { get => todoGridView; set => todoGridView = value; }
        public Button AddButton { get => addButton; set => addButton = value; }
        public Button DeleteButton1 { get => deleteButton; set => deleteButton = value; }
        public TextBox Hh { get => hh; set => hh = value; }
        public TextBox Mm { get => mm; set => mm = value; }
        public DateTimePicker Exp { get => exp; set => exp = value; }
        public RichTextBox RichTextBox2 { get => richTextBox2; set => richTextBox2 = value; }

        private void Schedulerform_Load(object sender, EventArgs e)
        {
            presenter.fillGridViewByPid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            presenter.AddTodo();
            presenter.fillGridViewByPid();
        }
    }
}
