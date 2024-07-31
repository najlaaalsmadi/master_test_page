using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Web.UI.WebControls;

namespace master_test_page.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //if (Session["UserEmail"] == null)
            //{
            //    return RedirectToAction("Login");
            //}

            return View();
        }
        public ActionResult Lesson()
        {
            return View();
        }
        public ActionResult Handicrafts()
        {
            return View();
        }
        
            public ActionResult ViewCourse()
        {
            return View();
        }
        
        public ActionResult card()
        {
            return View();
        }
        
            public ActionResult Logout()
        {
            // حذف البيانات من الجلسة
            Session.Clear();

            // إعادة توجيه المستخدم إلى صفحة تسجيل الدخول
            return RedirectToAction("Login");
        }

        //public ActionResult singup()
        //{
        //    return View();
        //}
        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult CourseDetails()
        {
            return View();
        }
        public ActionResult AllEvents()
        {
            return View();
        }
        public ActionResult EventsDetails()
        {
            return View();
        }
        
        public ActionResult shop()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult InstructorsDetails()
        {
            return View();
        }
        public ActionResult profile()
        {
            return View();
        }
      
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application About page.";

            return View();
        }
        //public ActionResult AllInstructors()
        //{
        //    ViewBag.Message = "Your application AllInstructors page.";

        //    return View();
        //}
        public ActionResult Paymentsuccess()
        {
            return View();
        }
        public ActionResult Payment() { return View(); }
        public ActionResult AllInstructors() {

            return View();
        }
        public ActionResult Rental()
        {
            ViewBag.Message = "Your application Rental page.";

            return View();
        }
        public ActionResult shopdetails()
        {
            ViewBag.Message = "Your application   shop details page.";

            return View();
        }
        public ActionResult page404()
        {
            ViewBag.Message = "Your application   shop details page.";

            return View();
        }
      
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
      

        private static List<string[]> students = new List<string[]>();
        public ActionResult singup(string FirstName, string LastName, string Email, string Password, string ConfirmPassword)
        {
            if (Password == ConfirmPassword)
            {
                // تخزين البيانات في المصفوفة
                string[] studentData = new string[] { FirstName, LastName, Email, Password };
                students.Add(studentData);

                // إعادة توجيه إلى صفحة النجاح
                ViewBag.Message = "Registration successful!";
            }
            else
            {
                // عرض رسالة خطأ
                ViewBag.Message = "Passwords do not match.";
            }

            return View();
        }
        public ActionResult Login_Access(string Email, string Password)
        {
            bool isValidUser = false;

            // تحقق من بيانات المستخدم
            foreach (var student in students)
            {
                if (student[2] == Email && student[3] == Password)
                {
                    isValidUser = true;
                    break;
                }
            }

            if (isValidUser)
            {
                // تخزين البريد الإلكتروني في الجلسة
                Session["UserEmail"] = Email;
                ViewBag.Message = "Login successful!";
                return RedirectToAction("shop");
            }
            else
            {
                ViewBag.Message = "Invalid email or password.";
            }

            return View("Login");
        }
        public ActionResult Send_Message(string message1,string name1,string email1,string phone1)
        {
            ViewBag.Message1=message1;
            ViewBag.Name1 = name1;
            ViewBag.Email1 = email1;
            ViewBag.Phone1 = phone1; 
            return View("Contact");
        }
    }
}