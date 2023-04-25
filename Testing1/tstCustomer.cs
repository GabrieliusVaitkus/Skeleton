using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //test date to make sure it can pass
        string FirstName = "Jane";
        string LastName = "Doe";
        string Email = "ss@dm.uk";
        string PhoneNo = "01235650935";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void ValidMethodOk()
        {
            //instance of class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //invoke method
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of Customer class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);

        }
        [TestMethod]
        public void DateAddedOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateAdded = TestData;
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }
        [TestMethod]
        public void CustomerNoOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerNo = TestData;
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }
        [TestMethod]
        public void FirstNameOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Sam";
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }
        [TestMethod]
        public void LastNameOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Smith";
            ACustomer.LastName = TestData;
            Assert.AreEqual(ACustomer.LastName, TestData);
        }
        [TestMethod]
        public void EmailOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "ss@hotm.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void PhoneNoOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "2151254207";
            ACustomer.ContactNumber = TestData;
            Assert.AreEqual(ACustomer.ContactNumber, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            Assert.IsTrue(Found);
        }

        //[TestMethod]
        //public void FindMethod_DJ_OK()
        //{
        //    //create an instance of the class we want to to create
        //    clsCustomer ACustomer_DJ = new clsCustomer();
        //    //Boolean variable to store the result of the validation
        //    Boolean Found = false;
        //    //create some test data to sue with the method
        //    Int32 CustomerNo = 1;
        //    //invoke the method
        //    Found = ACustomer_DJ.Find(CustomerNo);
        //    //test to see that the result is correct
        //    Assert.IsTrue(Found);
        //}

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //instance of class being created 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variabel to store result of search
            Boolean Found = false;
            //record if data is OK
            Boolean OK = true;
            //create test data to use with the method
            Int32 CustomerNo = 1;
            //Invoke method
            Found = ACustomer.Find(CustomerNo);
            // check customer number
            if (ACustomer.CustomerNo != 1)
            {
                OK = false;
            }
            //test to see that the result is ok/correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            //imvoke the method
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.DateAdded != Convert.ToDateTime("22/02/2021"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.FirstName != "Dawn") //FirstName property name didn't match what was in the Find Method
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.LastName != "Jay") //LastName property name didn't match what was in the Find Method, was CustomerLastName
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Email != "d@dmu.ac.uk") //was EmailAddress in the Find method
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNumberFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.ContactNumber != "1254789654") //PhoneNo property name didn't match what was in the Find Method was ContactNumber
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountActiveFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.AccountActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //instance of class being created
            clsCustomer ACustomer = new clsCustomer();
            //String to store error message
            String Error = "";
            //test data to pass method
            string FirstName = "";
            //invoke method
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "a";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");// different from above test 

        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "aa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "aaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "aaaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "aaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FirstName = "aaaaaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //instance of class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message 
            String Error = "";
            //test data to pass method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a'); // this will cause a fail 
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //a variable to store test date data
            DateTime TestDate;
            //date is todays date
            TestDate = DateTime.Now.Date;
            //The date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert date to a string
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedInvalidDate()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string DateAdded = "This is not a date!";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //instance of class being created
            clsCustomer ACustomer = new clsCustomer();
            //String to store error message
            String Error = "";
            //test data to pass method
            string LastName = "";
            //invoke method
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void LastNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "a";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");// different from above test 

        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "aa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
         [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "aaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void LastNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "aaaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "aaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string LastName = "aaaaaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //instance of class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message 
            String Error = "";
            //test data to pass method
            string LastName = "";
            LastName = LastName.PadRight(500, 'a'); // this will cause a fail 
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //instance of class being created
            clsCustomer ACustomer = new clsCustomer();
            //String to store error message
            String Error = "";
            //test data to pass method
            string Email = "";
            //invoke method
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "a";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");// different from above test 

        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "aa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "aaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "aaaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "aaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "aaaaaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //instance of class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message 
            String Error = "";
            //test data to pass method
            string Email = "";
            Email = Email.PadRight(500, 'a'); // this will cause a fail 
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //instance of class being created
            clsCustomer ACustomer = new clsCustomer();
            //String to store error message
            String Error = "";
            //test data to pass method
            string PhoneNo = "";
            //invoke method
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNoMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNo = "a";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");// different from above test 

        }
        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNo = "aa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNo = "aaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNoMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNo = "aaaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNo = "aaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string PhoneNo = "aaaaaaaa";
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            //instance of class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message 
            String Error = "";
            //test data to pass method
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(500, 'a'); // this will cause a fail 
            Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
            Assert.AreNotEqual(Error, "");
        }
    }
}






