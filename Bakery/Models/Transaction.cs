using System.Collections.Generic;

namespace Bakery.Models
{
  public class Transaction
  {

    public string Description {get; set;}

    public int Id {get; }

    public string TransactionPrice {get; set;}

    private static List<Transaction> _instances = new List<Transaction> { };

    public Transaction(string description, string transactionPrice)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      TransactionPrice = transactionPrice;

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