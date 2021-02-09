using Patikapp_proj_2.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Repositories
{
    class chatRepo : IchatRepo
    {


        public chatRepo()
        {

        }


        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();

        public void saveMsg(messagestoph param)
        {

            db.messagestoph.Add(param);
            db.SaveChanges();
        }

        public List<messagestoph> getAllMsg()
        {
            return db.messagestoph.ToList();
        }

    }
}
