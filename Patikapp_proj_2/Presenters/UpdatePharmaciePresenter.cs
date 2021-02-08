using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Repositories;
using Patikapp_proj_2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Presenters
{
    class UpdatePharmaciePresenter
    {
        IUpdatePharmacyRepo _r;
        IUpdatePharmacy _v;
        pharmacies selected;
        pharmacies_data selected_data;

        public UpdatePharmaciePresenter( IUpdatePharmacyRepo r, IUpdatePharmacy v, int selected)
        {
            _r = r;
            _v = v;
            _v.NameTextBox1.Text = _r.getPharmacy(selected).name;
            _v.PhoneTextBox1.Text = _r.getPharmacy_data(selected).phone;
            _v.WebTextBox1.Text = _r.getPharmacy_data(selected).website;
            _v.AdressTextBox1.Text = _r.getPharmacy_data(selected).adress;
            _v.FacebookTextBox1.Text = _r.getPharmacy_data(selected).facebook;
            this.selected = _r.getPharmacy(selected);
            selected_data = _r.getPharmacy_data(selected);

        }

        public void SaveChanges()
        {
            _r.updatePharmacy(new pharmacies_data(selected_data.id, selected.id, _v.PhoneTextBox1.Text, "", _v.WebTextBox1.Text, _v.FacebookTextBox1.Text, _v.AdressTextBox1.Text));
            _v.HideClose();

        }
    }

}
