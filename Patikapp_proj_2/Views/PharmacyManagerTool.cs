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
    public partial class PharmacyManagerTool : Form
    {
        PharmacyBundle bundle;
        public PharmacyManagerTool()
        {
            InitializeComponent();
        }

        public PharmacyManagerTool(PharmacyBundle param)
        {
            InitializeComponent();
            bundle = param;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
