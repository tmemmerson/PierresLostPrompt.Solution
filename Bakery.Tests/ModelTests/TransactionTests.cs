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
      //arrange
      string transactionNote = "test";
      string transactionDate = "test";
      string transactionItem = "test";
      string transactionQuantity = "test";
      string transactionPrice = "test";
      string transactionBalance = "test";
      
      //act
      Transaction newTransaction = new Transaction(transactionNote, transactionDate, transactionItem, transactionQuantity, transactionPrice, transactionBalance);
      string result = newTransaction.TransactionNote;
      
      //assert
      Assert.AreEqual(transactionNote, result);
    }

    [TestMethod]
    
    public void SetTransactionNote_SetTransactionNote_String()
    {
      //arrange
      string transactionNote = "wonderful and pleasant man";
      string transactionDate = "test";
      string transactionItem = "test";
      string transactionQuantity = "test";
      string transactionPrice = "test";
      string transactionBalance = "test";
      Transaction newTransaction = new Transaction(transactionNote, transactionDate, transactionItem, transactionQuantity, transactionPrice, transactionBalance);

      //act
      string updatedDescription = "horribly unpleasant man";
      newTransaction.TransactionNote = updatedDescription;
      string result = newTransaction.TransactionNote;

      //assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_TransactionList()
    {
      // Arrange
      List<Transaction> newTransaction = new List<Transaction> { };

      // Act
      List<Transaction> result = Transaction.GetAll();

      // Assert
      CollectionAssert.AreEqual(newTransaction, result);
    }    
  }
}