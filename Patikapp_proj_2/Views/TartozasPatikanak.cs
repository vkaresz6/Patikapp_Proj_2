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
    public partial class TartozasPatikanak : Form
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="pid">pharmacy Id</param>
        public TartozasPatikanak(int pid)
        {
            InitializeComponent();
        }

        private void TartozasPatikanak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.debtphtoph' table. You can move, or remove it, as needed.
            this.debtphtophTableAdapter.Fill(this.vpharmacies_databaseDataSet.debtphtoph);
            // TODO: This line of code loads data into the 'vpharmacies_databaseDataSet.gyogysz' table. You can move, or remove it, as needed.
            this.gyogyszTableAdapter.Fill(this.vpharmacies_databaseDataSet.gyogysz);

        }
    }
}
