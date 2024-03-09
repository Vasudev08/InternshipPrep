namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        // Monster Class
        // Monster Factor class to initaliate the Monster class
        // random number generator 
        
        public string ImageName { get; set; }
        public int MaximumHitPoints { get; private set; }

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
       
        public int RewardExperiencePoints { get; private set; }

        public Monster(string name, string imageName,
            int maximumHitPoints, int hitPoints,
            int minimumDamage, int maximumDamage,
            int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = "D:\\Vasudev_Agarwal\\Work_Fun\\1_Texas_AM\\1_Intership_Preparation\\SOSCSRPG\\Engine\\Images\\Monster\\Snake.png";
            MaximumHitPoints = maximumHitPoints;
            CurrentHitPoints = hitPoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            Gold = rewardGold;


        }

    }
}
