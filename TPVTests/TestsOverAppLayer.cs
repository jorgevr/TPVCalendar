using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVAppLayer;
using TPVDataLayer;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TPVTests
{
    [TestClass]
    class TestsOverAppLayer
    {
        [TestMethod]
        public void listClients_Succes()
        {
            var context = new tpvenlanubecalendarEntities();
            var firstClient = context.clients.First();
            Assert.IsTrue(firstClient != null);
        }

        //no more test

    }
}
