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
    class TartozasPatikanak_celpatikaValaszto_presenter
    {
        ITartozasPatikanak_celpatikaValaszto _v;
        ITartozasPatikanak_celpatikaValaszto_Repo _r;
        int OEP_TTT, amount, selectedPid, targetPid;
        public TartozasPatikanak_celpatikaValaszto_presenter(TartozasPatikanak_celpatikaValaszto v, TartozasPatikanak_celpatikaValaszto_Repo r)
        {
            this.OEP_TTT = OEP_TTT;
            this.selectedPid =  selectedPid;
            _v = v;
            _r = r;
        }

        public void fillPharmacies(int exclusion)
        {
            _v.pharmaciesDataGridView1.DataSource = _r.getAllPharmacyWithException(exclusion);
        }
        /// <summary>
        /// create a debt between pharmacies
        /// </summary>
        /// <param name="param">debt to add</param>
        public void addDebt(int fromphid, int tophId, int amount, int OEP_TTT)
        {
            _r.addDebt(fromphid, tophId, OEP_TTT, amount);
        }
    }
}
