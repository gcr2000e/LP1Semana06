using System;
using System.Runtime.CompilerServices;
using Humanizer;

namespace MyRPG
{
    enum Hardness
    {
        Easy = 0,
        Normal = 1,
        Hard = 2
    }

    enum Enemy
    {
        name
    }

    public class GameLevel
    {
        private string hardness;
        private string name;
        private int roomNum;
        private int RoomID;
        private int numEnemies;

        public string GetLevelHardness()
        {
            return hardness;
        }

        public int GetNumberOfRooms()
        {
            return roomNum;
        }

        public int GetRoomID()
        {
            return RoomID;
        }
        public int GetNumberOfEnemies()
        {
            return numEnemies;
        }

        public string GetName()
        {
            return name;
        }

        public void SetHardness(string newHardness, int value)
        {
            if (value == 0)
            {
                newHardness = Hardness.Easy.ToString();
            }
            else if (value == 1)
            {
                newHardness = Hardness.Normal.ToString();
            }
            else
            {
                newHardness = Hardness.Hard.ToString();
            }
            hardness = newHardness;
        }

        public GameLevel(int roomNum, int RoomID, string name)
        {
            this.RoomID = RoomID;
            this.roomNum = roomNum;
        }

        public void SetEnemyInRoom(string name)
        {
            SetName(name);
        }

        public void SetName(string newName)
        {
            if (newName.Length > 8)
            {
                newName = newName.Substring(0, 8);
            }
            name = newName;
        }

        public void PrintEnemies()
        {
            Console.WriteLine($"Room: {roomNum}: {name}");
        }
    }

    public class Program
    {
        private static void Main()
        {
            GameLevel gl = new GameLevel(104, Hardness.Normal);

            gl.SetEnemyInRoom(1, new Enemy("Worf"));
            gl.SetEnemyInRoom(7, new Enemy("Picard"));
            gl.SetEnemyInRoom(16, new Enemy("Data"));
            gl.SetEnemyInRoom(94, new Enemy("Riker"));
            gl.SetEnemyInRoom(59, new Enemy("Troi"));

            Console.WriteLine($"Difficulty: {gl.GetLevelHardness()}");

            Console.WriteLine($"Number of rooms: {gl.GetNumberOfRooms()}");

            Console.WriteLine($"Number of enemies: {gl.GetNumberOfEnemies()}");

            gl.PrintEnemies();

            // Este programa mostra o seguinte no ecrã:
            //
            // Difficulty: Normal
            // Number of rooms: 104
            // Number of enemies: 5
            // Room I: Worf
            // Room VII: Picard
            // Room XVI: Data
            // Room LIX: Troi
            // Room XCIV: Riker
        }
    }
}
