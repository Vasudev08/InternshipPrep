using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Engine.ViewModels
{
    public class GameSession
    {
        // Creating an CurrentPlayer Property which allows us to access Player class members/properties and methods/functions
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        
        // Creating an Player object inside the contructor and assigning values to that property object
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Dave";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 10000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your house";
            CurrentLocation.ImageName = "D:\\Vasudev_Agarwal\\Work_Fun\\1_Texas_AM\\1_Intership_Preparation\\SOSCSRPG\\Engine\\Images\\Locations\\Home.png";



        }
    }
}
