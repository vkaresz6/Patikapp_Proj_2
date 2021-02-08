using Patikapp_proj_2.Repositories;
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
using Patikapp_proj_2.Repositories;

namespace Patikapp_proj_2.Views
{
    public partial class UpdatePharmacy : Form, IUpdatePharmacy
    {
        int selected;
        UpdatePharmaciePresenter presenter;
        PharmaciesManager phMng;
        public UpdatePharmacy(int selected, PharmaciesManager phMng)
        {
            InitializeComponent();
            this.selected = selected;
            this.phMng = phMng;
        }

        public TextBox WebTextBox1 { get => WebTextBox; set => WebTextBox = value; }
        public TextBox PhoneTextBox1 { get => PhoneTextBox; set => PhoneTextBox = value; }
        public TextBox FacebookTextBox1 { get => FacebookTextBox; set => FacebookTextBox = value; }
        public TextBox AdressTextBox1 { get => AdressTextBox; set => AdressTextBox = value; }
        public Button CreatePharmacyButton1 { get => updateButton; set => updateButton = value; }
        public TextBox NameTextBox1 { get => NameTextBox; set => NameTextBox = value; }

        public void HideClose()
        {
            PharmacieManagerPresenter remotePresenter = new PharmacieManagerPresenter(phMng, new PharmaciesManagerViewRepo());
            remotePresenter.fillView();
            this.Hide();
          this.Close();
            
        }

        private void UpdatePharmacy_Load(object sender, EventArgs e)
        {
            presenter = new UpdatePharmaciePresenter(new Patikapp_proj_2.Repositories.IUpdatePharmacyRepo(), this, selected);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            presenter.SaveChanges();
            PharmaciesManager view = new PharmaciesManager();
            view.MdiParent = this.MdiParent;
            view.Show();

            
        }
    }
}
