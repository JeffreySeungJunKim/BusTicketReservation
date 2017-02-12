using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketReservation
{
    class LoginControl
    {
        private static Login _view;//set link to view
        public void AccountsGroup_Load(object sender,EventArgs e)
        {
            _view = (Login)sender;
        }
    }
}
