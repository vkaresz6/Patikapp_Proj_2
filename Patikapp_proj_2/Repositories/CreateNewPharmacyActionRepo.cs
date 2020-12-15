using Patikapp_proj_2.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            db.pharmacies(param1);
            db.pharmacies_data.Add(param2);
            db.SaveChanges();
        }
        public int getNextIndex()
        {
            return db.pharmacies.ToList().LastOrDefault().id + 1;
        }

    }
}
