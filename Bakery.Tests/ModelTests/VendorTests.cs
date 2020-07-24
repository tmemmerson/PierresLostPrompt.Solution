using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.TestTools
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      //arrange
      Vendor newVendor = new Vendor("vendor name");

      //assert
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //arrange
      string name = "Test";
      Vendor newVendor = new Vendor(name);

      //act
      string result = newVendor.Name;

      //assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //arrange
      string name = "Test";
      Vendor newVendor = new Vendor(name);

      //act
      int result = newVendor.Id;

      //assert
      Assert.AreEqual(1, result);
    }






  }
}