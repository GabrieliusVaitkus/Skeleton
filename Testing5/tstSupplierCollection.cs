using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.supplierNo = 1;
            TestItem.supplierName = "alibaba";
            TestItem.supplierContactNo = "07856162654";
            TestItem.supplierEmail = "alibaba54@gmail.com";
            TestItem.supplierAddress = "24 shipton road, NN10 9BE";
            TestItem.dateRegistered = DateTime.Parse("20/02/2022");
            TestItem.active = true;

            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.supplierNo = 1;
            TestSupplier.supplierName = "alibaba";
            TestSupplier.supplierContactNo = "07856162654";
            TestSupplier.supplierEmail = "alibaba54@gmail.com";
            TestSupplier.supplierAddress = "24 shipton road, NN10 9BE";
            TestSupplier.dateRegistered = DateTime.Parse("20/02/2022");
            TestSupplier.active = true;

            AllSupplier.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.supplierNo = 1;
            TestItem.supplierName = "alibaba";
            TestItem.supplierContactNo = "07856162654";
            TestItem.supplierEmail = "alibaba54@gmail.com";
            TestItem.supplierAddress = "24 shipton road, NN10 9BE";
            TestItem.dateRegistered = DateTime.Parse("20/02/2022");
            TestItem.active = true;

            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.supplierNo = 1;
            TestItem.supplierName = "alibaba";
            TestItem.supplierContactNo = "07856162654";
            TestItem.supplierEmail = "alibaba54@gmail.com";
            TestItem.supplierAddress = "24 shipton road, NN10 9BE";
            TestItem.dateRegistered = DateTime.Parse("20/02/2022");
            TestItem.active = true;
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.supplierNo = PrimaryKey;
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }

        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.supplierName = "alibaba";
            TestItem.supplierContactNo = "07856162654";
            TestItem.supplierEmail = "alibaba54@gmail.com";
            TestItem.supplierAddress = "24 shipton road, NN10 9BE";
            TestItem.dateRegistered = DateTime.Parse("20/02/2022");
            TestItem.active = true;
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.supplierNo = PrimaryKey;
            TestItem.supplierName = "SportsDirect";
            TestItem.supplierContactNo = "8185153456";
            TestItem.supplierEmail = "8185153456";
            TestItem.supplierAddress = "53 clemence way";
            TestItem.dateRegistered = DateTime.Parse("15/02/2023");
            TestItem.active = false;
            AllSupplier.ThisSupplier = TestItem;
            AllSupplier.Update();
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.supplierNo = 1;
            TestItem.supplierName = "alibaba";
            TestItem.supplierContactNo = "07856162654";
            TestItem.supplierEmail = "alibaba54@gmail.com";
            TestItem.supplierAddress = "24 shipton road, NN10 9BE";
            TestItem.dateRegistered = DateTime.Parse("20/02/2022");
            TestItem.active = true;
            AllSupplier.ThisSupplier = TestItem;
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.supplierNo = PrimaryKey;
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            AllSupplier.Delete();
            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportBySupplierNameMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            FilteredSupplier.ReportBysupplierName("");
            Assert.AreEqual(AllSupplier.Count, FilteredSupplier.Count);
        }

        [TestMethod]
        public void ReportBySupplierNameNoneFound()
        {
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            FilteredSupplier.ReportBysupplierName("xxxxx");
            Assert.AreEqual(0, FilteredSupplier.Count);
        }

        [TestMethod]
        public void ReportBySupplierNameTestDataFound()
        {
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSupplier.ReportBysupplierName("GoPokemon");
            if (FilteredSupplier.Count == 2)
            {
                if (FilteredSupplier.SupplierList[0].supplierNo != 27)
                {
                    OK = false;
                }

                if (FilteredSupplier.SupplierList[1].supplierNo != 28)
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
