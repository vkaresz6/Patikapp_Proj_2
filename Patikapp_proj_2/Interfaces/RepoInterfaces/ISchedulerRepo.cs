using Patikapp_proj_2.Modells;
using System.Collections.Generic;

namespace Patikapp_proj_2.Repositories
{
    interface ISchedulerRepo
    {
        void AddTo(todo param);
        void deleteTodo(int id);
        List<todo> getAllTodos();
        List<todo> getTodoByPid(int pid);
    }
}