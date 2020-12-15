using Patikapp_proj_2.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Repositories
{
    class pharmacymanager_actionpicker_repo : Ipharmacymanager_actionpicker_repo
    {
        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();

        public pharmacymanager_actionpicker_repo()
        {

        }

        public void delete(int id)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törölni akarod a kijelölt patikát?", "Figyelem!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var item in db.debtphtoph.Where(x => x.to_ph_id == id || x.from_ph_id == id).ToList())
                {
                    db.debtphtoph.Remove(item);
                }
                foreach (var item in db.debtphtopa.Where(x =>x.from_ph_id == id).ToList())
                {
                    db.debtphtopa.Remove(item);
                }
                db.pharmacies.Remove(db.pharmacies.Where(x => x.id == id).FirstOrDefault());
                db.pharmacies_data.Remove(db.pharmacies_data.Where(x => x.pharmacy_id == id).FirstOrDefault());
               
                db.SaveChanges();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


        }
    }
}
