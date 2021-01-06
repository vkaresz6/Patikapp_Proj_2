using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Modells.ViewModells;
using System.Collections.Generic;

namespace Patikapp_proj_2.Repositories
{
    interface ITartozasBetegnekRepo
    {
        void addDebt(int OEPTTT, int userId, int amount);
        void deleteDebt(int debtId);
        List<PhtoPaActiveDebtGridViewModell> getActiveDebtsContent();
        List<gyogysz> searchGyogysz(string param);
    }
}