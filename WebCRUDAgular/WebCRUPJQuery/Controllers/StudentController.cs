using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebCRUD.Bussines.Interfaces;
using WebCRUD.Core.ViewModels;
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

        public async Task<ActionResult> _Table()
        {
            var list = await studentBussines.GetAllStudent();
            return PartialView(list);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var result = await studentBussines.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<JsonResult> Update(StudentViewModel student)
        {
            var result = await studentBussines.Update(student);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<JsonResult> AddStudent(StudentViewModel student)
        {
            var result = await studentBussines.AddStudent(student);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> _Form()
        {
            return View();
        }
    }
}