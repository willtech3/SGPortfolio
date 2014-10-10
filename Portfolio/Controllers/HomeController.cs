using System.Web.Mvc;
using Portfolio.Code;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var inquiry = _unitOfWork.Repository.GetTopInquiry();
            return View(inquiry);
        }

        public void Save(Inquiry inquiry)
        {
            _unitOfWork.Repository.SaveInquiry(inquiry);
            _unitOfWork.Save();
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