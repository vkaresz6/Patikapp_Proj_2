using Patikapp_proj_2.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Repositories
{
    class TartozasPatikanak_celpatikaValaszto_Repo : ITartozasPatikanak_celpatikaValaszto_Repo
    {
        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();
        public TartozasPatikanak_celpatikaValaszto_Repo()
        {

        }

        public List<pharmacies> getAllPharmacyWithException(int excludePhId)
        {
            return db.pharmacies.Where(x => x.id != excludePhId).ToList();
        }

        public void addDebt(int fromPhId, int toPhId, int amount, int OEP_TTT )
        {
            db.debtphtoph.Add(new debtphtoph(0, fromPhId, toPhId, OEP_TTT, amount ));
            db.SaveChanges();
        }
    }
}
