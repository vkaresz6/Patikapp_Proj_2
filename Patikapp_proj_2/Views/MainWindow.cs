using Patikapp_proj_2.Interfaces.ViewInterfaces;
using Patikapp_proj_2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public partial class MainWindow : Form, IMainWindow
    {
        private int childFormNumber = 0;

        public int pharmacy_Id;
        public String pharmacyName;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void enableAll()
        {
            this.tartozásokToolStripMenuItem.Enabled = true;
            this.eszközökToolStripMenuItem.Enabled = true;
            this.kilépésToolStripMenuItem.Enabled = true;
            this.fileMenu.Enabled = true;
        }

        public void disableAll()
        {
            this.tartozásokToolStripMenuItem.Enabled = false;
            this.eszközökToolStripMenuItem.Enabled = false;
            this.kilépésToolStripMenuItem.Enabled = false;
            this.fileMenu.Enabled = false;
        }

        public void adminFalse()
        {
            felhasználókKezeléseToolStripMenuItem.Enabled = false;
            patikákKezeléseToolStripMenuItem1.Enabled = false;
        }



        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void patikákKezeléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new PharmaciesManager();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            SchedulerRepo r = new SchedulerRepo();
            //indítsd el a Timereket



            Form childForm = new LoginForm(this);
            childForm.MdiParent = this;
            childForm.Show();

        }

        private void patikánakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new TartozasPatikanak_Patikavalaszto();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void betegnekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form v = new TartozasBetegnekForraspatikaValaszto();
            v.MdiParent = this;
            v.Show();
        }

        private void tennivalókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form v = new SchedulerFormPharmacypicker();
            v.MdiParent = this;
            v.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Dispose();
        }

        private void patikákKezeléseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new PharmaciesManager();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void felhasználókKezeléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new UserManagerView();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new ChatForm();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
