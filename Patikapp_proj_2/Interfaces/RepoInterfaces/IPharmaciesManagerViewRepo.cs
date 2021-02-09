using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Modells.ViewModells;

namespace Patikapp_proj_2.Repositories
{
    interface IPharmaciesManagerViewRepo
    {
        bool deleteById(int id);
        pharmacies_data findDataById(int id);
        pharmacies findPharmacyById(int id);
        PharmaciesManagerViewModell getViewModell(int id);
        int getPID(string name);
    }
}