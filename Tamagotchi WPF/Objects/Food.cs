using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_WPF.Objects
{
    public class Food
    {
        public string Name { get; set; }
        public int FoodFillment { get; set; }
        public int ExperiencePoints { get; set; }
        
        public Food(string name, int foodfillment, int experiencepoints)
        {
            Name = name;
            FoodFillment = foodfillment;
            ExperiencePoints = experiencepoints;
        }

    }
}
