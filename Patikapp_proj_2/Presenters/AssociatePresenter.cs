using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Repositories;
using Patikapp_proj_2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Presenters
{
    
    class AssociatePresenter
    {
        IAssociateEmployeeRepo _r;
        IAssiciateEmployeeForm _v;

        public AssociatePresenter(IAssociateEmployeeRepo r,IAssiciateEmployeeForm v)
        {
            _r = r;
            _v = v;  
        }

        public List<users> fillAssociatedGridView()
        {
            return _r.getAssoc();


        }
        /// <summary>
        /// Associate employee
        /// </summary>
        /// <param name="eid">SelectedEmployeeId</param>
        public void assoc(int eid)
        {
            _r.setEmployee(eid);
        }

        /// <summary>
        /// dissociate employee
        /// </summary>
        /// <param name="eid">SelectedEmployeeId</param>
        public void dissoc(int eid)
        {
            _r.unSetetEmployee(eid);
        }

        
    }
}
