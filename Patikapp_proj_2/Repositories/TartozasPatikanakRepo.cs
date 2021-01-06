using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Modells.ViewModells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Repositories
{
    class TartozasPatikanakRepo : ITartozasPatikanakRepo
    {
        int selectedPhId;
        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();

        public TartozasPatikanakRepo(int pid)
        {
            selectedPhId = pid;
        }


        /// <summary>
        /// Tartozásokat jelenít meg. Nem adatbázisból származtatott modell
        /// </summary>
        /// <returns>List<ActiveDebtGridViewModell> result</returns>
        public List<PhtoPaActiveDebtGridViewModell> getAllDebt()
        {
            List<PhtoPaActiveDebtGridViewModell> result = new List<PhtoPaActiveDebtGridViewModell>();
            foreach (var item in db.debtphtoph.Where(x => x.from_ph_id == selectedPhId || x.to_ph_id == selectedPhId).ToList())
            {
                result.Add(new PhtoPaActiveDebtGridViewModell(
                            item.id,
                            db.pharmacies.Where(x => x.id == item.from_ph_id).FirstOrDefault().name,
                            db.pharmacies.Where(x => x.id == item.to_ph_id).FirstOrDefault().name,
                            item.amount,
                            item.OEP_TTT,
                            db.gyogysz.Where(x => x.OEP_TTT == item.OEP_TTT).FirstOrDefault().OEP_NEV
                    ));
            }

            return result;
        }

        /// <summary>
        /// Substring alapján gyógyszereket keres az eredménnyel tér vissza
        /// </summary>
        /// <returns>List<gyogysz> result</returns>

        public List<gyogysz> searchGyogysz(String param)
        {
            return db.gyogysz.Where(x => x.OEP_NEV.Contains(param)).ToList();
        }
        public void deleteDebt(int debtId)
        {
            db.debtphtoph.Attach(db.debtphtoph.Where(x => x.id == debtId).FirstOrDefault());
            db.debtphtoph.Remove(db.debtphtoph.Where(x => x.id == debtId).FirstOrDefault());
            db.SaveChanges();
        }

        

    }
}
