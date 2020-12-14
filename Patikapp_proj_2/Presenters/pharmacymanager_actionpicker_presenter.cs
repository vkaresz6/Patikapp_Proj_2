using Patikapp_proj_2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patikapp_proj_2.Repositories;
namespace Patikapp_proj_2.Presenters
{
    class pharmacymanager_actionpicker_presenter
    {
        IPharmacyManager_action_picker _v;
        Ipharmacymanager_actionpicker_repo _r;

        public pharmacymanager_actionpicker_presenter(IPharmacyManager_action_picker v, Ipharmacymanager_actionpicker_repo r)
        {
            _v = v;
            _r = r;
        }

        public void delete_action(int id)
        {
            _r.delete(id);
           
        }
    }
}
