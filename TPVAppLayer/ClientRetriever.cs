using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVDataLayer;

namespace TPVAppLayer
{
    public class ClientRetriever
    {


        public List<clients> GetClients()
        {
            var context = new tpvenlanubecalendarEntities();
            return context.clients.clientId.Tolist();
        }

    }
}
