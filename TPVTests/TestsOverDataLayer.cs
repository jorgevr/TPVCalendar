using System;
using System.Linq;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPVDataLayer;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace TPVTests
{
    [TestClass]
    public class TestsOverDataLayer
    {
        [TestMethod]
        public void ReadTest_Succes()
        {
            var context = new tpvenlanubecalendarEntities();
            var firstClient = context.clients.First();
            Assert.IsTrue(firstClient != null);
        }


        [TestMethod]
        public void AddTest_Succes()
        {
            var context = new tpvenlanubecalendarEntities();

            clients toAdd = new clients();
            toAdd.clientId = 100;
            toAdd.clientName = "Charo";
            toAdd.clientPicture = string.Empty;
            toAdd.contactNumber = "56524";
            toAdd.lastProduct = "suavizante";
            toAdd.lastService = "corte";

            context.clients.Add(toAdd);

            context.SaveChanges();
            var result = context.clients.FirstOrDefault(s => s.clientName == "Manuel");

            Assert.IsNotNull(result);
   
        }

        [TestMethod]
        public void DeleteTest_Succes()
        {
            var context = new tpvenlanubecalendarEntities();

            var count = context.clients.Count();
            
            var deleteOrderClients = from clients in context.clients where
                                     clients.clientId == 100 select clients;

            foreach (var client in deleteOrderClients)
            {
                context.clients.Remove(client);      
            }
            context.SaveChanges();

            var count2 = context.clients.Count();
            
            Assert.AreNotEqual(count2, count);         

        }

        [TestMethod]
        public void ArrayTest_Success()
        {
            var context = new tpvenlanubecalendarEntities();

           // clients toAdd = new clients();
           var sortedClients = from t in context.clients orderby t.clientId ascending select t.clientId;

           // var sortedClients = context.clients.clientId.ToArray();

            var maxId = sortedClients.Max();

            var sortedArray = sortedClients.ToArray();

            Assert.IsTrue(maxId > sortedArray[sortedArray.Length - 2]);

        }


    }
}
