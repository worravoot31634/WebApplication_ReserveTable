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
        BookingDetails model = new BookingDetails();
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

            [HttpGet]
        public ActionResult GetStatus(DateTime DateIn, TimeSpan TimeIn, TimeSpan TimeOut)
        {
             int numTimeIn, numTimeOut;
            var DateConvert = DateIn.Date;
            var DataBookingDate = context.Bookings.ToList().Where(ParmDate => ParmDate.DateIn == DateConvert);
            BookingDetails bkd = new BookingDetails();

            List<BookingDetails> TableStatus;

            if (DataBookingDate != null)
            {

               

               
          
                foreach (var item in DataBookingDate)
                {


                   numTimeIn = TimeSpan.Compare(TimeIn, item.TimeOut.Value);
                   numTimeOut = TimeSpan.Compare(TimeOut,item.TimeIn.Value);
                    
                    if (0 == 0)
                    {
                        var DataBookingDetail = conBookingDetail.BookingDetail.ToList().Where(detail => detail.BookingID == item.BookingID);

                        TableStatus = new List<BookingDetails>()
                        {
                            new BookingDetails {BookingID= item.BookingID}
                        };
                        return Content(""+TableStatus) ;
                    }
                    else if (numTimeIn + numTimeOut == 1 || numTimeIn + numTimeOut == -1)
                    {
                      
                        var DataBookingDetail = conBookingDetail.BookingDetail.ToList().Where(detail => detail.BookingID == item.BookingID);
                        TableStatus = new List<BookingDetails>()
                        {
                            new BookingDetails {BookingID= item.BookingID}
                        };
                        return Json(TableStatus, JsonRequestBehavior.AllowGet);
                    }
                    else if (numTimeIn + numTimeOut == 2 || numTimeIn + numTimeOut == -2)
                    {
                       TableStatus = new List<BookingDetails>()
                        {
                            new BookingDetails {BookingID= item.BookingID}
                        };
                        TableStatus = new List<BookingDetails>()
                        {
                            new BookingDetails {BookingID= item.BookingID}
                        };
                        return Json(TableStatus, JsonRequestBehavior.AllowGet);
                    }

                    

                }

                
            }



            return View();

        }

        public ActionResult OrderMenu()
        {
            return View();
        }




    }
}
    
