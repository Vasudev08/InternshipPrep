using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Engine.Models
{
    public class Player : LivingEntity
    {
        private string _characterClass;
        private int _experiencePoints;

       
        
        public String CharacterClass {
            get
            {
                return _characterClass;
            } 
            set
            {
                _characterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            }
        }

        
        public int ExperiencePoints 
        { 
            get 
            { return _experiencePoints; }
            private set 
            { 
                
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
                SetLevelAndMaximumHitPoints();
            }
        }
      
       
        public ObservableCollection<QuestStatus> Quests { get; set; }

        public event EventHandler OnLeveledUp;

        public Player(string name, string characterClass, int experiencePonits, int maximumHitPoints, int currentHitPoints, int gold) : base(name, maximumHitPoints, currentHitPoints, gold)
        {
            CharacterClass = characterClass;
            ExperiencePoints = experiencePonits;

            Quests = new ObservableCollection<QuestStatus>();
        }

      
        public bool HasAllTheseItems(List<ItemQuantity> items)
        {
            foreach (ItemQuantity item in items)
            {
                if (Inventory.Count(i => i.ItemTypeID == item.ItemID) < item.Quantity)
                {
                    return false;
                }
            }

            return true;
        }

        internal void AddItemToInventory(GameItem gameItem)
        {
            throw new NotImplementedException();
        }

        public void AddExperience(int experiencePoints)
        {
            ExperiencePoints += experiencePoints;
        }

        public void SetLevelAndMaximumHitPoints()
        {
            int originalLevel = Level;
            Level = (ExperiencePoints / 100) + 1;

            if (Level != originalLevel)
            {
                MaximumHitPoints = Level * 10;

                OnLeveledUp?.Invoke(this, System.EventArgs.Empty);
            }
        }
    }
}
