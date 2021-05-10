using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueJsStudy.Controllers
{
    public class VueAjaxAxiosController : Controller
    {
        // GET: VueAjaxAxios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {

            List<Student> list = new List<Student> {
                new Student { Name = "LC",Sex="男" ,StudentNumber="124545"},
                new Student { Name = "陈铭",Sex="女",StudentNumber="20153356"}
            };


            return Json(new { List = list, IsTrue = true },JsonRequestBehavior.AllowGet);

        }










        public ActionResult TestWeb() {


            return View();

        }

        public class Student
        {

            public string Name { get; set; }
            public string Sex { get; set; }
            public string StudentNumber { get; set; }




        }



    }
}