using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        string CardDescription = "Psychic";
        string CardType = "Energy";
        decimal Price = Convert.ToDecimal(9.100);
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
            AnStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 CardNo = 1006;
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
            Int32 CardNo = 1006;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the address no
            if (AnStock.CardNo != 1006)
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
            Int32 CardNo = 1006;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the property
            if (AnStock.DateAdded != Convert.ToDateTime("03/08/2020"))
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
            Int32 CardNo = 1006;
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
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CardNo = 1006;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the property
            if (AnStock.Price != Convert.ToDecimal(9.100))
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
            Int32 CardNo = 1006;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the property
            if (AnStock.CardType != "Energy")
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
            Int32 CardNo = 1006;
            //invoke the method
            Found = AnStock.Find(CardNo);
            //check the property
            if (AnStock.CardDescription != "Psychic")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }













    }
}

