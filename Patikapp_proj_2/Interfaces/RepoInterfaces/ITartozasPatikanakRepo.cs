using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Modells.ViewModells;
using System.Collections.Generic;

namespace Patikapp_proj_2.Repositories
{
    interface ITartozasPatikanakRepo
    {
        List<PhtoPaActiveDebtGridViewModell> getAllDebt();
        List<gyogysz> searchGyogysz(string param);
        void deleteDebt(int debtId);
    }
}