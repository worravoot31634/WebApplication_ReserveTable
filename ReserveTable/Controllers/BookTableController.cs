using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReserveTable.Models;


namespace ReserveTable.Controllers
{
    public class BookTableController : Controller
    {
        BookingModels context = new BookingModels();
        BookingDetailsModels conBookingDetail = new BookingDetailsModels();
        NanRestaurantEntities1 db = new NanRestaurantEntities1();
        Menu menu = new Menu();

        // GET: BookTable
        public ActionResult Index()
        {
            return View();
        }

        /*public JsonResult getStatusTable(DateTime date,DateTime timeIn,DateTime timeOut)
        {
           

            List<Booking> bookings = new List<Booking>();

           var DataBooking = context.Bookings.Where(dateIn => dateIn.DateIn == date).Count();





            return Json(DataBooking, JsonRequestBehavior.AllowGet);
        }*/

         public ActionResult GetStatus()
        {

            return View();
        }
        [HttpGet]
        public ActionResult GetStatus(DateTime DateIn, TimeSpan TimeIn, TimeSpan TimeOut)
        {

            var model = db.Bookings.ToList();

            
            string timein = TimeIn.ToString("HH");

            foreach (var item in model)
            {

                // sumIn = in.split(":");
                /* sumOut = out.split(":"); // Time out by user and convert to string
                 sumIn = in.split(":"); // Time in by user and convert to string
                 numIn = arInDb[i].split(":"); // convert time In from db to string
                 numOut = arOutDb[i].split(":"); // convert time out from db to string

                 int hourInputOut = Integer.parseInt(sumOut[0]); // convert time Out by user from string to int hour

                 int minInputOut = Integer.parseInt(sumOut[1]); // convert time Out by user from string to int minuses

                 int hourInputIn = Integer.parseInt(sumIn[0]); // convert time In by user from string to int hour

                 int minInputIn = Integer.parseInt(sumIn[1]); // convert time In by user from string to int minuses

                 int hourInDb = Integer.parseInt(numIn[0]); // convert time form db from string to int hour In
                 int minInDb = Integer.parseInt(numIn[1]); // convert time by form db from string to int minuses In

                 int hourOutDb = Integer.parseInt(numOut[0]); // convert time form db from string to int hour Out
                 int minOutDb = Integer.parseInt(numOut[1]); // convert time by form db from string to int minuses Out

                 System.out.println(" Hour Input Out = " + hourInputOut + " Hour In Db = " + hourInDb);
                 System.out.println(" Min Input Out = " + minInputOut + " Min In Db = " + minInDb);

                 System.out.println(" Hour In Input = " + hourInputIn + " Hour Out Db = " + hourOutDb);
                 System.out.println(" Min In Input = " + minInputIn + " Min Out Db = " + minOutDb);

                 if (hourInputOut < hourInDb)
                 { // compare hour

                     System.out.println("Can");

                 }
                 else if (hourInputOut >= hourInDb)
                 {

                     if (hourInputOut != hourInDb)
                     {

                         if (hourInputOut > hourInDb)
                         {

                             if (hourInputIn >= hourOutDb)
                             {
                                 if (hourInputIn == hourOutDb)
                                 {
                                     if (minInputIn > minOutDb)
                                     {
                                         System.out.println("Can 99");
                                     }
                                     else
                                     {
                                         System.out.println("Can not");
                                     }
                                 }
                                 else
                                 {
                                     if (hourInputIn > hourInDb)
                                     {
                                         System.out.println("Can 888");
                                     }
                                     else
                                     {
                                         System.out.println("Can not");
                                     }
                                 }
                             }
                             else
                             {
                                 System.out.println("Can not 66-");
                             }
                         }
                         else
                         {
                             if (minInputOut < minInDb)
                             { // compare minuses
                                 if (hourInputOut == hourInDb)
                                 {
                                     System.out.println("Can 222");
                                 }
                                 else
                                 {
                                     if (hourInputIn < hourOutDb)
                                     { // check font

                                         System.out.println("Can not");

                                     }
                                     else if (hourInputIn >= hourOutDb)
                                     {

                                         if (minInputIn > minOutDb)
                                         {
                                             System.out.println("Can");
                                         }
                                         else if (minInputIn <= minOutDb)
                                         {
                                             System.out.println("Can not 11");
                                         }
                                     } // end of check font
                                 }

                             }
                             else if (minInputOut >= minInDb)
                             {

                                 if (minInputOut == minInDb)
                                 {
                                     System.out.println("Can 333");
                                 }
                                 else if (minInputOut > minInDb)
                                 {
                                     System.out.println("Can not 44");
                                 }
                             }
                             else
                             {
                                 {
                                     if (minInputIn > minOutDb)
                                     {
                                         System.out.println("Can ***");
                                     }
                                     else
                                     {
                                         System.out.println("Can not***"); // ***
                                     }
                                 }

                             }
                         }

                     }
                     else
                     {
                         if (minInputIn < minInDb)
                         {
                             System.out.println("Can 999");
                         }
                         else
                         {
                             System.out.println("Can not 555");
                         }

                     }

                 } // end of if compare hour
             }

         } */
            }
            return Content(timein);
        }

        public ActionResult OrderMenu1()
        {

            var model = db.Menus.ToList();

            return View(model);
        }




    }
}
    
