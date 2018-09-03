using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Your Gallery page.";

            return View();
        }
        public ActionResult InstallmentProcedure()
        {
            ViewBag.Message = "Your InstallmentProcedure page.";

            return View();
        }
        public ActionResult Laptop()
    {
        ViewBag.Message = "Your Laptop page.";

        return View();
    }
        public ActionResult Mobile()
        {
            ViewBag.Message = "Your Mobile page.";

            return View();
        }
        public ActionResult Tablet()
        {
            ViewBag.Message = "Your Tablet page.";

            return View();
        }
        public ActionResult chooseinstallmentplane()
        {
            ViewBag.Message = "Your chooseinstallmentplane page.";

            return View();
        }
        public ActionResult chooseinstallmentplaneiphone256GB()
        {
            ViewBag.Message = "Your chooseinstallmentplane page.";

            return View();
        }
        public ActionResult chooseinstallmentplaneiphonex256gb()
        {
            ViewBag.Message = "Your chooseinstallmentplane 256gb iphonex page.";

            return View();
        }
        public ActionResult chooseinstallmentplanehuwaieplitepr020()
        {
            ViewBag.Message = "Your chooseinstallmentplane page.";

            return View();
        }
        public ActionResult chooseinstallmentplanesumsangj7pr0()
        {
            ViewBag.Message = "Your chooseinstallmentplane  sumsanh j7 propage.";

            return View();
        }
        public ActionResult chooseinstallmentplaneHuwaeiy7()
        {
            ViewBag.Message = "Your chooseinstallmentplane  sumsanh j7 propage.";

            return View();
        }
        public ActionResult chooseinstallmentdellinspiration5567()
        {
            ViewBag.Message = "Your chooseinstallmentplane dellinspiration556e.";

            return View();
        }
        public ActionResult chooseinstallmenthp6thgenration()
        {
            ViewBag.Message = "Your chooseinstallmentplane hp6thgenration.";

            return View();
        }
        public ActionResult chooseinstallmentsumsangtab4()
        {
            ViewBag.Message = "Your chooseinstallmentplane sumsang tab4.";

            return View();
        }
        public ActionResult chooseinstallmentsumsangtabE()
        {
            ViewBag.Message = "Your chooseinstallmentplane sumsang tabE.";

            return View();
        }
        public ActionResult chooseinstallmentsumsangtas2()
        {
            ViewBag.Message = "Your chooseinstallmentplane sumsang tabs2.";

            return View();
        }
         
    }
}