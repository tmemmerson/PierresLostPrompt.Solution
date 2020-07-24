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
  }
}