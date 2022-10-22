using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Constanst
{
    public class RoomStatus
    {
        public const string EMPTY = "Sẵn sàng";
        public const string USING = "Đang có khách";
        public const string DIRTY = "Bẩn";
        public const string CLEANING = "Đang dọn dẹp";
        public const string REPAIRING = "Đang sửa chữa";
        public const string BOOK = "Đặt trước";
               
        public const string EMPTY_COLOR = "#2eb82e";
        public const string USING_COLOR = "#ff5c33";
        public const string DIRTY_COLOR = "#808080";
        public const string CLEANING_COLOR = "#1a75ff";
        public const string REPAIRING_COLOR = "#e6ac00";
        public const string BOOK_COLOR = "#ff3399";

        public static List<RoomStatusProperty> getListRoomStatus()
        {
            List<RoomStatusProperty> LIST_ROOM_STATUS = new List<RoomStatusProperty>();

            LIST_ROOM_STATUS.Add(new RoomStatusProperty(EMPTY, EMPTY_COLOR));
            LIST_ROOM_STATUS.Add(new RoomStatusProperty(USING, USING_COLOR));
            LIST_ROOM_STATUS.Add(new RoomStatusProperty(DIRTY, DIRTY_COLOR));
            LIST_ROOM_STATUS.Add(new RoomStatusProperty(CLEANING, CLEANING_COLOR));
            LIST_ROOM_STATUS.Add(new RoomStatusProperty(REPAIRING, REPAIRING_COLOR));
            LIST_ROOM_STATUS.Add(new RoomStatusProperty(BOOK, BOOK_COLOR));

            return LIST_ROOM_STATUS;
        }

    }
}
