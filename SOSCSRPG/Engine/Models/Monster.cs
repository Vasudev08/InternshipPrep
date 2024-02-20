using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : BaseNotificationClass
    {
        // Monster Class
        // Monster Factor class to initaliate the Monster class
        // random number generator 
        private int _hitPoinsts;
        public string Name { get; private set; }
        public string ImageName { get; set; }
        public int MaximumHitPoints { get; private set; }

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int HitPoints
        {
            get { return _hitPoinsts; }
            private set
            {
                _hitPoinsts = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold {  get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }
        public Monster(string name, string imageName,
            int maximumHitPoints, int hitPoints,
            int minimumDamage, int maximumDamage,
            int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = "D:\\Vasudev_Agarwal\\Work_Fun\\1_Texas_AM\\1_Intership_Preparation\\SOSCSRPG\\Engine\\Images\\Monster\\Snake.png";
            MaximumHitPoints = maximumHitPoints;
            HitPoints = hitPoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }

    }
}
