using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Modells.ViewModells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Repositories
{
    class TartozasBetegnekRepo : ITartozasBetegnekRepo
    {
        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();
        int selectedPid;
        public TartozasBetegnekRepo(int selectedPid)
        {
            this.selectedPid = selectedPid;
        }


        /// <summary>
        /// Kitölti az activedebtdatagridview-t szöveges tartalommal
        /// </summary>
        /// <param name="selectedPid">Szerkesztett patika id</param>
        /// <returns></returns>
        public List<PhtoPaActiveDebtGridViewModell> getActiveDebtsContent()
        {
            List<PhtoPaActiveDebtGridViewModell> result = new List<PhtoPaActiveDebtGridViewModell>();
            foreach (var item in db.debtphtopa.Where(x => x.from_ph_id == selectedPid).ToList())
            {
                MessageBox.Show(db.debtphtopa.Where(x => x.from_ph_id == selectedPid).ToList().Count.ToString());
                result.Add(new PhtoPaActiveDebtGridViewModell(
                                0,
                                db.pharmacies.Where(x => x.id == selectedPid).FirstOrDefault().name,
                                db.users.Where(x => x.id == item.to_pa_id).FirstOrDefault().username,
                                item.amount,
                                item.OEP_TTT,
                                db.gyogysz.Where(x => x.OEP_TTT == item.OEP_TTT).FirstOrDefault().OEP_NEV
                    ));
            }

            return result;
        }

        public List<PhtoPaActiveDebtGridViewModell> getActiveDebtsContent(int userId)
        {
            List<PhtoPaActiveDebtGridViewModell> result = new List<PhtoPaActiveDebtGridViewModell>();
            foreach (var item in db.debtphtopa.Where(x => x.from_ph_id == selectedPid).ToList())
            {
                result.Add(new PhtoPaActiveDebtGridViewModell(
                                0,
                                db.pharmacies.Where(x => x.id == selectedPid ).FirstOrDefault().name,
                                db.users.Where(x => x.id == item.to_pa_id).FirstOrDefault().username,
                                item.amount,
                                item.OEP_TTT,
                                db.gyogysz.Where(x => x.OEP_TTT == item.OEP_TTT).FirstOrDefault().OEP_NEV
                    ));
            }

            return result;
        }


        public List<gyogysz> searchGyogysz(String param)
        {
            List<gyogysz> result = db.gyogysz.Where(x => x.OEP_NEV.Contains(param)).ToList();
            return result;
        }

        public void addDebt(int OEPTTT, int userId, int amount)
        {
            db.debtphtopa.Add(new debtphtopa(selectedPid, userId, OEPTTT, amount));
            db.SaveChanges();
        }

        public void deleteDebt(int debtId)
        {
            db.debtphtopa.Attach(db.debtphtopa.Where(x => x.id == debtId).FirstOrDefault());
            db.debtphtopa.Remove(db.debtphtopa.Where(x => x.id == debtId).FirstOrDefault());
            db.SaveChanges();
        }
        /// <summary>
        /// gets the debt of an individual user
        /// </summary>
        /// <param name="id">desired user id</param>
        /// <returns></returns>
        public List<PhtoPaActiveDebtGridViewModell> getdebtByUserId0(int id)
        {
            List<PhtoPaActiveDebtGridViewModell> result = new List<PhtoPaActiveDebtGridViewModell>();
            foreach (var item in db.debtphtopa.Where(x => x.to_pa_id == id).ToList())
            {
                result.Add(new PhtoPaActiveDebtGridViewModell(
                                item.id,
                                db.pharmacies.Where(x => x.id == item.from_ph_id).FirstOrDefault().name,
                                db.users.Where(x => x.id == item.to_pa_id).FirstOrDefault().username,
                                item.amount,
                                item.OEP_TTT,
                                db.gyogysz.Where( x => x.OEP_TTT == item.OEP_TTT).FirstOrDefault().OEP_NEV

                    ));
            }

            return result;
        }

    }
}
