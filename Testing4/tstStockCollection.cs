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
        public void ThisStockPropertyOK()
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

        [TestMethod]
        public void UpdateMethodOK()
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
            TestItem.Available = false;
            TestItem.CardDescription = "Water";
            TestItem.CardType = "Trainer";
            TestItem.Price = Convert.ToDecimal(9.995);
            TestItem.DateAdded = DateTime.Now.Date;
            AllStocks.ThisStock = TestItem;
            AllStocks.Update();
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
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
            AllStocks.Delete();
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCardTypeMethodOK()
        {
            //Create an instance of the class we want to create
            //clsStockCollection AllStocks = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByCardType("xxxxxx");
            //test to see that it exists
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByCardTypeFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByCardType("xxxxx");
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByCardTypeTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportByCardType("Pokemon");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].CardNo != 27)
                {
                    OK = false;
                }

                if (FilteredStock.StockList[1].CardNo != 28)
                {
                    OK = false;
                }
            }

            else
            {
                OK = false;
            }

            Assert.IsFalse(OK);
        }
    }
}




    

