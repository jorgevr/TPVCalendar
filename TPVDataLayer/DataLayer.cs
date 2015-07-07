using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVDataLayer
{
    public class DataLayer
    {
        public long MaxClientsId()
        {
            var context = new tpvenlanubecalendarEntities();

            // clients toAdd = new clients();
            var sortedClients = from t in context.clients orderby t.clientId ascending select t.clientId;

            // var sortedClients = context.clients.clientId.ToArray();

            var maxId = sortedClients.Max();

            //var sortedArray = sortedClients.ToArray();

            return maxId;

        }


    }
}
