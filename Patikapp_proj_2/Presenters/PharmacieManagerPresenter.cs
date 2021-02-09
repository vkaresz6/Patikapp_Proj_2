using Patikapp_proj_2.Modells.ViewModells;
using Patikapp_proj_2.Repositories;
using Patikapp_proj_2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Presenters
{
    class PharmacieManagerPresenter
    {
        IPharmaciesManager _v;
        IPharmaciesManagerViewRepo _r;
        private PharmaciesManager pharmaciesManager;

        public PharmacieManagerPresenter(IPharmaciesManager param1, IPharmaciesManagerViewRepo param2)
        {
            _v = param1;
            _r = param2;
        }

        public PharmacieManagerPresenter(PharmaciesManager pharmaciesManager)
        {
            this.pharmaciesManager = pharmaciesManager;
        }

        public bool fillView()
        {
            int selectedvalue = Convert.ToInt32(_v.NameCombobox1.SelectedValue);
            if (selectedvalue != 0)
            {
                PharmaciesManagerViewModell vm;
                vm = _r.getViewModell(_r.getPID(_v.NameCombobox1.Text));
                _v.AdressTextBox1.Text = vm.Adress;
                _v.FacebookTextBox1.Text = vm.Facebook;
                _v.PhoneTextBox1.Text = vm.Phone;
                _v.WebTextBox1.Text = vm.Website;
            }
            return true;
                
        }
    }
}
