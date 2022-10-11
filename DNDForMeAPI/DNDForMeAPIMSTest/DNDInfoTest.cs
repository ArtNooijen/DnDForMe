using DNDForMeAPIMSTest.MockDal;
using DNDForMeLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeAPIMSTest
{
    [TestClass]
    public class DNDInfoTest
    {
        private DNDInfoMockDal dNDInfoMockDal;
        private DNDInfoCollection dNDInfoCollection;
        private User user;

        [TestInitialize]
        public void NewDataLayer()
        {
            dNDInfoMockDal = new();
            dNDInfoCollection = new(dNDInfoMockDal);
        }
        [TestMethod]
        public void TestGetAllDNDInfos()
        {
            //arrange
            List<DNDInfo> TestList;
            // arrange
            TestList = dNDInfoCollection.GetAllDNDInfos();
            string test = TestList.First().Name;
            //assert
            Assert.AreEqual(2, TestList.Count);
            Assert.AreEqual("Test1", test);
        }

    }
}
