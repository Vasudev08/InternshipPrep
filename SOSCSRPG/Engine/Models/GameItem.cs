using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }

        public bool IsUnique {  get; set; }

        public GameItem(int itemTypeID, string name, int price, bool inUnique = false) 
        { 
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            IsUnique = inUnique;
        }    
        
        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, IsUnique);
        }
    }
}
