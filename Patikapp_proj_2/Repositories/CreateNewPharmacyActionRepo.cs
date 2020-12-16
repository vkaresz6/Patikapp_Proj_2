using Patikapp_proj_2.Modells;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Repositories
{
    class CreateNewPharmacyActionRepo : ICreateNewPharmacyActionRepo
    {

        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();

        public CreateNewPharmacyActionRepo()
        {

        }

        public void insert(pharmacies param1, pharmacies_data param2)
        {
            param2.email = "0";
            param2.pharmacy_id = getLastIndex();
            db.pharmacies.Add(param1);
            db.SaveChanges();
            db.pharmacies_data.Add(param2);
            db.SaveChanges();
        }
        public int getLastIndex()
        {
            return db.pharmacies.ToList().LastOrDefault().id;
        }

    }
}
