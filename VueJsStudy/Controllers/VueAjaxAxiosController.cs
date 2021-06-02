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


            return Json(new { List = list, IsTrue = true }, JsonRequestBehavior.AllowGet);

        }


        public ActionResult GetList2()
        {


            string name = Request["name"].ToString();


            List<Student> list = new List<Student> {
                new Student { Name = "陈铭",Sex="男" ,StudentNumber="124545"},
                new Student { Name = "ke",Sex="女",StudentNumber="20153356"},
                new Student{ Name="LC",Sex="男",StudentNumber="2015112393"}
            };


            return Json(new { List = list, IsTrue = true }, JsonRequestBehavior.AllowGet);

        }



        [HttpPost]
        public ActionResult GetTableTest()
        {
            
            List<UserInfo> Userlist = new List<UserInfo> {

                new UserInfo { num=1,username="LC",avatar="lc",phone=124545725,email="1784455078@qq.com"},
               new UserInfo { num=1,username="La",avatar="lc",phone=124545725,email="1784455078@qq.com"},
               new UserInfo { num=1,username="Lb",avatar="lc",phone=124545725,email="1784455078@qq.com"},
                new UserInfo { num=1,username="Ld",avatar="lc",phone=124545725,email="1784455078@qq.com"},

            };

            return Json(new { List = Userlist, IsTrue = true }, JsonRequestBehavior.AllowGet);
        }






        public ActionResult TestWeb()
        {


            return View();

        }


        public ActionResult GetVueElement() {


            List<StuClass> List = new List<StuClass>();
            List.Add(new StuClass { id = 12, name = "王三", amount1 = 12.1, amount2 = 12.3, amount3 = 12.4 });
            List.Add(new StuClass { id = 13, name = "李四", amount1 = 12.1, amount2 = 12.3, amount3 = 12.4 });
            List.Add(new StuClass { id = 14, name = "赵柳", amount1 = 12.1, amount2 = 12.3, amount3 = 12.4 });
            return Json(new { List = List, IsTrue = true }, JsonRequestBehavior.AllowGet);
        }


        public class Student
        {
            public string Name { get; set; }
            public string Sex { get; set; }
            public string StudentNumber { get; set; }
        }



        //id: '12987126',
        //name: '王小刚',
        //amount1: '539',
        //amount2: '4.1',
        //amount3: 15
        /// <summary>
        /// 结构体
        /// </summary>
        public struct StuClass {
            public int id { get; set; }
            public string name { get; set; }
            public double amount1 { get; set; }
            public double amount2 { get; set; }
            public double amount3 { get; set; }

        }

        public class UserInfo
        {
            public int num { get; set; }
            public string username { get; set; }
            public string avatar { get; set; }
            public int phone { get; set; }
            public string email { get; set; }


        }


        public ActionResult VueTableWeb()
        {




            return View();
        }


    }
}