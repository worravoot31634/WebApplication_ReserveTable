using ReserveTable.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReserveTable.Controllers
{
    public class HomeController : Controller
    {
        NanRestaurantEntities5 db = new NanRestaurantEntities5();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            Account ac = new Account();
            Member member = new Member();
            int name = -1;
          
         
            HttpPostedFileBase fileUp = Request.Files["UploadFile"];
            if (ModelState.IsValid)
            {
                 ac.Username = form["username"];
                 ac.Password = form["psw"];
                 ac.RegisterDate = DateTime.Now;
                 ac.Role = "member";
                 db.Accounts.Add(ac);
                 db.SaveChanges();
                 string username = form["username"];
                 string password = form["psw"];
                 var query = db.Accounts.Where(x => x.Username == username && x.Password == password);

                 foreach (var item in query)
                 {
                     member.AccountID= item.AccountID;
                 }


                // upload file

                //string filename = form["myfile"];



                  member.FirstName = form["name"];
                  member.SurName = form["surname"];
                  member.Email = form["email"];
                  member.PhoneNo = form["phone_number"];
                  member.Address = form["address"];
                if (fileUp.ContentLength > 0)
                {
                    var filename = Path.GetFileName(fileUp.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/images/member"), filename);
                    fileUp.SaveAs(path);
                    member.img = filename;
                }
                db.Members.Add(member);
                db.SaveChanges();
            }
           
            return RedirectToAction("Login" , "Account");
        }


        [HttpPost]
        public ActionResult Login(FormCollection login)
        {
            string Role = "";
            string username = login["usrnameLogin"];
            string password = login["pswLogin"];

            MemberLogin memberLogin = new MemberLogin();
            var model = db.Accounts.Where(x => x.Username == username && x.Password == password);

          
            if (model != null)
            {
                foreach (var item in model)
                {
                    Role = item.Role;
                    
                    Session["Username"] = item.Username;
                    if (item.Role == "member")
                    {
                       
                        return RedirectToAction("Login", "Account");

                    }
                    else if (item.Role == "Cashier")
                    {
                        return RedirectToAction("");

                    }
                    else if (item.Role == "Barista")
                    {
                        return RedirectToAction("");
                    }
                    else if (item.Role == "chef")
                    {
                        return RedirectToAction("");
                    }
                    else if (item.Role == "manger")
                    {
                        return RedirectToAction("");
                    } 
                }
            
            }
            
            return Content("");
        }

        public ActionResult Logout()
        {

            Session.Remove("Username");
            return View("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Promotion1()
        {

            return View();
        }
        public ActionResult Promotion2()
        {

            return View();
        }
        public ActionResult Promotion3()
        {

            return View();
        }
        public ActionResult Promotion4()
        {

            return View();
        }
        public ActionResult Promotion5()
        {

            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult ReserveHistory()
        {
            return View();
        }

    }
}