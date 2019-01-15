using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewData_ViewBag.Models;

namespace ViewData_ViewBag.Controllers
{
    public class ViewDataViewBagController : Controller
    {
        //
        // GET: /ViewData_ViewBag/

        public ActionResult Index()
        {
            List<ViewDataViewBag> model = new List<ViewDataViewBag>();
            model.Add(new ViewDataViewBag()
            {
                Name = "ankita",
                Address = "muddapur",
                Phone = 9876543210
            });
            model.Add(new ViewDataViewBag()
                {
                    Name = "anisha",
                    Address = "Bhosale",
                    Phone = 487203858730,
                });
            model.Add(new ViewDataViewBag()
            {
                Name = "Bhaveshwari",
                Address = "Bhambar",
                Phone = 2364423747,
            });
            model.Add(new ViewDataViewBag()
            {
                Name = "Pooja",
                Address = "Desai",
                Phone = 747472782473,
            });


            ViewData["Details"] = model;
            TempData["msg"] = "data is sent from temp data";

            return View(ViewData["Details"]);
            
        }
        
    }
}
