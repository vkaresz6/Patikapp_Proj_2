using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Repositories
{
    class SchedulerRepo : ISchedulerRepo
    {
        vpharmacies_databaseEntities db = new vpharmacies_databaseEntities();
        public SchedulerRepo()
        {

        }

        public List<todo> getAllTodos()
        {
            return db.todo.ToList();
        }
        /// <summary>
        /// adds todo
        /// </summary>
        /// <param name="param"></param>
        public void AddTo(todo param)
        {
            db.todo.Add(param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">todoId (primary)</param>
        public void deleteTodo(int id)
        {
            db.todo.Remove(db.todo.Where(x => x.id == id).FirstOrDefault());

        }
        /// <summary>
        /// Get duty list based on pharmacy id
        /// </summary>
        /// <param name="pid">selectedPharmacyId</param>
        /// <returns></returns>
        public List<todo> getTodoByPid(int pid)
        {
            List<todo> result = new List<todo>();

            foreach (var item in db.todo.ToList())
            {
                if (item.ph_id == pid)
                {
                    result.Add(item);
                }
            }

            return result;
        }



    }
}
