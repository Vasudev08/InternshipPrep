using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;
using static System.Net.Mime.MediaTypeNames;
using System.Security;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        // Creating an CurrentPlayer Property which allows us to access Player class members/properties and methods/functions

        private Location _currentLocation;
        public Location CurrentLocation {
            get { return _currentLocation; }
            set 
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
            }
        }
        public Player CurrentPlayer
        { 
            get; 
            set; 
        }
        
        public World CurrentWorld { 
            get; 
            set; 
        }
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

            //CurrentLocation = new Location();
            //CurrentLocation.Name = "Home";
            //CurrentLocation.XCoordinate = 0;
            //CurrentLocation.YCoordinate = -1;
            //CurrentLocation.Description = "This is your house";
            //CurrentLocation.ImageName = "D:\\Vasudev_Agarwal\\Work_Fun\\1_Texas_AM\\1_Intership_Preparation\\SOSCSRPG\\Engine\\Images\\Locations\\Home.png";
            

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);


        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void MoveNorth() 
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void MoveEast() 
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);


        }
        public void MoveSouth() 
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);

        }
        public void MoveWest() 
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);

        }

    }
}
