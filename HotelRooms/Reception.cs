using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRooms
{
    internal class Reception
    {
        public Hotel Hotel { get; set; } = new Hotel();

        public List<Reservation> ReservationList { get; set; } = new List<Reservation>();

        public List<HotelRoom> GetEmptyRooms(DateTime date)
        {
            List<Reservation> reservationsOnDay = ReservationList.Where(reservation => reservation.ReservationDate == date).ToList();

            List<HotelRoom> roomsOnDay = reservationsOnDay.Select(reservation => reservation.HotelRoom).ToList();

            return Hotel.GetAllRooms().Where(room => roomsOnDay.Contains(room) == false).ToList();
        }

        public void MakeReservation(HotelRoom hotelRoom, DateTime date)
        {
            Reservation newReservation = new Reservation
            {
                HotelRoom = hotelRoom,
                ReservationDate = date,
            };

            ReservationList.Add(newReservation);
        }
    }
}
