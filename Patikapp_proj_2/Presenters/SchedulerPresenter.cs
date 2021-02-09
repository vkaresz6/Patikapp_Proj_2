using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Repositories;
using Patikapp_proj_2.Services;
using Patikapp_proj_2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Presenters
{
    class SchedulerPresenter
    {

        ISchedulerRepo _r;
        ISchedulerform _v;
        ScheduleFactory factory;
        int pid;
        public SchedulerPresenter(ISchedulerRepo r, ISchedulerform v, int pid)
        {
            _r = r;
            _v = v;
            factory = new ScheduleFactory();
            this.pid = pid;
        }

        public void fillGridView()
        {
            _v.DataGridView1.DataSource = _r.getAllTodos();
        }

        public void fillGridViewByPid()
        {
            _v.DataGridView1.DataSource = _r.getTodoByPid(pid);
        }

        public void initAllTodosByPid()
        {
            List<todo> todos = new List<todo>();
            todos = _r.getTodoByPid(pid);
            foreach (var item in todos)
            {
                factory.IntervalInMinutes(item.alarmhours, item.alarmMinutes, 30, () =>
                {
                    if (item.Expiration == DateTime.Today)
                    {

                        MessageBox.Show(item.todo1);
                        SystemSounds.Beep.Play();

                    }
                });


            }

        }

        public void AddTodo()
        {
            todo param = new todo();
            param.id = 0;
            param.Expiration = _v.Exp.Value;
            param.alarmhours = Int32.Parse(_v.Hh.Text);
            param.alarmMinutes = Int32.Parse(_v.Mm.Text);
            param.ph_id = pid;
            param.todo1 = _v.RichTextBox2.Text;
            _r.AddTo(param);
            factory.IntervalInMinutes(param.alarmhours, param.alarmMinutes, 1, () =>
            {
                
                    MessageBox.Show(param.todo1);
                    SystemSounds.Beep.Play();

                
            });
        }

    }
    
}
