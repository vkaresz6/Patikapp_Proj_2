using Patikapp_proj_2.Modells;

namespace Patikapp_proj_2.Repositories
{
    interface ICreateNewPharmacyActionRepo
    {
        void insert(pharmacies param1, pharmacies_data param2);
        int getLastIndex();
    }
}