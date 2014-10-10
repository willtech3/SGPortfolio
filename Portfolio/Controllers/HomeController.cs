using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Code;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repo;
        public HomeController()
        {
        }
        public HomeController(IRepository repository)
        {
            _repo = repository;
        }
        public ActionResult Index()
        {
            var inquiry = _repo.GetTopInquiry();
            return View(inquiry);
        }

        public JsonResult Save(Inquiry inq)
        {
            return new JsonResult(){};
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