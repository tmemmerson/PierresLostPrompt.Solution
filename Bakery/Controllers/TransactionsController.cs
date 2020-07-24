using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class TransactionsController : Controller
  {
    [HttpGet("/vendors/{vendorId}/transactions/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/transactions/{transactionId}")]
    public ActionResult Show(int vendorId, int transactionId)
    {
      Transaction transaction = Transaction.Find(transactionId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("transaction", transaction);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/transactions/delete")]
    public ActionResult DeleteAll()
    {
      Transaction.ClearAll();
      return View();
    }
  }
  }