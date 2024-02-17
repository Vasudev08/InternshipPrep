using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        private int MaximumDamage {  get; set; }
        private int MinimumDamage { get; set; }
        public Weapon(int itemTypeID, string name, int price, int maximumDamage, int minimumDamage) : base(itemTypeID, name, price)
        {
            MaximumDamage = maximumDamage;
            MinimumDamage = minimumDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MaximumDamage, MinimumDamage);
        }
    }
}
