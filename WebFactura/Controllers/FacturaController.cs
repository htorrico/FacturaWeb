using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebFactura.Models;

namespace WebFactura.Controllers
{
    public class FacturaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexRazor()
        {
            FacturaViewModel model = new FacturaViewModel();
            return View(model);
        }

        [HttpPost]
        public JsonResult GetFacturas()
        {
            //var result = false;
            //var message = "";
            var list = new List<Person>();

            list.Add(new Person
            {
                first_name = "hugo",
                last_name = "torrico",
                office = "Ing.",
                position = "Developer",
                salary = 50,
                start_date = "01-01-2019"
            });


            return new JsonResult(new
            {
                draw = 1,
                recordsTotal = list.Count,
                recordsFiltered = list.Count,
                data = list
            });
        }
    }

    public class Person
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public string office { get; set; }
        public string start_date { get; set; }
        public decimal salary { get; set; }

    }

}