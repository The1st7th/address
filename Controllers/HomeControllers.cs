using Microsoft.AspNetCore.Mvc;
using Addressbook.Models;
using System;
using System.Collections.Generic;

namespace Addressc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/form")]
        public ActionResult Form()
        {
          return View();
        }
    
        [HttpPost("/newcontact")]
        public ActionResult added()
        {
          Console.WriteLine("hello");
          Address newcontact = new Address();
          newcontact.Setname(Request.Form["name"]);
          newcontact.Setaddress(Request.Form["address"]);
          newcontact.Setphone(Request.Form["phone"]);
          Console.WriteLine(newcontact.Getname());
          newcontact.Save();
          List<Address> all = Address.Getall();
          return View("Homepage", all);
        }
        [HttpGet("/")]
        public ActionResult Homepage()
        {
           List<Address> all = Address.Getall();
          return View(all);
        }
        
      [HttpPost("/delete")]
        public ActionResult DeleteAll()
        {
            Address.ClearAll();
            return RedirectToAction("Homepage");
        }
    }
}