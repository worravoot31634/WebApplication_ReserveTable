using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReserveTable.Models;
using Microsoft.Ajax.Utilities;

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

        
        [HttpPost]
        public ActionResult GetStatus(DateTime DateIn, TimeSpan TimeIn, TimeSpan TimeOut)
        {

            var model = db.Bookings.ToList();

            string HourIn = TimeIn.Hours.ToString();
            string HourOut = TimeOut.Hours.ToString();
            string minIn = TimeIn.Minutes.ToString();
            string minOut = TimeOut.Minutes.ToString();


            // User time data
            int IntHourIn, IntHourOut , IntminIn , IntminOut;
            IntHourIn = int.Parse(HourIn);
            IntHourOut = int.Parse(HourOut);
            IntminIn = int.Parse(minIn);
            IntminOut = int.Parse(minOut);

            string answer = "";

            string HourInDB="" , HourOutDB = "" , minInDB = "" , minOutDB = "";
            int IntHourInDB, IntHourOutDB, IntminInDB, IntminOutDB;

            // create json 

            List<JsonTableStatus> jsonTableStaus = new List<JsonTableStatus>();

            var query2 = from b in db.Bookings
                         join bd in db.BookingDetails on b.BookingID equals bd.BookingID
                         where ((b.DateIn == DateIn) && ((b.TimeIn >=TimeIn && b.TimeOut <= TimeOut)  || ((b.TimeOut.Value.Hours <= 12) && (TimeIn < b.TimeIn && TimeIn <= b.TimeOut)) /**/ || ((b.TimeOut.Value.Hours <= 12) && (TimeIn > b.TimeIn && TimeIn <= b.TimeOut)) /**/|| ((b.TimeIn.Value.Hours>=12) &&(b.TimeOut>=TimeIn && TimeOut >= b.TimeOut )) || ((b.TimeIn.Value.Hours >= 12) && (b.TimeOut > TimeIn && TimeOut >= b.TimeIn)) )  && ((b.CheckColor == "1") || (b.CheckColor == "0") || (b.CheckColor == "2")))
                         select new { bd.TableID, b.CheckColor };

            var publishers2 = query2.ToList();
            foreach (var itemModel in publishers2)
            {

                jsonTableStaus.Add(new JsonTableStatus { TableID = "T" + itemModel.TableID, StatusID = itemModel.CheckColor });

            }
            return Json(jsonTableStaus, JsonRequestBehavior.AllowGet);
        } //end of get Status

        public ActionResult OrderMenu1()
        {

            var model = db.Menus.ToList();

            return View(model);
        }


        public ActionResult OrderMenu()
        {

            var model = db.Menus.ToList();

            return View(model);
        }
    }
}
    
