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
using Engine.EventArgs;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {
        public event EventHandler<GameMessageEventArgs> OnMessageRaised;

        // Creating an CurrentPlayer Property which allows us to access Player class members/properties and methods/functions

        private Location _currentLocation;
        private Monster _currentMonster;

        public Monster CurrentMonster
        {
            get { return _currentMonster;}
            set
            {
                _currentMonster = value;
                OnPropertyChanged(nameof(CurrentMonster));
                OnPropertyChanged(nameof(HasMonster));

                if (CurrentMonster != null)
                {
                    RaiseMessage("");
                    RaiseMessage($"You see a {CurrentMonster.Name} here!");
                }
            }
        }
        public Location CurrentLocation {
            get { return _currentLocation; }
            set 
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToSouth));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToWest));

                GivePlayerQuestsAtLocation();
                GetMonsterAtLocation();

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

        public bool HasLocationToNorth
        { get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null; } }

        public bool HasLocationToSouth
        { get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null; } }

        public bool HasLocationToWest
        { get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null; } }

        public bool HasLocationToEast
        { get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null; } }

        public bool HasMonster => CurrentMonster != null;

        public GameSession()
        {
            CurrentPlayer = new Player 
                            { 
                                Name = "Dave", 
                                CharacterClass="Fighter",
                                HitPoints=10,
                                Gold=100000,
                                ExperiencePoints=10,
                                Level=1,
            
                            };
            

            //CurrentLocation = new Location();
            //CurrentLocation.Name = "Home";
            //CurrentLocation.XCoordinate = 0;
            //CurrentLocation.YCoordinate = -1;
            //CurrentLocation.Description = "This is your house";
            //CurrentLocation.ImageName = "D:\\Vasudev_Agarwal\\Work_Fun\\1_Texas_AM\\1_Intership_Preparation\\SOSCSRPG\\Engine\\Images\\Locations\\Home.png";
            

            //WorldFactory factory = new WorldFactory();
            CurrentWorld = WorldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);

            



        }



        public void MoveNorth() 
        {
            if (HasLocationToNorth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);

            }
        }
        public void MoveEast() 
        {
            if (HasLocationToEast)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);

            }


        }
        public void MoveSouth() 
        {
            if (HasLocationToSouth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);

            }

        }
        public void MoveWest() 
        {
            if (HasLocationToWest)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);

            }

        }

        private void GivePlayerQuestsAtLocation()
        {
            foreach(Quest quest in CurrentLocation.QuestsAvaiableHere)
            {
                if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.ID == quest.ID))
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));
                }
            }
        }

        private void GetMonsterAtLocation()
        {
            CurrentMonster = CurrentLocation.GetMonster();
        }

        private void RaiseMessage(string message)
        {
            OnMessageRaised?.Invoke(this, new GameMessageEventArgs(message));   
        }

    }
}
