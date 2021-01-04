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
    public partial class TartozasPatikanak_Patikavalaszto : Form
    {
        public TartozasPatikanak_Patikavalaszto()
        {
            InitializeComponent();
        }

        private void TartozasPatikanak_Patikavalaszto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.pharmacies' table. You can move, or remove it, as needed.
            this.pharmaciesTableAdapter.Fill(this.vpharmacies_databaseDataSet.pharmacies);

        }

        private void pharmacyPickerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form v = new TartozasPatikanak(Int32.Parse(pharmacyPickerGridView.SelectedCells[0].Value.ToString()));
            v.MdiParent = this.MdiParent;
            v.Show();
        }
    }
}
