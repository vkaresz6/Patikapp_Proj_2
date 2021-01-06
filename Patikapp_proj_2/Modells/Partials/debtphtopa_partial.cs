using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Modells
{
    public partial class debtphtopa
    {
        public debtphtopa()
        {

        }

        public debtphtopa(int fromphid, int topaid, int oepttt, int amount)
        {
            this.id = 0;
            this.amount = amount;
            this.from_ph_id = fromphid;
            this.to_pa_id = topaid;
            this.OEP_TTT = oepttt;
            this.actor_id = 0;
            this.exist = false;           
        }
    }
}
