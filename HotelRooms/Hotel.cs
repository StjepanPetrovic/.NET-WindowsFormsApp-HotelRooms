 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRooms
{
    internal class Hotel
    {
        private List<HotelRoom> HotelRoomsList = new List<HotelRoom>()
        {
            new HotelRoom {
                RoomLabel = "501",
                Capacity = 3
            },

            new HotelRoom {
                RoomLabel = "502",
                Capacity = 2
            },

            new HotelRoom {
                RoomLabel = "503",
                Capacity = 5
            },

            new HotelRoom {
                RoomLabel = "504",
                Capacity = 2
            }
        };

        public List<HotelRoom> GetAllRooms()
        {
            return HotelRoomsList;
        }
    }
}
