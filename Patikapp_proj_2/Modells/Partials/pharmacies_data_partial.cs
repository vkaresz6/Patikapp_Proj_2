using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Modells
{
    public partial class pharmacies_data
    {
        public pharmacies_data()
        {

        }

        public pharmacies_data(int id, int pharmacy_id, string phone, string email, string website, string facebook, string adress)
        {
            this.id = id;
            this.pharmacy_id = pharmacy_id;
            this.phone = phone;
            this.email = email;
            this.website = website;
            this.facebook = facebook;
            this.adress = adress;
        }
    }
}
