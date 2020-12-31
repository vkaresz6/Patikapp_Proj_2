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
    public partial class UpdatePharmacy : Form, IUpdatePharmacy
    {
        UpdatePharmacyPresenter presenter;
        public UpdatePharmacy()
        {
            InitializeComponent();
        
        }

        public TextBox WebTextBox1 { get => WebTextBox; set => WebTextBox = value; }
        public TextBox PhoneTextBox1 { get => PhoneTextBox; set => PhoneTextBox = value; }
        public TextBox FacebookTextBox1 { get => FacebookTextBox; set => FacebookTextBox = value; }
        public TextBox AdressTextBox1 { get => AdressTextBox; set => AdressTextBox = value; }
        public Button CreatePharmacyButton1 { get => CreatePharmacyButton; set => CreatePharmacyButton = value; }
        public TextBox NameTextBox1 { get => NameTextBox; set => NameTextBox = value; }
    }
}
