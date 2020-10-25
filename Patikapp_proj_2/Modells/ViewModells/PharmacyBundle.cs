using Patikapp_proj_2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Modells.ViewModells
{
    public class PharmacyBundle
    {
        private pharmacies pharmacie;
        private pharmacies_data data;

        protected pharmacies Pharmacie { get => pharmacie; set => pharmacie = value; }
        protected pharmacies_data Data { get => data; set => data = value; }

        public PharmacyBundle(pharmacies pharmacie, pharmacies_data data)
        {
            this.Pharmacie = pharmacie;
            this.Data = data;
        }
    }
}
