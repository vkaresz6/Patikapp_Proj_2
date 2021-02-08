using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Modells.ViewModells
{
    public class DisplayUserModell
    {
        public users user;
        public users_data user_data;
        public user_roles role;

        public DisplayUserModell()
        {

        }

        public DisplayUserModell(users user, users_data user_data, user_roles role)
        {
            this.user = user;
            this.user_data = user_data;
            this.role = role;
        }
    }
}
