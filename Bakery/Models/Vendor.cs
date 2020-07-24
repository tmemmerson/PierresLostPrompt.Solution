using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Transaction> Transactions { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Transactions = new List<Transaction> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
    return _instances;
    }

    public static Vendor Find(int searchId)
    {
      /* return _instances[searchId-1]; */
    }

    public void AddTransaction(Transaction transaction)
    {
      Transactions.Add(transaction);
    }
  }
}