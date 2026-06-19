using System.Web.Mvc;

namespace MyApplication.Controllers
{
    public partial class HomeController : Infrastructure.BaseController
    {
        public HomeController() : base()
        {
        }

        [HttpGet]
        public virtual ViewResult Index()
        {
            return View();
        }


        public FileResult OpenSchoolEnrollmentForm()
        {
            string filePath = Server.MapPath("~/Content/files/school-enrrolment.pdf");
            return File(filePath, "application/pdf", "SchoolEnrollment.pdf");
        }
    }
}
