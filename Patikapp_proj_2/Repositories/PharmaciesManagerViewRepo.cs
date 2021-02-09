using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Modells.ViewModells;
using Patikapp_proj_2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Linq.Expressions;
using MySqlX.XDevAPI.Common;
using System.Windows.Forms;
using System.Media;

namespace Patikapp_proj_2.Repositories
{
    class PharmaciesManagerViewRepo : IPharmaciesManagerViewRepo
    {
        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();
        public pharmacies pharmacie;
        public pharmacies_data pharmacie_data;

        public pharmacies findPharmacyById(int id)
        {
            try
            {
                return db.pharmacies.Where(x => x.id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show("DatabaseError Patikapp.repositories.pharmacymanagerViewRepo.findPharmacyById " + " " + e.ToString());
                Console.WriteLine("DatabaseError Patikapp.repositories.pharmacymanagerViewRepo.findPharmacyById " + " " + e.ToString());
                return null;
            }
        }

        public pharmacies_data findDataById(int id)
        {
            try
            {
                return db.pharmacies_data.ToList()[id-1];
            }
            catch (Exception e)
            {

                MessageBox.Show("DatabaseError Patikapp.repositories.pharmacymanagerViewRepo.findDataById " + " " + e.ToString());
                Console.WriteLine("DatabaseError Patikapp.repositories.pharmacymanagerViewRepo.findDatayById " + " " + e.ToString());
                return null;
            }
        }

        public bool deleteById(int id)
        {

            try
            {
                db.pharmacies_data.Remove(findDataById(id));
                db.pharmacies.Remove(findPharmacyById(id));
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Törlés sikertelen DatabaseError Patikapp.repositories.pharmacymanagerViewRepo.findDataById " + " " + e.ToString());
                Console.WriteLine(("Törlés sikertelen DatabaseError Patikapp.repositories.pharmacymanagerViewRepo.findDataById " + " " + e.ToString()));
                db.SaveChanges();
                return false;
            }
        }

        public PharmaciesManagerViewModell getViewModell(int id)
        {
            try
            {
                PharmaciesManagerViewModell modell = new PharmaciesManagerViewModell(findPharmacyById(id).id, findPharmacyById(id).name, findDataById(id).adress, findDataById(id).phone, findDataById(id).website, findDataById(id).facebook);
                return modell;
            }
            catch (Exception e)
            {
                MessageBox.Show("Törlés sikertelen DatabaseError Patikapp.repositories.pharmacymanagerViewRepo.getViewModell " + " " + e.ToString());
                Console.WriteLine(("Törlés sikertelen DatabaseError Patikapp.repositories.pharmacymanagerViewRepo.getViewModell " + " " + e.ToString()));
                throw;
            }
        }

        public int getPID(String name)
        {
            return db.pharmacies.Where(x => x.name == name).FirstOrDefault().id;
        }
    }
}
