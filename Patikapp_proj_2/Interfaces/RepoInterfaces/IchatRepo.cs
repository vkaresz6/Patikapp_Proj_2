using Patikapp_proj_2.Modells;
using System.Collections.Generic;

namespace Patikapp_proj_2.Repositories
{
    interface IchatRepo
    {
        List<messagestoph> getAllMsg();
        void saveMsg(messagestoph param);
    }
}