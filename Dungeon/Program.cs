using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {

            var House = new List<Room>();
            House.Add(new Room()
            {
                RoomID = 1,
                RoomTitle = "Entrance",
                RoomDescription = "The door is open. Strangers walking by is beckoned to enter...",
                PreviousRoomID = 0,
                ListOfNextRooms = new List<int>() { 2 }
            });

            House.Add(new Room()
            {
                RoomID = 2,
                RoomTitle = "Hallway",
                RoomDescription = "The hallway leads to other rooms...",
                PreviousRoomID = 1,
                ListOfNextRooms = new List<int>() { 3, 4 }
            });

            House.Add(new Room()
            {
                RoomID = 3,
                RoomTitle = "Study",
                RoomDescription = "Dusty study. Unused...",
                PreviousRoomID = 2
            });

            House.Add(new Room()
            {
                RoomID = 4,
                RoomTitle = "Kitchen",
                RoomDescription = "Smelling good!",
                PreviousRoomID = 2
            });

            Room CurrentRoom = House.Where(q => q.RoomID == 2).First();

            Console.WriteLine("Now in: " + CurrentRoom.RoomTitle);
            Console.WriteLine("     " + CurrentRoom.RoomDescription);
            foreach (var item in CurrentRoom.ListOfNextRooms)
            {
                var nextRoom = House.Where(q => q.RoomID == item).First();
                Console.WriteLine("    Next available room: " + nextRoom.RoomTitle + " (" + nextRoom.RoomID + ")");
            }

            

            Console.ReadLine();
        }
    }

    public class Room
    {
        public Room()
        {
            this.ListOfNextRooms = new List<int>();
        }

        public int RoomID { get; set; }

        public string RoomTitle { get; set; }
        public string RoomDescription { get; set; }

        public int PreviousRoomID { get; set; }

        public List<int> ListOfNextRooms { get; set; }

    }


}
