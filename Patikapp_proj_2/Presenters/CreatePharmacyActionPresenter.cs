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
    class CreatePharmacyActionPresenter
    {
        ICreateNewPharmacyActionRepo _r;
        ICreateNewPharmacyActionForm _v;

        public CreatePharmacyActionPresenter(ICreateNewPharmacyActionRepo r, ICreateNewPharmacyActionForm v)
        {
            _r = r;
            _v = v;
        }

        public void insertAction(pharmacies param1, pharmacies_data param2)
        {
            _r.insert(param1, param2);
        }

        public int getLasttIndex()
        {
            return _r.getLastIndex();
        }
    }
}
