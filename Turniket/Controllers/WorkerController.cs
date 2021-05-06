using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turniket.Models;

namespace Turniket.Controllers
{
    public class WorkerController : Controller
    {
        [HttpGet]
        public IActionResult EntryExit()
        {
            using (var context=new TurniketContext())
            {
                ViewBag.Workers = JsonConvert.SerializeObject(context.Workers);
            }
            return View();
        }
        [HttpPost]
        public IActionResult EntryExit(Model model)
        {
            
            if (model.Status)
            {
                var entry = new Entry()
                {
                    WorkerId = model.WorkerId,
                    EntryTime = DateTime.Now
                };
                Add<Entry>(entry);
            }
            else
            {
                var exit = new Exit()
                {
                    WorkerId = model.WorkerId,
                    ExitTime = DateTime.Now
                };
                Add<Exit>(exit);
            }
            return Redirect("~/home/index");
        }
        [HttpGet]
        public IActionResult AddWorker()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWorker(Worker worker)
        {
            Add<Worker>(worker);
            return Redirect("~/home/index");
        }

        public void Add<T>(T model)
            where T:class,new()
        {
            using (var context = new TurniketContext())
            {
                context.Entry<T>(model).State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
