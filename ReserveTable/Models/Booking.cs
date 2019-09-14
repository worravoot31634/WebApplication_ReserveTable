namespace ReserveTable.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int BookingID { get; set; }

        public int? AccountID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateIn { get; set; }

        public TimeSpan? TimeIn { get; set; }

        public TimeSpan? TimeOut { get; set; }

        [StringLength(2)]
        public string CheckColor { get; set; }
    }
}
