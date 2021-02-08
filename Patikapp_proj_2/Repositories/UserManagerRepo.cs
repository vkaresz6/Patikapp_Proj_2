using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Modells.ViewModells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Repositories
{
    class UserManagerRepo : IUserManagerRepo
    {

        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();

        public UserManagerRepo() 
        {

        }

        public void deleteUser(int id)
        {
            db.users.Remove(db.users.Where(x => x.id == id).FirstOrDefault());
            db.users_data.Remove(db.users_data.Where(x => x.user_id == id).FirstOrDefault());
            db.user_roles.Remove(db.user_roles.Where(x => x.user_id == id).FirstOrDefault());
            db.SaveChanges();
        }

        public void resetPsw(int id, String psw)
        {
            db.psw.Where(x => x.user_id == id).FirstOrDefault().psw1 = psw;
            db.SaveChanges();
        }

        public DisplayUserModell displayUser(int id)
        {
            return new DisplayUserModell
                (
                db.users.Where(x => x.id == id).FirstOrDefault(),
                db.users_data.Where(x => x.user_id == id).FirstOrDefault(),
                db.user_roles.Where(x => x.user_id == id).FirstOrDefault()
                );
        }

        public List<users> searchForUsersBySubString(String param)
        {
            return db.users.Where(x => x.username.Contains(param)).ToList();
        }
    }
}
