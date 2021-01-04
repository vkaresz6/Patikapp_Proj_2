using Patikapp_proj_2.Modells;
using System.Collections.Generic;

namespace Patikapp_proj_2.Repositories
{
    interface IAssociateEmployeeRepo
    {
        List<users> getAssoc();
        void setEmployee(int eid);
        void unSetetEmployee(int eid);
    }
}