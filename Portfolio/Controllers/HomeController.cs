using System.Web.Mvc;
using Portfolio.Code;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repo;
        public HomeController(IRepository repository)
        {
            _repo = repository;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Save(Inquiry inquiry)
        {
            _repo.SaveInquiry(inquiry);
            return RedirectToAction("Index");

        }
    }
}