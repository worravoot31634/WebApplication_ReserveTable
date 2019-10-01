using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReserveTable.Models
{
    public class Menu
    {
        [Key]
        public int MenuID {get; set;}
        public String MenuName { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public String MenuImage { get; set; }
        public int Visible { get; set; }
        public int AcceptedStatus { get; set; }
    }
}