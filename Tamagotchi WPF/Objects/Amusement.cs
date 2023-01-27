using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_WPF.Objects
{
    public class Amusement
    {
        public string Name { get; set; }
        public int AmusementFillment { get; set; }
        public int ExperiencePoints { get; set; }
        public Amusement(string name, int amusementfillment, int experiencepoints)
        {
            Name = name;
            AmusementFillment = amusementfillment;
            ExperiencePoints = experiencepoints;
        }
    }
}
