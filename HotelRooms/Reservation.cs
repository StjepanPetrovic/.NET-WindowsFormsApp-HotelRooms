using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRooms
{
    internal class Reservation
    {
        public HotelRoom HotelRoom { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
