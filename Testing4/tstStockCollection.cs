using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.CardNo = 1;
            TestItem.CardDescription = "Psychic";
            TestItem.CardType = "Energy";
            TestItem.Price = Convert.ToDecimal(9.100);
            TestItem.DateAdded = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllStocks.StockList, TestList);
        }

       

        [TestMethod]
        public void ThisStockProprtyOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.Available = true;
            TestStock.CardNo = 1;
            TestStock.CardDescription = "Psychic";
            TestStock.CardType = "Energy";
            TestStock.Price = Convert.ToDecimal(9.100);
            TestStock.DateAdded = DateTime.Now.Date;
            AllStocks.ThisStock = TestStock;
            //test to see that it exists
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.CardNo = 1;
            TestItem.CardDescription = "Psychic";
            TestItem.CardType = "Energy";
            TestItem.Price = Convert.ToDecimal(9.100);
            TestItem.DateAdded = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.CardNo = 1;
            TestItem.CardDescription = "Psychic";
            TestItem.CardType = "Energy";
            TestItem.Price = Convert.ToDecimal(9.100);
            TestItem.DateAdded = DateTime.Now.Date;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.CardNo = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }





    }
}
