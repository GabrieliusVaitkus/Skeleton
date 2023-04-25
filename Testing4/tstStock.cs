using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        string CardDescription = "Water";
        string CardType = "Trainer";
        decimal CardPrice = 9;
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);

        }
        [TestMethod]
        public void AvailableCardOK()
        {
            //Create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            Boolean TestData = true;
            //Assign the data to the item
            AnStock.Available = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStock.Available, TestData);


        }
        [TestMethod]
        public void DateAddedCardOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the item
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void CardNoOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            Int32 TestData = 2;
            //assign the data to the item
            AnStock.CardNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.CardNo, TestData);
        }

        [TestMethod]
        public void CardDescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            string TestData = "Water";
            //Assign the data to the item
            AnStock.CardDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.CardDescription, TestData);
        }

        [TestMethod]
        public void CardTypeOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            string TestData = "This is the type of the card";
            //Assign the data to the item
            AnStock.CardType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.CardType, TestData);
        }

        [TestMethod]
        public void CardPriceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            decimal TestData = 975;
            //Assign the data to the item
            AnStock.CardPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.CardPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 CardNo = 21;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCardNoFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bolean variable to store the results of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (Assume it is)
            Boolean ok = true;
            //Create some test data to use with the method
            Int32 CardNo = 21;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the address no
            if (AnStock.CardNo != 21)
            {
                ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CardNo = 21;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the property
            if (AnStock.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CardNo = 21;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the property
            if (AnStock.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCardPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CardNo = 21;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the property
            if (AnStock.CardPrice != Convert.ToDecimal(5.22))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCardTypeFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CardNo = 21;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the property
            if (AnStock.CardType != "Fire")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCardDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CardNo = 21;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the property
            if (AnStock.CardDescription != "Lightning")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }













    }
}

