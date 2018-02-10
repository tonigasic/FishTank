using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NetCoreProjekt.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NetCoreProjekt.Controllers
{
    public class removeFish : Controller
    {
        private Fish db = new Fish();
        // GET: /<controller>/
        public IActionResult Index()
        {
            ICollection<Tank> fish = db.Tank.ToList();
            return View(fish);
        }

        
        public IActionResult Remove(int id)
        {
            var removeFish = from fish in db.Tank
                              where fish.Id == id
                              select fish; //db.Tank.FirstOrDefault(b=>b.Id==id);
            foreach (var fish in removeFish)
            {
                db.Tank.Remove(fish);
            }
            
            db.SaveChanges();
        
            
            return RedirectToAction("Index");
        }
    }
    
}
