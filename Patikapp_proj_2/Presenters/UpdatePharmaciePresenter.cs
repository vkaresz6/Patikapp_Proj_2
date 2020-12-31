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
        public UpdatePharmaciePresenter( IUpdatePharmacyRepo r, IUpdatePharmacy v)
        {
            _r = r;
            _v = v;    
        
        }
    }
}
