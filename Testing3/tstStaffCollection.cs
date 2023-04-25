using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.staffNo = 2;
            TestItem.staffName = "John Smith";
            TestItem.staffAddress = "Mangrove 1";
            TestItem.staffMoNumber = "7845123456";
            TestItem.staffRole = "Manager";
            TestItem.staffDateAdded = DateTime.Parse("18/08/1998");
            TestItem.staffActive = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestAddress = new clsStaff();
            TestAddress.staffNo = 2;
            TestAddress.staffName = "John Smith";
            TestAddress.staffAddress = "Mangrove 1";
            TestAddress.staffMoNumber = "7845123456";
            TestAddress.staffRole = "Manager";
            TestAddress.staffDateAdded = DateTime.Parse("18/08/1998");
            TestAddress.staffActive = true;

            AllStaff.ThisStaff = TestAddress;
            Assert.AreEqual(AllStaff.ThisStaff, TestAddress);
        }

        [TestMethod]
        public void StaffListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.staffNo = 2;
            TestItem.staffName = "John Smith";
            TestItem.staffAddress = "Mangrove 1";
            TestItem.staffMoNumber = "7845123456";
            TestItem.staffRole = "Manager";
            TestItem.staffDateAdded = DateTime.Parse("18/08/1998");
            TestItem.staffActive = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.staffNo = 2;
            TestItem.staffName = "John Smith";
            TestItem.staffAddress = "Mangrove 1";
            TestItem.staffMoNumber = "7845123456";
            TestItem.staffRole = "Manager";
            TestItem.staffDateAdded = DateTime.Parse("18/08/1998");
            TestItem.staffActive = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.staffNo = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.staffName = "John Smith";
            TestItem.staffAddress = "Mangrove 1";
            TestItem.staffMoNumber = "7845123456";
            TestItem.staffRole = "Manager";
            TestItem.staffDateAdded = DateTime.Parse("18/08/1998");
            TestItem.staffActive = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.staffNo = PrimaryKey;
            TestItem.staffName = "Luke Skywalker";
            TestItem.staffAddress = "Death Star 15b";
            TestItem.staffMoNumber = "8185153456";
            TestItem.staffRole = "Leader";
            TestItem.staffDateAdded = DateTime.Parse("15/02/1990");
            TestItem.staffActive = false;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.staffNo = 2;
            TestItem.staffName = "John Smith";
            TestItem.staffAddress = "Mangrove 1";
            TestItem.staffMoNumber = "7845123456";
            TestItem.staffRole = "Manager";
            TestItem.staffDateAdded = DateTime.Parse("18/08/1998");
            TestItem.staffActive = true;
            AllStaff.ThisStaff = TestItem;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.staffNo = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByStaffRoleMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredRoles = new clsStaffCollection();
            FilteredRoles.ReportByStaffRole("");
            Assert.AreEqual(AllStaff.Count, FilteredRoles.Count);
        }

        [TestMethod]
        public void ReportByStaffRoleTestDataFound()
        {
            clsStaffCollection FilteredRoles = new clsStaffCollection();
            Boolean OK = true;
            FilteredRoles.ReportByStaffRole("Manager");
            if (FilteredRoles.Count == 2)
            {
                if (FilteredRoles.StaffList[0].staffNo != 10)
                {
                    OK = false;
                }

                if (FilteredRoles.StaffList[1].staffNo != 11)
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
