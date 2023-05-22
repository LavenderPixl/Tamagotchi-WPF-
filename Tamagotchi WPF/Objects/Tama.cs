using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_WPF.Objects
{
    public class Tama
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int CurrentMaxXP { get; set; }
        public int Hunger { get; set; }
        public int Amusement { get; set; }
        public int Care { get; set; }
        public int Mood { get; set; }
        public string ImagePath { get; set; }
        public string CreatureType { get; set; }
        public Tama(string name, int level, int xp, int currentMaxXP, int hunger, int amusement, int care, int mood, string imagePath, string creatureType)
        {
            Name = name;
            Level = level;
            XP = xp;
            CurrentMaxXP = currentMaxXP;
            Hunger = hunger;
            Amusement = amusement;
            Care = care;
            Mood = mood;
            ImagePath = imagePath;
            CreatureType = creatureType;
        }

    }
}
