using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NetCoreProjekt.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NetCoreProjekt.Controllers
{
    public class AddFish : Controller
    {
        private Fish db = new Fish();
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult AddFishes()
        {
            Tank fish = new Tank()
            {
                Name = Request.Form["Name"],
                Agressivity = Request.Form["Agressivity"],
                CareLevel = Request.Form["CareLevel"],
                Size = Request.Form["Size"],
                Species = Request.Form["Species"],
                Type = Request.Form["Type"]
            };

            db.Tank.Add(fish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
