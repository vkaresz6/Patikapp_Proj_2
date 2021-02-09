using Patikapp_proj_2.Interfaces.ViewInterfaces;
using Patikapp_proj_2.Modells;
using Patikapp_proj_2.Repositories;
using Patikapp_proj_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Presenters
{
    class chatPresenter
    {
        IchatRepo _r;
        IChatForm _v;
        public chatPresenter(ChatForm v, chatRepo r)
        {
            _v = v;
            _r = r;

        }

        public void refreshChatBox()
        {
            _v.chatBox.Text = "";
            foreach (var item in _r.getAllMsg())
            {
                _v.chatBox.Text +=  item.message;
            }
        }

        public void sendMsg()
        {
            messagestoph param = new messagestoph();
            param.message = Patikapp_proj_2.Resorurces.Session.PharmacyName + " :  " + _v.msgBox.Text;
            param.ph_id = Patikapp_proj_2.Resorurces.Session.pharmacy;
            param.user_id = Int32.Parse(_v.userGridView.SelectedCells[0].Value.ToString());

            _r.saveMsg(param);
        }

        


    }
}
