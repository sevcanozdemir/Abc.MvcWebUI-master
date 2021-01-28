using Abc.MvcWebUI.Entity;
using Abc.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abc.MvcWebUI.Controllers
{
    public class OrderController : Controller
    {
        DataContext db = new DataContext();
        // GET: Order
        public ActionResult Index()
        {
            var orders = db.Orders.Select(i => new AdminOrderModel()
            {
                Id = i.Id,
                OrderNumber = i.OrderNumber,
                Total = i.Total,
                Count = i.OrderLines.Count,
                Username = i.Username,
                Adres = i.Adres,
                AdresBasligi = i.AdresBasligi,
                Sehir=i.Sehir,
                Semt=i.Semt,
                Mahalle=i.Mahalle



            }).ToList();

            return View(orders);

        }

    }
}