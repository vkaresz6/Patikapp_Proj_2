using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Modells.ViewModells
{
    class PhtoPhActiveDebtGridViewModell
    {
        String FromPhName;
        String ToPhName;
        String MedName;
        int amount;
        int medId;
        int debtId;

        public PhtoPhActiveDebtGridViewModell(int debtId, String fromPhName, string toPhName, int amount, int medId, String MedName)
        {
            this.debtId = debtId;
            FromPhName = fromPhName;
            ToPhName = toPhName;
            this.amount = amount;
            this.medId = medId;
            this.MedName1 = MedName;
        }

        public string FromPhName1 { get => FromPhName; set => FromPhName = value; }
        public string ToPhName1 { get => ToPhName; set => ToPhName = value; }
        public int Amount { get => amount; set => amount = value; }
        public int MedId { get => medId; set => medId = value; }
        public string MedName1 { get => MedName; set => MedName = value; }
        public int DebtId { get => debtId; set => debtId = value; }
    }
}
