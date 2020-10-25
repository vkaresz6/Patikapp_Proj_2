using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Modells.ViewModells
{
    class PharmaciesManagerViewModell
    {
        int id;
        String name,
               adress,
               phone,
               website,
               facebook;

        public PharmaciesManagerViewModell()
        {

        }

        public PharmaciesManagerViewModell(int id, string name, string adress, string phone, string website, string facebook)
        {
            this.Id = id;
            this.Name = name;
            this.Adress = adress;
            this.Phone = phone;
            this.Website = website;
            this.Facebook = facebook;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Website { get => website; set => website = value; }
        public string Facebook { get => facebook; set => facebook = value; }
    }
}
