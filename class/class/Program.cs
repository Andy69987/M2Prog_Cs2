using System;
using System.Collections.Generic;

namespace Dictionaries
{
    internal class Program
    {
        private static Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Room startRoom = new Room(0, 0, "Dit is de startkamer.");
            rooms.Add(startRoom.GetRoomLocationKey(), startRoom);

            Room room1 = new Room(1, 0, "Dit is kamer 1.");
            rooms.Add(room1.GetRoomLocationKey(), room1);

            Room room2 = new Room(0, 1, "Dit is kamer 2.");
            rooms.Add(room2.GetRoomLocationKey(), room2);

            Room room3 = new Room(1, 1, "Dit is kamer 3.");
            rooms.Add(room3.GetRoomLocationKey(), room3);

            ShowRoom(0, 0);
            ShowRoom(1, 0);
            ShowRoom(0, 1);
            ShowRoom(1, 1);
        }

        private static void ShowRoom(int x, int y)
        {
            string key = $"{x},{y}";
            if (rooms.TryGetValue(key, out Room room))
            {
                Console.WriteLine($"Kamer op locatie ({x},{y}): {room.Description}");
            }
            else
            {
                Console.WriteLine($"Geen kamer gevonden op locatie ({x},{y}).");
            }
        }
    }

    internal class Room
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Description { get; set; }

        public Room(int x, int y, string description)
        {
            X = x;
            Y = y;
            Description = description;
        }

        public string GetRoomLocationKey()
        {
            return $"{X},{Y}";
        }
    }
}
