using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patikapp_proj_2.Modells;
using System.Data.Entity.Migrations;
namespace Patikapp_proj_2.Repositories
{
    class IUpdatePharmacyRepo
    {
        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();

        public IUpdatePharmacyRepo()
        {

        }


        public pharmacies getPharmacy(int id)
        {

            return db.pharmacies.Where(x => x.id == id).FirstOrDefault();

        }
        public pharmacies_data getPharmacy_data(int id)
        {

            return db.pharmacies_data.Where(x => x.pharmacy_id == id).FirstOrDefault();

        }

        public void updatePharmacy(pharmacies_data param)
        {
            db.pharmacies_data.AddOrUpdate(new pharmacies_data[] { param });
            db.SaveChanges();
        }


    }
}
