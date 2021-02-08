using MySqlX.XDevAPI;
using Patikapp_proj_2.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Repositories
{
    class LoginRepo : ILoginRepo
    {
        int user_id;
        int pharmacy;
        String pharmacy_name = "";
        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();

        public bool logIn(String username, String psw)
        {


            if (username != "" && psw != "")
            {
                if (db.psw.Where( x => x.psw1 == psw).FirstOrDefault() != null && db.users.Where(x => x.username == username).FirstOrDefault() != null)
                {
                    user_id = db.psw.Where(x => x.psw1 == psw).FirstOrDefault().user_id;
                    pharmacy = db.users_data.Where(x => x.user_id == user_id).FirstOrDefault().IsEmployedAt;
                    pharmacy_name = db.pharmacies.Where( x => x.id == pharmacy).FirstOrDefault().name;
                    Patikapp_proj_2.Resorurces.Session.pharmacy = pharmacy;
                    Patikapp_proj_2.Resorurces.Session.PharmacyName = pharmacy_name;
                    Patikapp_proj_2.Resorurces.Session.Username = username;
                    Patikapp_proj_2.Resorurces.Session.User_id = user_id;
                    if (db.users_data.Where(x => x.user_id ==user_id).FirstOrDefault().IsEmployedAt == 0 )
                    {
                        System.Windows.Forms.MessageBox.Show(" Nem jogosult az asztali program használatához!");
                        return false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }


         
        }

        public bool isAdmin()
        {
            if (db.user_roles.Where(x => x.user_id == Patikapp_proj_2.Resorurces.Session.User_id).FirstOrDefault().role > 1)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

       
    }
}
