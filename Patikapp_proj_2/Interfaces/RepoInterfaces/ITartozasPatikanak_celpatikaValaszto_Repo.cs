using Patikapp_proj_2.Modells;
using System.Collections.Generic;

namespace Patikapp_proj_2.Repositories
{
    interface ITartozasPatikanak_celpatikaValaszto_Repo
    {
        List<pharmacies> getAllPharmacyWithException(int excludePhId);
        void addDebt(int fromPhId, int toPhId, int OEP_TTT,  int amount);
    }
}