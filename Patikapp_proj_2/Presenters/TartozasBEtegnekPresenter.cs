using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Repositories;
using Patikapp_proj_2.Views;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Presenters
{
    class TartozasBEtegnekPresenter
    {
        ITartozasBetegnek _v;
        ITartozasBetegnekRepo _r;

        public TartozasBEtegnekPresenter(ITartozasBetegnek v, ITartozasBetegnekRepo r)
        {
            _v = v;
            _r = r;
        }
        /// <summary>
        /// Search for substr in db.gyogysz.oepNev
        /// </summary>
        /// <param name="param">substr</param>
        public void SearchForSubstr(string param)
        {
            _v.GyogyszDataGridView.DataSource = _r.searchGyogysz(param);
        }

        public void fillActiveDebtGridView()
        {
            _v.ActiveDebtGridView1.DataSource = _r.getActiveDebtsContent();
        }

        public void addDebt(int OepTTT, int selectedUserId)
        {
            _r.addDebt(OepTTT, Int32.Parse(_v.UserPickerGridView1.SelectedCells[0].Value.ToString()), (int)_v.AmountPicker1.Value);
            _v.ActiveDebtGridView1.DataSource = _r.getdebtByUserId0(selectedUserId);

        }
        public void deleteDebt(int selectedUserId)
        {


            if (_r.getdebtByUserId0(selectedUserId) != null)
            {
                _r.deleteDebt(Int32.Parse(_v.ActiveDebtGridView1.SelectedCells[5].Value.ToString()));

            }
            _v.ActiveDebtGridView1.DataSource = _r.getdebtByUserId0(selectedUserId);

        }

        public void fillDebtByUserId(int selectedUserId) 
        {
            _v.ActiveDebtGridView1.DataSource = _r.getdebtByUserId0(selectedUserId);
        }
    }
}
