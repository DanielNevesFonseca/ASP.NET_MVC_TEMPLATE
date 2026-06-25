using System.Web.Mvc;
using MyApplication.Filters;

namespace MyApplication.Controllers
{
    [LogFilter]
    public partial class HomeController : Infrastructure.BaseController
    {
        public HomeController() : base()
        {
        }

        [HttpGet]
        public virtual ViewResult Index()
        {
            string msg = "Hahaha";
            ViewBag.Message = msg.Length;
            return View();
        }


        public FileResult OpenSchoolEnrollmentForm()
        {


            string filePath = Server.MapPath("~/Content/files/school-enrrolment.pdf");
            return File(filePath, "application/pdf", "SchoolEnrollment.pdf");
        }
    }
}
