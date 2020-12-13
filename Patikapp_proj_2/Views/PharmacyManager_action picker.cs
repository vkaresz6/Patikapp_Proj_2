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
    public partial class PharmacyManager_action_picker : Form
    {
        IPharmaciesManager parentView;


        public PharmacyManager_action_picker()
        {
            InitializeComponent();
            parentView = new PharmaciesManager();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Selected_Click(object sender, EventArgs e)
        {

        }

        private void PharmacyManager_action_picker_Load(object sender, EventArgs e)
        {
            Selected.Text = parentView.getName(); 
        }
    }
}
