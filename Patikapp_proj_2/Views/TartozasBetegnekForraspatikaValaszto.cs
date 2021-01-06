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
    public partial class TartozasBetegnekForraspatikaValaszto : Form
    {
        public TartozasBetegnekForraspatikaValaszto()
        {
            InitializeComponent();
        }

        private void TartozasBetegnekForraspatikaValaszto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.pharmacies' table. You can move, or remove it, as needed.
            this.pharmaciesTableAdapter.Fill(this.vpharmacies_databaseDataSet.pharmacies);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TartozasBetegnek v = new TartozasBetegnek(Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
            v.MdiParent = this.MdiParent;
            v.Show();
            this.Hide();
            this.Close();
        }
    }
}
