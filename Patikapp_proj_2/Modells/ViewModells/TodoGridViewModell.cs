using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patikapp_proj_2.Modells.ViewModells
{
    class TodoGridViewModell
    {
        int id;
        String Todo;
        DateTime expiration;
        String HH;
        String MM;

        public TodoGridViewModell(int id, string todo, DateTime expiration, string hH, string mM)
        {
            this.Id = id;
            Todo1 = todo;
            this.Expiration = expiration;
            HH1 = hH;
            MM1 = mM;
        }

        public string Todo1 { get => Todo; set => Todo = value; }
        public DateTime Expiration { get => expiration; set => expiration = value; }
        public string HH1 { get => HH; set => HH = value; }
        public string MM1 { get => MM; set => MM = value; }
        public int Id { get => id; set => id = value; }
        public RichTextBox RichTextBox2 { get => RichTextBox2; set => RichTextBox2 = value; }

    }
}
