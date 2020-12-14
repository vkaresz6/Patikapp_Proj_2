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
                db.pharmacies_data.Remove(db.pharmacies_data.Where(x => x.pharmacy_id == id).FirstOrDefault());
                db.pharmacies.Remove(db.pharmacies.Where(x => x.id == id).FirstOrDefault());
                db.SaveChanges();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


        }
    }
}
