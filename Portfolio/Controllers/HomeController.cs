using System.Linq;
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

        public ActionResult Inquiries()
        
        {
            var inquiries = _repo.GetInquiries().ToList();
            return View(inquiries);
        }

        public ActionResult Save(Inquiry inquiry)
        {
            _repo.SaveInquiry(inquiry);    

            return RedirectToAction("Index");
        }
    }
}