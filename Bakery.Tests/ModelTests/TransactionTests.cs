using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.TestTools
{
  [TestClass]
  public class TransactionTest : IDisposable
  {
    public void Dispose()
    {
      Transaction.ClearAll();
    }
  
  [TestMethod]
    public void GetNote_ReturnsNote_String()
    {
      string transactionNote = "test";
      string transactionDate = "test";
      string transactionItem = "test";
      string transactionQuantity = "test";
      string transactionPrice = "test";
      string transactionBalance = "test";
      Transaction newTransaction = new Transaction(transactionNote, transactionDate, transactionItem, transactionQuantity, transactionPrice, transactionBalance);
      string result = newTransaction.TransactionNote;

      Assert.AreEqual(transactionNote, result);
    }
  }
}