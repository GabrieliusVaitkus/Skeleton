using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing3
{

    [TestClass]
    public class TstStaff
    {

        string StaffName = "Gabrielius Vaitkus";
        string StaffAddress = "15 bridge meadow";
        string StaffRole = "Director";
        string StaffMoNumber = "7845123466";
        string StaffBirthDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void StaffNumberOK()
        {
            //Creating instance of a class 
            clsStaff staffNumber = new clsStaff();

            //test to see that it exists
            Assert.IsNotNull(staffNumber);
        }

        [TestMethod]
        public void StaffNameOK()
        {
            //New instance creation
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            string TestData = "Will Smith";

            //Assign the data to the property
            staffNumber.staffName = TestData;

            //Testing to see are two value are the same
            Assert.AreEqual(staffNumber.staffName, TestData);
        }

        [TestMethod]
        public void StaffAddressOK()
        {
            //New instance
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            string TestData = "Knight Avenue 2";

            //Assing data to the property
            staffNumber.staffAddress = TestData;

            //Check if two value are the same
            Assert.AreEqual(staffNumber.staffAddress, TestData);
        }

        [TestMethod]
        public void staffMoNumberOK()
        {
            //New instance
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            String TestData = "7415687415";

            //Assigning data to the property
            staffNumber.staffMoNumber = TestData;

            //test to see if two value are equal
            Assert.AreEqual(staffNumber.staffMoNumber, TestData);
        }

        [TestMethod]
        public void staffRoleOK()
        {
            //New instance
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            string TestData = "Analyst";

            //Assign data to the property
            staffNumber.staffRole = TestData;

            //Comparing the two values
            Assert.AreEqual(staffNumber.staffRole, TestData);
        }

        [TestMethod]
        public void staffBirthDateOK()
        {
            //New instance
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            DateTime TestData = DateTime.Now.Date;

            //Assign data to the property
            staffNumber.staffDateAdded = TestData;

            //Compare the two value
            Assert.AreEqual(staffNumber.staffDateAdded,
                            TestData);
        }

        [TestMethod]
        public void staffActiveOK()
        {
            //Create new instance
            clsStaff staffNumber = new clsStaff();

            //Create test data
            Boolean TestData = true;

            //Assign data to the property
            staffNumber.staffActive = TestData;

            //Compare the two value
            Assert.AreEqual(staffNumber.staffActive, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create new instance
            clsStaff staffNumber = new clsStaff();

            //Boolean var to store the results
            Boolean Found = false;

            //Create test data
            int staffNo = 2;

            //invoke the method
            Found = staffNumber.Find(staffNo);

            //Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //Create an instance of the class
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffNo != 2)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffName != "John Smith")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffAddress != "Mangrove 1")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffMoNumberFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffMoNumber != "7845123456")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffRoleFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffRole != "Manager")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffBirthDateFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffDateAdded != Convert.ToDateTime("18/08/1998"))
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffActiveFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffActive != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffName = "";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffName = "a";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffName = "aa";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMin()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffAddress = "a";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffAddress = "aa";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(49, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMax()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(50, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(51, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMid()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(25, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(500, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinLessOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffRole = "";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMin()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffRole = "a";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffRole = "aa";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMid()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(25, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMax()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(50, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(49, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxPlusOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(51, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleExtremeMax()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(500, 'a');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffMoNumberMinLessOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffMoNumber = "";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffMoNumberMin()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffMoNumber = "1";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffMoNumberMinPlusOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffMoNumber = "11";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffMoNumberMid()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffMoNumber = "111";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffMoNumberMaxLessOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffMoNumber = "";
            StaffMoNumber = StaffMoNumber.PadRight(49, '1');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffMoNumberMax()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffMoNumber = "";
            StaffMoNumber = StaffMoNumber.PadRight(50, '1');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffMoNumberMaxPlusOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffMoNumber = "";
            StaffMoNumber = StaffMoNumber.PadRight(51, '1');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffMoNumberExtremeMax()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffMoNumber = "";
            StaffMoNumber = StaffMoNumber.PadRight(500, '1');
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedExtremeMin()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StaffBirthDate = TestDate.ToString();
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedMinLessOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string StaffBirthDate = TestDate.ToString();
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedMin()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StaffBirthDate = TestDate.ToString();
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedMinPlusOne()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string StaffBirthDate = TestDate.ToString();
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StafDateAddedExtremeMax()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StaffBirthDate = TestDate.ToString();
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateAddedInvalidData()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            string StaffBirthDate = "This is not a date!";
            Error = staffNumber.Valid(StaffName, StaffAddress, StaffRole, StaffMoNumber, StaffBirthDate);
            Assert.AreNotEqual(Error, "");
        }
    }
}
