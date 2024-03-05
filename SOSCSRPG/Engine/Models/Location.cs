using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;

namespace Engine.Models
{
    public class Location
    {
        // Properties
        public int XCoordinate {  get; set; }
        public int YCoordinate { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String ImageName { get; set; }

        public List<Quest> QuestsAvaiableHere { get; set; } = new List<Quest>();

        public List<MonsterEncounter> MonstersHere { get; set; } = new List<MonsterEncounter>();

        public Trader TraderHere { get; set; }

        public void AddMonster(int monsterID, int chanceOfEncountering)
        {
            if (MonstersHere.Exists(m => m.MonsterID == monsterID))
            {
                MonstersHere.First(m => m.MonsterID == monsterID)
                    .ChanceOfEncountering = chanceOfEncountering;
            }
            else
            {
                MonstersHere.Add(new MonsterEncounter(monsterID, chanceOfEncountering));
            }
        }

        public Monster GetMonster()
        {
            if (!MonstersHere.Any())
            {
                return null;
            }

            int totalChances = MonstersHere.Sum(m => m.ChanceOfEncountering);

            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalChances);


            int runningTotal = 0;

            foreach (MonsterEncounter monster in MonstersHere)
            {
                runningTotal += monster.ChanceOfEncountering;

                if (randomNumber <= runningTotal)
                {
                    return MonsterFactory.GetMonster(monster.MonsterID);
                }
            }

            return MonsterFactory.GetMonster(MonstersHere.Last().MonsterID);
        }

    }
}
