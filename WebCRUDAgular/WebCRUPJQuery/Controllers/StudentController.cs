using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebCRUD.Bussines.Interfaces;
using WebCRUD.Data.RepositoryContract;

namespace WebCRUPJQuery.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentBussines studentBussines;

        public StudentController(IStudentBussines studentBussines)
        {
            this.studentBussines = studentBussines;
        }

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetAll()
        {
            var list = await studentBussines.GetAllStudent();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}