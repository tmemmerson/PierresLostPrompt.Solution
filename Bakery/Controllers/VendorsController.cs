using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpsGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

    [HttpsGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Transaction> vendorTransactions = selectedVendor.Transactions;
      model.Add("vendor", selectedVendor);
      model.Add("transactions", vendorTransactions);
      return View(model);

      [HttpsPost("/vendors/{vendorID}/transactions")]
      public ActionResult Create(int vendorId, string transactionDescription)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor foundVendor = Vendor.Find(vendorId);
        Transaction newTransaction = new Transaction(transactionDescription);
        foundVendor.AddTransaction(newTransaction);
        List<Transaction> vendorTransactions = foundVendor.Transactions;
        model.Add("transactions", vendorTransactions);
        model.Add("vendor", foundVendor);
        return View("Show", model);
      }
    }
  }