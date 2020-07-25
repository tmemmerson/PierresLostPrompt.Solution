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
      // arrange
      List<Transaction> newTransaction = new List<Transaction> { };

      // act
      List<Transaction> result = Transaction.GetAll();

      // assert
      CollectionAssert.AreEqual(newTransaction, result);
    }

    [TestMethod]
    public void GetAll_ReturnsTransactions_TransactionList()
    {
      //arrange
      string descriptionA = "nice";
      string descriptionB = "mean";
      string transactionDate = "1";
      string transactionItem = "2";
      string transactionQuantity = "3";
      string transactionPrice = "4";
      string transactionBalance = "5";
      Transaction newTransactionA = new Transaction(descriptionA, transactionDate, transactionItem, transactionQuantity, transactionPrice, transactionBalance);
      Transaction newTransactionB = new Transaction(descriptionB, transactionDate, transactionItem, transactionQuantity, transactionPrice, transactionBalance);
      List<Transaction> newList = new List<Transaction> { newTransactionA, newTransactionB };

      //act
      List<Transaction> result = Transaction.GetAll();

      //assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_TransactionInstantiateWithAnIdAndGetterReturns_Int()
    {
      //arrange
      string transactionNote = "loyal customer";
      string transactionDate = "1";
      string transactionItem = "2";
      string transactionQuantity = "3";
      string transactionPrice = "4";
      string transactionBalance = "5";
      Transaction newTransaction = new Transaction(transactionNote, transactionDate, transactionItem, transactionQuantity, transactionPrice, transactionBalance);

      //act
      int result = newTransaction.Id;

      //assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectTransaction_Transaction()
    {
      //arrange
      string transactionNoteA = "sketchy dude";
      string transactionNoteB = "most loyal customer";
      string transactionDate = "1";
      string transactionItem = "2";
      string transactionQuantity = "3";
      string transactionPrice = "4";
      string transactionBalance = "5";
      Transaction newTransactionA = new Transaction(transactionNoteA, transactionDate, transactionItem, transactionQuantity, transactionPrice, transactionBalance);
      Transaction newTransactionB = new Transaction(transactionNoteB, transactionDate, transactionItem, transactionQuantity, transactionPrice, transactionBalance);

      //act
      Transaction result = Transaction.Find(2);

      //assert
      Assert.AreEqual(newTransactionB, result);
    }
  }
}