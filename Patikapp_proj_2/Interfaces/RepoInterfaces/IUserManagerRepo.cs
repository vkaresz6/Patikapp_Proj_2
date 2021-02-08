using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Modells.ViewModells;
using System.Collections.Generic;

namespace Patikapp_proj_2.Repositories
{
    interface IUserManagerRepo
    {
        void deleteUser(int id);
        DisplayUserModell displayUser(int id);
        void resetPsw(int id, string psw);
        List<users> searchForUsersBySubString(string param);
    }
}