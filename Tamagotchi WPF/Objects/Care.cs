using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_WPF.Objects
{
    public class Care
    {
        public string Name { get; set; }
        public int CareFillment { get; set; }
        public int ExperiencePoints { get; set; }
        public Care(string name, int carefillment, int experiencepoints)
        {
            Name = name;
            CareFillment = carefillment;
            ExperiencePoints = experiencepoints;
        }
    }
}
