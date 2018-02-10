using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
using ASP.NetCoreProjekt.Models;
using System.Collections.Generic;

namespace ASP.NetCoreProjekt.Controllers
{
    public class MyFishTank : Controller
    {
        private object name;
        private object numTimes;
        private Fish db = new Fish();
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            ICollection<Tank> fish = db.Tank.ToList();
            return View(fish);
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
