using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Modells
{
    public partial class debtphtoph
    {
        
        public debtphtoph(int id, int from_ph_id,int to_ph_id, int OEP_TTT, int amount)
        {
            this.id = id;
            this.from_ph_id = from_ph_id;
            this.to_ph_id = to_ph_id;
            this.OEP_TTT = OEP_TTT;
            this.amount = amount;
            this.actor_id = 0;
            this.exists = false;
            this.ExpirationDay = new DateTime();
            

        }

        public debtphtoph()
        {

        }
    }
}
