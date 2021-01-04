using Patikapp_proj_2.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Repositories
{
    class AssociateEmployeeRepo : IAssociateEmployeeRepo
    {
        int selectedPharmacyId;
        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();

        /// <summary>
        /// Conatructor
        /// </summary>
        /// <param name="selectedId">selected pharmacy id</param>
        public AssociateEmployeeRepo(int selectedId)
        {
            this.selectedPharmacyId = selectedId;
        }

        /// <summary>
        /// gets the selected pharmacies current employees. 
        /// </summary>
        /// <returns>List<users></returns>
        public List<users> getAssoc()
        {
            List<users> result = new List<users>();
            List<users_data> userData = db.users_data.Where(x => x.IsEmployedAt == selectedPharmacyId).ToList();
            foreach (var item in userData)
            {
                result.Add(db.users.Where(x => x.id == item.user_id).FirstOrDefault());
            }
            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eid">Selected user id</param>
        public void setEmployee(int eid)
        {
            db.users_data.Where(x => x.user_id == eid).FirstOrDefault().IsEmployedAt = selectedPharmacyId;
            db.SaveChanges();
        }

        public void unSetetEmployee(int eid)
        {
            db.users_data.Where(x => x.user_id == eid).FirstOrDefault().IsEmployedAt = 0;
            db.SaveChanges();
        }

       
    }
}
