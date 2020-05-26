
using DataAccess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace JadwalKuliah.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Searching(string search)
        {
            if (search!="" && JadwalRepo.GetBySearch(search).Count!=0)
            {
                return PartialView("_List", JadwalRepo.GetBySearch(search));
            }
            return PartialView("_NotFound");
            
            
                       
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}