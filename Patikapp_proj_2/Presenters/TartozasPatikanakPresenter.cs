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
    class TartozasPatikanakPresenter
    {
        ITartozasPatikanak _v;
        ITartozasPatikanakRepo _r;
        int selectedPid;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="v"></param> view instance
        /// <param name="r"></param> repo instance
        /// <param name="pid">selected Pharmacy Id</param>
        public TartozasPatikanakPresenter(TartozasPatikanak v, TartozasPatikanakRepo r, int pid)
        {
            _v = v;
            _r = r;
            selectedPid = pid;
        }

        public void fillDebtGridView()
        {
            _v.DataGridView1.DataSource = _r.getAllDebt();
        }

        /// <summary>
        /// Searches for record in gyogysz by oep_nev
        /// </summary>
        /// <param name="param">substring to search for</param>
        public void searchResult(String param)
        {
            _v.GyogyszTorzsGridView.DataSource = _r.searchGyogysz(param);
        }

        public void deleteDebt()
        {
            _r.deleteDebt(Int32.Parse(_v.DataGridView1.SelectedCells[5].Value.ToString()));
        }
    }
}
