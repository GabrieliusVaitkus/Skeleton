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
        string Price = Convert.ToString(9.100);
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
        
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String Price = "";
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "a"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = ""; //this should be ok
            Price = Price.PadRight(500, 'a');
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(CardDescription, Price, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
       

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(CardDescription, Price, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            String DateAdded = "This is not a date";
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CardDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CardDescription = "";
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CardDescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardDescription = "a";
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardDescription = "aa";
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CardDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardDescription = "";
            CardDescription = CardDescription.PadRight(49, 'a');
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardDescriptionMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardDescription = "";
            CardDescription = CardDescription.PadRight(50, 'a');
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CardDescription = "";
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void CardDescriptionMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardDescription = "";
            CardDescription = CardDescription.PadRight(25, 'a');
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CardType = "";
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CardTypeMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardType = "a";
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void CardTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardType = "aa";
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardType = "";
            CardType = CardType.PadRight(49, 'a');
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardTypeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardType = "";
            CardType = CardType.PadRight(50, 'a');
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CardTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CardType = "";
            CardType = CardType.PadRight(51, 'a');
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CardTypeMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CardType = "";
            CardType = CardType.PadRight(25, 'a');
            //invoke the method
            Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






















    }
}

