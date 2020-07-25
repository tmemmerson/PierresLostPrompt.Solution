using System.Collections.Generic;

namespace Bakery.Models
{
  public class Transaction
  {
    public int Id {get; }
    public string TransactionDate {get; set;}
    public string TransactionItem {get; set;}
    public string TransactionQuantity {get; set;}
    public string TransactionPrice {get; set;}
    public string TransactionNote {get; set;}
    public string TransactionBalance {get; set;}

    private static List<Transaction> _instances = new List<Transaction> { };

    public Transaction(string transactionDate, string transactionItem, string transactionQuantity, string transactionPrice, string transactionNote, string transactionBalance)
    {
      TransactionDate = transactionDate;
      TransactionItem = transactionItem;
      TransactionQuantity = transactionQuantity;
      TransactionPrice = transactionPrice;
      /* TransactionNote = transactionNote; */
      TransactionBalance = transactionBalance;
      _instances.Add(this);
      Id = _instances.Count;
    }


    public static List<Transaction> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Transaction Find(int searchId)
    {
      return _instances[searchId -1];
    }
    
  }
}